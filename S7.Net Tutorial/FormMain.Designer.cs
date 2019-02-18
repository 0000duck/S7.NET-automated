namespace PROFINET_STEP_7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxPLCs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnDisconnection = new System.Windows.Forms.Button();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.numericUpDownSlot = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRack = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRealOutput = new System.Windows.Forms.TextBox();
            this.txtRealInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadReal = new System.Windows.Forms.Button();
            this.btnWriteReal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWordOutput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWordInput = new System.Windows.Forms.TextBox();
            this.textBinaryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReadWord = new System.Windows.Forms.Button();
            this.btnWriteWord = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnMOn = new System.Windows.Forms.Button();
            this.btnMOff = new System.Windows.Forms.Button();
            this.bitON = new System.Windows.Forms.Button();
            this.bitOFF = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textbitAddr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSting = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSendString = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtDBstartAddr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBoxConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type PLC:";
            // 
            // cboxPLCs
            // 
            this.cboxPLCs.FormattingEnabled = true;
            this.cboxPLCs.Items.AddRange(new object[] {
            "S7-200",
            "S7-300",
            "S7-400",
            "S7-1200"});
            this.cboxPLCs.Location = new System.Drawing.Point(80, 26);
            this.cboxPLCs.Name = "cboxPLCs";
            this.cboxPLCs.Size = new System.Drawing.Size(193, 24);
            this.cboxPLCs.TabIndex = 1;
            this.cboxPLCs.SelectedIndexChanged += new System.EventHandler(this.cboxPLCs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP address:";
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(80, 61);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(193, 22);
            this.txtIPaddress.TabIndex = 2;
            this.txtIPaddress.Text = "192.168.3.1";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(279, 22);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(115, 33);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnDisconnection
            // 
            this.btnDisconnection.Location = new System.Drawing.Point(279, 62);
            this.btnDisconnection.Name = "btnDisconnection";
            this.btnDisconnection.Size = new System.Drawing.Size(115, 33);
            this.btnDisconnection.TabIndex = 3;
            this.btnDisconnection.Text = "Disconnect";
            this.btnDisconnection.UseVisualStyleBackColor = true;
            this.btnDisconnection.Click += new System.EventHandler(this.btnDisconnection_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.numericUpDownSlot);
            this.groupBoxConnection.Controls.Add(this.numericUpDownRack);
            this.groupBoxConnection.Controls.Add(this.txtIPaddress);
            this.groupBoxConnection.Controls.Add(this.btnDisconnection);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.label8);
            this.groupBoxConnection.Controls.Add(this.btnConnection);
            this.groupBoxConnection.Controls.Add(this.label7);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.cboxPLCs);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(408, 166);
            this.groupBoxConnection.TabIndex = 4;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection information";
            // 
            // numericUpDownSlot
            // 
            this.numericUpDownSlot.Location = new System.Drawing.Point(82, 130);
            this.numericUpDownSlot.Name = "numericUpDownSlot";
            this.numericUpDownSlot.Size = new System.Drawing.Size(190, 22);
            this.numericUpDownSlot.TabIndex = 4;
            this.numericUpDownSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSlot.ValueChanged += new System.EventHandler(this.numericUpDownSlot_ValueChanged);
            // 
            // numericUpDownRack
            // 
            this.numericUpDownRack.Location = new System.Drawing.Point(82, 96);
            this.numericUpDownRack.Name = "numericUpDownRack";
            this.numericUpDownRack.Size = new System.Drawing.Size(190, 22);
            this.numericUpDownRack.TabIndex = 4;
            this.numericUpDownRack.ValueChanged += new System.EventHandler(this.numericUpDownRack_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Slot:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rack:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRealOutput);
            this.groupBox1.Controls.Add(this.txtRealInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnReadReal);
            this.groupBox1.Controls.Add(this.btnWriteReal);
            this.groupBox1.Location = new System.Drawing.Point(426, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read / write real numbers";
            // 
            // txtRealOutput
            // 
            this.txtRealOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealOutput.Location = new System.Drawing.Point(79, 27);
            this.txtRealOutput.Name = "txtRealOutput";
            this.txtRealOutput.Size = new System.Drawing.Size(131, 26);
            this.txtRealOutput.TabIndex = 15;
            this.txtRealOutput.Text = "DB90.DBD248";
            this.txtRealOutput.TextChanged += new System.EventHandler(this.txtRealOutput_TextChanged);
            // 
            // txtRealInput
            // 
            this.txtRealInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealInput.Location = new System.Drawing.Point(79, 65);
            this.txtRealInput.Name = "txtRealInput";
            this.txtRealInput.Size = new System.Drawing.Size(131, 26);
            this.txtRealInput.TabIndex = 15;
            this.txtRealInput.Text = "0.0";
            this.txtRealInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRealInput.TextChanged += new System.EventHandler(this.txtRealInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "I/O:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address:";
            // 
            // btnReadReal
            // 
            this.btnReadReal.Location = new System.Drawing.Point(221, 26);
            this.btnReadReal.Name = "btnReadReal";
            this.btnReadReal.Size = new System.Drawing.Size(112, 31);
            this.btnReadReal.TabIndex = 12;
            this.btnReadReal.Text = "Read data";
            this.btnReadReal.UseVisualStyleBackColor = true;
            this.btnReadReal.Click += new System.EventHandler(this.btnReadReal_Click);
            // 
            // btnWriteReal
            // 
            this.btnWriteReal.Location = new System.Drawing.Point(221, 60);
            this.btnWriteReal.Name = "btnWriteReal";
            this.btnWriteReal.Size = new System.Drawing.Size(112, 31);
            this.btnWriteReal.TabIndex = 14;
            this.btnWriteReal.Text = "Write data";
            this.btnWriteReal.UseVisualStyleBackColor = true;
            this.btnWriteReal.Click += new System.EventHandler(this.btnWriteReal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWordOutput);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtWordInput);
            this.groupBox2.Controls.Add(this.textBinaryBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnReadWord);
            this.groupBox2.Controls.Add(this.btnWriteWord);
            this.groupBox2.Location = new System.Drawing.Point(425, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 228);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read / write integer";
            // 
            // txtWordOutput
            // 
            this.txtWordOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordOutput.Location = new System.Drawing.Point(79, 27);
            this.txtWordOutput.Name = "txtWordOutput";
            this.txtWordOutput.Size = new System.Drawing.Size(131, 26);
            this.txtWordOutput.TabIndex = 15;
            this.txtWordOutput.Text = "MW500";
            this.txtWordOutput.TextChanged += new System.EventHandler(this.txtWordOutput_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "I/O:";
            // 
            // txtWordInput
            // 
            this.txtWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordInput.Location = new System.Drawing.Point(79, 65);
            this.txtWordInput.Name = "txtWordInput";
            this.txtWordInput.Size = new System.Drawing.Size(131, 26);
            this.txtWordInput.TabIndex = 15;
            this.txtWordInput.Text = "0";
            this.txtWordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWordInput.TextChanged += new System.EventHandler(this.txtWordInput_TextChanged);
            // 
            // textBinaryBox
            // 
            this.textBinaryBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBinaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBinaryBox.Location = new System.Drawing.Point(89, 154);
            this.textBinaryBox.Multiline = true;
            this.textBinaryBox.Name = "textBinaryBox";
            this.textBinaryBox.Size = new System.Drawing.Size(291, 52);
            this.textBinaryBox.TabIndex = 15;
            this.textBinaryBox.Text = "0";
            this.textBinaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBinaryBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "I/O:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // btnReadWord
            // 
            this.btnReadWord.Location = new System.Drawing.Point(221, 16);
            this.btnReadWord.Name = "btnReadWord";
            this.btnReadWord.Size = new System.Drawing.Size(112, 31);
            this.btnReadWord.TabIndex = 12;
            this.btnReadWord.Text = "Read data";
            this.btnReadWord.UseVisualStyleBackColor = true;
            this.btnReadWord.Click += new System.EventHandler(this.btnReadWord_Click);
            // 
            // btnWriteWord
            // 
            this.btnWriteWord.Location = new System.Drawing.Point(221, 60);
            this.btnWriteWord.Name = "btnWriteWord";
            this.btnWriteWord.Size = new System.Drawing.Size(112, 31);
            this.btnWriteWord.TabIndex = 14;
            this.btnWriteWord.Text = "Write data";
            this.btnWriteWord.UseVisualStyleBackColor = true;
            this.btnWriteWord.Click += new System.EventHandler(this.btnWriteWord_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(511, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(305, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "0.7 0.6 0.5 0.4 0.3 0.2 0.1 0.0 1.7 1.6 1.5 1.4 1.3 1.2 1.1 1.0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(12, 232);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(137, 38);
            this.btnOFF.TabIndex = 7;
            this.btnOFF.Text = "OFF  (Q2.7)";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(12, 188);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(137, 38);
            this.btnON.TabIndex = 8;
            this.btnON.Text = "ON   (Q2.7)";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnMOn
            // 
            this.btnMOn.Location = new System.Drawing.Point(155, 186);
            this.btnMOn.Name = "btnMOn";
            this.btnMOn.Size = new System.Drawing.Size(137, 38);
            this.btnMOn.TabIndex = 8;
            this.btnMOn.Text = "ON   (M100.1)";
            this.btnMOn.UseVisualStyleBackColor = true;
            this.btnMOn.Click += new System.EventHandler(this.btnMOn_Click);
            // 
            // btnMOff
            // 
            this.btnMOff.Location = new System.Drawing.Point(155, 230);
            this.btnMOff.Name = "btnMOff";
            this.btnMOff.Size = new System.Drawing.Size(137, 38);
            this.btnMOff.TabIndex = 7;
            this.btnMOff.Text = "OFF   (M100.1)";
            this.btnMOff.UseVisualStyleBackColor = true;
            this.btnMOff.Click += new System.EventHandler(this.btnMOff_Click);
            // 
            // bitON
            // 
            this.bitON.Location = new System.Drawing.Point(216, 24);
            this.bitON.Name = "bitON";
            this.bitON.Size = new System.Drawing.Size(117, 35);
            this.bitON.TabIndex = 14;
            this.bitON.Text = "ON";
            this.bitON.UseVisualStyleBackColor = true;
            this.bitON.Click += new System.EventHandler(this.bitON_Click);
            // 
            // bitOFF
            // 
            this.bitOFF.Location = new System.Drawing.Point(216, 67);
            this.bitOFF.Name = "bitOFF";
            this.bitOFF.Size = new System.Drawing.Size(117, 35);
            this.bitOFF.TabIndex = 12;
            this.bitOFF.Text = "OFF";
            this.bitOFF.UseVisualStyleBackColor = true;
            this.bitOFF.Click += new System.EventHandler(this.bitOFF_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textbitAddr);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.bitON);
            this.groupBox3.Controls.Add(this.bitOFF);
            this.groupBox3.Location = new System.Drawing.Point(425, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 108);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "On / Off Memory=M , Output=O";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status:";
            // 
            // textbitAddr
            // 
            this.textbitAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbitAddr.Location = new System.Drawing.Point(79, 26);
            this.textbitAddr.Name = "textbitAddr";
            this.textbitAddr.Size = new System.Drawing.Size(131, 24);
            this.textbitAddr.TabIndex = 20;
            this.textbitAddr.Text = "M1.1";
            this.textbitAddr.TextChanged += new System.EventHandler(this.textbitAddr_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Address:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 52);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSting
            // 
            this.txtSting.Location = new System.Drawing.Point(114, 48);
            this.txtSting.Name = "txtSting";
            this.txtSting.Size = new System.Drawing.Size(250, 22);
            this.txtSting.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "String ";
            // 
            // btnSendString
            // 
            this.btnSendString.Location = new System.Drawing.Point(236, 89);
            this.btnSendString.Name = "btnSendString";
            this.btnSendString.Size = new System.Drawing.Size(128, 63);
            this.btnSendString.TabIndex = 26;
            this.btnSendString.Text = "Write data";
            this.btnSendString.UseVisualStyleBackColor = true;
            this.btnSendString.Click += new System.EventHandler(this.btnSendString_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(114, 78);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 22);
            this.txtDB.TabIndex = 27;
            this.txtDB.TextChanged += new System.EventHandler(this.txtDB_TextChanged);
            // 
            // txtDBstartAddr
            // 
            this.txtDBstartAddr.Location = new System.Drawing.Point(114, 106);
            this.txtDBstartAddr.Name = "txtDBstartAddr";
            this.txtDBstartAddr.Size = new System.Drawing.Size(100, 22);
            this.txtDBstartAddr.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "DB No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Start Addr";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "BGworker";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "Flag";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "BarKod";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtSting);
            this.groupBox4.Controls.Add(this.btnSendString);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtDB);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtDBstartAddr);
            this.groupBox4.Location = new System.Drawing.Point(835, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 368);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read / write string";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(24, 299);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Start Addr";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "DB No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 69);
            this.button1.TabIndex = 32;
            this.button1.Text = "Read data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 16);
            this.label19.TabIndex = 31;
            this.label19.Text = "String (data)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(904, 427);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "output";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1171, 427);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 16);
            this.label25.TabIndex = 37;
            this.label25.Text = "output flag";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 37;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 16);
            this.label22.TabIndex = 38;
            this.label22.Text = "Input No";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 327);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 16);
            this.label23.TabIndex = 39;
            this.label23.Text = "Input No";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 327);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 40;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 491);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnMOff);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnMOn);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 324);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFINET S7(200/300/400/1200)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPLCs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnDisconnection;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRealInput;
        private System.Windows.Forms.Button btnReadReal;
        private System.Windows.Forms.Button btnWriteReal;
        private System.Windows.Forms.TextBox txtRealOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWordOutput;
        private System.Windows.Forms.TextBox txtWordInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReadWord;
        private System.Windows.Forms.Button btnWriteWord;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.NumericUpDown numericUpDownSlot;
        private System.Windows.Forms.NumericUpDown numericUpDownRack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMOn;
        private System.Windows.Forms.Button btnMOff;
        private System.Windows.Forms.Button bitON;
        private System.Windows.Forms.Button bitOFF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textbitAddr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBinaryBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSting;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSendString;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtDBstartAddr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label23;
    }
}