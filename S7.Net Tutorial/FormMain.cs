using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROFINET_STEP_7.Profinet;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Data.OracleClient;

namespace PROFINET_STEP_7
{
    

public partial class FormMain : Form
    {
        

        BackgroundWorker worker;
        public void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var x = 0;
            var y = 0;
            int i = 0;

            while (true)
            {
                var BarKod = "";
                var Izlaz = "";

                //1.citanje flag-a (trajanje 10ms)
                if(plc.Read("MW500").ToString() != "0")
                {
                    //2.citanje bar koda sa mem lokacije
                    int dbNumber = 2;
                    int startAddr = 0;
                    plc.ReadBytes(DataType.DataBlock, dbNumber, startAddr, 18);
                    BarKod = System.Text.Encoding.UTF8.GetString(plc.ReadBytes(DataType.DataBlock, dbNumber, startAddr, 18));

                    //3.nalazenje bar koda, iscitavanje izlaza i upis flag-a (oracle db)
                    string queryString = "SELECT * FROM stgrlc WHERE stvsscc LIKE '"+BarKod+"'";
                    using (OracleConnection connection = new OracleConnection("SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.3.17)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=STKTSTKITK)));uid=CONVEYOR;pwd=CONVEYOR;"))
                    {
                        OracleCommand command = new OracleCommand(queryString, connection);
                        connection.Open();
                        using (OracleDataReader reader = command.ExecuteReader())
                        {

                            try
                            {
                                while (reader.Read())
                                {
                                    if(reader.GetString(1) == BarKod)
                                    {
                                        if (reader.GetInt32(7).ToString() == "0")
                                        {
                                            Izlaz = reader.GetString(2);
                                            string queryStringEXE = "UPDATE stgrlc SET stvtrt = '1' WHERE stvsscc LIKE '" + BarKod + "'";
                                            OracleCommand commandEXE = new OracleCommand(queryStringEXE, connection);
                                            commandEXE.ExecuteNonQuery();
                                        }
                                        
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                reader.Close();
                            }

                        }
                        connection.Close();
                        

                    }

                    //4.upis izlaza u mem lokaciju i slanje flag-a
                    //int dbNumber2 = 2;
                    //int startAddr2 = 10;
                    byte[] values2 = PROFINET_STEP_7.Types.String.ToByteArray(Izlaz);

                    //write output
                    plc.WriteBytes(DataType.DataBlock, 2, 10, values2);

                    //write flag
                    plc.Write("MW550", 1).ToString();
                }
                i++;

                textBox1.Text = BarKod;
                label25.Text = plc.Read("MW550").ToString();
                label24.Text = System.Text.Encoding.UTF8.GetString(plc.ReadBytes(DataType.DataBlock, 2, 10, 5));
                label16.Text = (x++).ToString();
                label18.Text = "BAR KOD : " + BarKod;
                label17.Text = "STIGO FLAG: " + (y++).ToString();

                Thread.Sleep(6);

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                MessageBox.Show("Processing cancelled.");
                return;
            }

            // Everything completed normally.
            // process the response using e.Result
            MessageBox.Show("Processing is complete.");
        }
        

        private PLC plc = null;
        private ExceptionCode errCode;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
                cboxPLCs.SelectedIndex = 3;
                txtIPaddress.Text = "192.168.0.20";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIPaddress.Text)) throw new Exception("Xin vui lòng nhập địa chỉ IP");
                int selectionIndex = cboxPLCs.SelectedIndex;
                CPU_Type cpuType = CPU_Type.S7200;
                string ipAddress = txtIPaddress.Text;
                switch (selectionIndex)
                {
                    case 0:
                        cpuType = CPU_Type.S7200;
                        break;
                    case 1:
                        cpuType = CPU_Type.S7300;
                        break;
                    case 2:
                        cpuType = CPU_Type.S7400;
                        break;
                    case 3:
                        cpuType = CPU_Type.S71200;
                        break;
                    default:
                        cboxPLCs.SelectedIndex = 3;
                        cpuType = CPU_Type.S71200;
                        break;
                }
                plc = new PLC(cpuType, ipAddress, (short)numericUpDownRack.Value, (short)numericUpDownSlot.Value);
                if (!plc.IsAvailable) throw new Exception("Không tìm thấy PLC cần kết nối!");
                errCode = plc.Open();
                if (errCode != ExceptionCode.ExceptionNo) throw new Exception(plc.lastErrorString);
                this.SetEnabledBotton(false);

