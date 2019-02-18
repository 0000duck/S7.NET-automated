using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROFINET_STEP_7.Profinet;
using PROFINET_STEP_7.Types;

namespace PROFINET_STEP_7
{
    public partial class FRMMAIN : Form
    {
        private PLC plc = null;
        private ExceptionCode errCode;

        public FRMMAIN()
        {
            InitializeComponent();
        }

        private void FRMMAIN_Load(object sender, EventArgs e)
        {
            try
            {
                plc = new PLC(CPU_Type.S7300, "192.168.3.6", 0, 2);
                errCode = plc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = plc.Read(txtInput.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Write(txtInputForWrite.Text, txtOutputForWrite.Text).ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadQ_Click(object sender, EventArgs e)
        {
            try
            {
                txtQOutput.Text = plc.Read(txtQInput.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadI_Click(object sender, EventArgs e)
        {
            try
            {
                txtIOutput.Text = plc.Read(txtIInput.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadArray_Click(object sender, EventArgs e)
        {
            try
            {
                int NumberOfDB = 203; //DB203
                int StartByteAddress = 4;
                byte[] result = plc.ReadBytes(DataType.DataBlock, NumberOfDB, StartByteAddress, 80);
                ushort[] values = Word.ToArray(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteArray_Click(object sender, EventArgs e)
        {
            try
            {
                //// WRITE 1 ARRAY TO M MEMORY(MB500->MB503
                //byte[] values = new byte[4] { 10, 20, 30, 40 };
                //ExceptionCode ec = plc.WriteBytes(DataType.Marker, 0, 500, values);

                // WRITE 1 ARRAY TO Q OUTPUT(QB15->QB18)
                byte[] values = new byte[4] { 250, 20, 30, 40 };
                ExceptionCode ec = plc.WriteBytes(DataType.Output, 0, 15, values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                //plc.Write("M500.1", 1);
                plc.Write("O15.2", 1); //Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {
                //plc.Write("M500.1", 0);
                plc.Write("O15.2", 0);//Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadReal_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Types.Double.FromDWord((uint)plc.Read("DB90.DBD248"));
                //double value = Types.Double.FromDWord((uint)plc.Read("DB300.DBD2"));
                lblReal.Text = value.ToString("0.#");
                timerReadReal.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteReal_Click(object sender, EventArgs e)
        {
            try
            {
                //double a = Types.Double.FromDWord((uint)plc.Read("DB90.DBD248"));
                byte[] values = Types.Double.ToByteArray(double.Parse(txtReadForWrite.Text));
                ExceptionCode ec = plc.WriteBytes(DataType.DataBlock, 300, 2, values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerReadReal_Tick(object sender, EventArgs e)
        {
            try
            {
                double value = Types.Double.FromDWord((uint)plc.Read("DB90.DBD248"));
                lblReal.Text = value.ToString("0.#");
            }
            catch (Exception)
            {
            }
        }

        private void btnReadRealArray_Click(object sender, EventArgs e)
        {
            try
            {
                int NumberOfDB = 300; //DB300
                int StartByteAddress = 2;
                byte[] result = plc.ReadBytes(DataType.DataBlock, NumberOfDB, StartByteAddress, 24);
                double[] values = Types.Double.ToArray(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
