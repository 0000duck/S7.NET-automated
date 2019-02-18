using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROFINET_STEP_7.Entity;
using PROFINET_STEP_7.Profinet;

namespace PROFINET_STEP_7
{
    public partial class FRMCOLLECTION : Form
    {
        private PLC plc = null;
        private ExceptionCode errCode;

        public FRMCOLLECTION()
        {
            InitializeComponent();
        }
        private void FRMCOLLECTION_Load(object sender, EventArgs e)
        {
            try
            {
                plc = new PLC(CPU_Type.S7400, "192.168.3.1", 0, 3);
                errCode = plc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRealInputOK_Click(object sender, EventArgs e)
        {
            try
            {
                int NumberOfDB = 300; //DB300
                int StartByteAddress = 2;
                int numberOfByte = 24;                
                byte[] result = plc.ReadBytes(DataType.DataBlock, NumberOfDB, StartByteAddress, numberOfByte);
                double[] values = Types.Double.ToArray(result);
                List<FData> list = new List<FData>();
                for (int i = 0; i < values.Length; i++)
                {
                    list.Add(new FData(string.Format("DB{0}.DBD{1}", NumberOfDB, (StartByteAddress += 4)), values[i]));
                }
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FRMMAIN frmMain = new FRMMAIN();
            frmMain.Show();
        }

    }
}