                //BackgroundWorker START
                worker = new BackgroundWorker();
                worker.WorkerSupportsCancellation = true;

                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                //worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

                //worker.DoWork += (obj, ea) => worker_DoWork();
                worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
                if (worker != null) worker.CancelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void SetEnabledBotton(bool flag)
        {
            btnConnection.Enabled = flag;
            txtIPaddress.Enabled = flag;
            cboxPLCs.Enabled = flag;
            numericUpDownRack.Enabled = flag;
            numericUpDownSlot.Enabled = flag;
            btnDisconnection.Enabled = !btnConnection.Enabled;
        }

        private int db;
        private int startByteAddr;
        private object S7Net;

        private void btnReadReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //double value = Types.Double.FromDWord((uint)plc.Read("DB90.DBD248"));
                string[] tempStrg = txtRealOutput.Text.Split('.');
                int size = tempStrg.Length;
                double value = 0;
                db = 0;
                startByteAddr = 0;
                if (size >= 2)
                {
                    db = int.Parse(tempStrg[0].Substring(2, tempStrg[0].Length - 2));
                    startByteAddr = int.Parse(tempStrg[1].Substring(3, tempStrg[1].Length - 3));
                }
                value = Types.Double.FromDWord((uint)plc.Read(txtRealOutput.Text));
                txtRealInput.Text = value.ToString("0.#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                byte[] values = Types.Double.ToByteArray(double.Parse(txtRealInput.Text));
                if (db != 0 && startByteAddr != 0)
                    plc.WriteBytes(DataType.DataBlock, 90, 248, values);
                else
                    plc.WriteBytes(DataType.Marker, 0, int.Parse(txtRealOutput.Text.Substring(2, txtRealOutput.Text.Length - 2)), values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                txtWordInput.Text = plc.Read(txtWordOutput.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtWordInput.Text != "")
            {
                textBinaryBox.Text = Convert.ToString(Convert.ToInt32(txtWordInput.Text), 2);

            }
        }

        private void btnWriteWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write(txtWordOutput.Text, txtWordInput.Text).ToString();

                var x = txtWordOutput.Text.ToString()+" : "+txtWordInput.Text.ToString();
                //TEST
                MessageBox.Show(this, x, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                plc.Write("O2.7", 1); //Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                plc.Write("O2.7", 0); //Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOn_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write("M100.1", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write("M100.1", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void bitON_Click(object sender, EventArgs e)
        {

            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                plc.Write(textbitAddr.Text, 1); //Q15.2 change to a bit (O instead of Q).
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitOFF_Click(object sender, EventArgs e)
        {

            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                plc.Write(textbitAddr.Text, 0); //Q15.2 change to a bit (O instead of Q).
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void numericUpDownRack_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboxPLCs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownSlot_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSendString_Click(object sender, EventArgs e)
        {
            try
            {

                //int dbNumber = 2;
                //int startAddr = 0;
                string input = txtSting.Text;

                byte[] values = PROFINET_STEP_7.Types.String.ToByteArray(input);
                plc.WriteBytes(DataType.DataBlock, Int32.Parse(txtDB.Text), Int32.Parse(txtDBstartAddr.Text), values);
                //MessageBox.Show(this, System.Text.Encoding.UTF8.GetString(x) , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error));

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbitAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRealInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRealOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(worker!=null) worker.CancelAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //int dbNumber = 2;
                //int startAddr = 0;

                int dbNumber = Int32.Parse(textBox2.Text);
                int startAddr = Int32.Parse(textBox3.Text);

                plc.ReadBytes(DataType.DataBlock, dbNumber, startAddr, Int32.Parse(textBox5.Text));
                textBox1.Text = System.Text.Encoding.UTF8.GetString(plc.ReadBytes(DataType.DataBlock, dbNumber, startAddr, Int32.Parse(textBox5.Text))); 
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

