namespace PROFINET_STEP_7
{
    partial class FRMMAIN
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtInputForWrite = new System.Windows.Forms.TextBox();
            this.txtOutputForWrite = new System.Windows.Forms.TextBox();
            this.txtQInput = new System.Windows.Forms.TextBox();
            this.txtQOutput = new System.Windows.Forms.TextBox();
            this.btnReadQ = new System.Windows.Forms.Button();
            this.txtIInput = new System.Windows.Forms.TextBox();
            this.txtIOutput = new System.Windows.Forms.TextBox();
            this.btnReadI = new System.Windows.Forms.Button();
            this.btnReadArray = new System.Windows.Forms.Button();
            this.btnWriteArray = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnReadReal = new System.Windows.Forms.Button();
            this.timerReadReal = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnWriteReal = new System.Windows.Forms.Button();
            this.txtReadForWrite = new System.Windows.Forms.TextBox();
            this.lblReal = new System.Windows.Forms.Label();
            this.btnReadRealArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(13, 14);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "DB203.DBW 36";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 53);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(150, 26);
            this.txtOutput.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 88);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(150, 38);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(188, 88);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(150, 38);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtInputForWrite
            // 
            this.txtInputForWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputForWrite.Location = new System.Drawing.Point(188, 14);
            this.txtInputForWrite.Name = "txtInputForWrite";
            this.txtInputForWrite.Size = new System.Drawing.Size(150, 26);
            this.txtInputForWrite.TabIndex = 2;
            this.txtInputForWrite.Text = "MW500";
            // 
            // txtOutputForWrite
            // 
            this.txtOutputForWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputForWrite.Location = new System.Drawing.Point(187, 53);
            this.txtOutputForWrite.Name = "txtOutputForWrite";
            this.txtOutputForWrite.Size = new System.Drawing.Size(150, 26);
            this.txtOutputForWrite.TabIndex = 3;
            this.txtOutputForWrite.Text = "1983";
            // 
            // txtQInput
            // 
            this.txtQInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQInput.Location = new System.Drawing.Point(359, 14);
            this.txtQInput.Name = "txtQInput";
            this.txtQInput.Size = new System.Drawing.Size(150, 26);
            this.txtQInput.TabIndex = 0;
            this.txtQInput.Text = "QB6";
            // 
            // txtQOutput
            // 
            this.txtQOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQOutput.Location = new System.Drawing.Point(358, 53);
            this.txtQOutput.Name = "txtQOutput";
            this.txtQOutput.ReadOnly = true;
            this.txtQOutput.Size = new System.Drawing.Size(150, 26);
            this.txtQOutput.TabIndex = 1;
            // 
            // btnReadQ
            // 
            this.btnReadQ.Location = new System.Drawing.Point(358, 88);
            this.btnReadQ.Name = "btnReadQ";
            this.btnReadQ.Size = new System.Drawing.Size(150, 38);
            this.btnReadQ.TabIndex = 1;
            this.btnReadQ.Text = "READ";
            this.btnReadQ.UseVisualStyleBackColor = true;
            this.btnReadQ.Click += new System.EventHandler(this.btnReadQ_Click);
            // 
            // txtIInput
            // 
            this.txtIInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIInput.Location = new System.Drawing.Point(534, 14);
            this.txtIInput.Name = "txtIInput";
            this.txtIInput.Size = new System.Drawing.Size(150, 26);
            this.txtIInput.TabIndex = 0;
            this.txtIInput.Text = "IB4";
            // 
            // txtIOutput
            // 
            this.txtIOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIOutput.Location = new System.Drawing.Point(533, 53);
            this.txtIOutput.Name = "txtIOutput";
            this.txtIOutput.ReadOnly = true;
            this.txtIOutput.Size = new System.Drawing.Size(150, 26);
            this.txtIOutput.TabIndex = 1;
            // 
            // btnReadI
            // 
            this.btnReadI.Location = new System.Drawing.Point(533, 88);
            this.btnReadI.Name = "btnReadI";
            this.btnReadI.Size = new System.Drawing.Size(150, 38);
            this.btnReadI.TabIndex = 1;
            this.btnReadI.Text = "READ";
            this.btnReadI.UseVisualStyleBackColor = true;
            this.btnReadI.Click += new System.EventHandler(this.btnReadI_Click);
            // 
            // btnReadArray
            // 
            this.btnReadArray.Location = new System.Drawing.Point(269, 152);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(150, 38);
            this.btnReadArray.TabIndex = 4;
            this.btnReadArray.Text = "READ ARRAY(BYTES)";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnWriteArray
            // 
            this.btnWriteArray.Location = new System.Drawing.Point(269, 196);
            this.btnWriteArray.Name = "btnWriteArray";
            this.btnWriteArray.Size = new System.Drawing.Size(150, 38);
            this.btnWriteArray.TabIndex = 5;
            this.btnWriteArray.Text = "WRITE ARRAY(BYTES)";
            this.btnWriteArray.UseVisualStyleBackColor = true;
            this.btnWriteArray.Click += new System.EventHandler(this.btnWriteArray_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(475, 152);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(137, 38);
            this.btnON.TabIndex = 6;
            this.btnON.Text = "ON   (Q15.2)";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(475, 196);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(137, 38);
            this.btnOFF.TabIndex = 6;
            this.btnOFF.Text = "OFF   (Q15.2)";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnReadReal
            // 
            this.btnReadReal.Location = new System.Drawing.Point(13, 191);
            this.btnReadReal.Name = "btnReadReal";
            this.btnReadReal.Size = new System.Drawing.Size(150, 38);
            this.btnReadReal.TabIndex = 7;
            this.btnReadReal.Text = "READ(REAL)";
            this.btnReadReal.UseVisualStyleBackColor = true;
            this.btnReadReal.Click += new System.EventHandler(this.btnReadReal_Click);
            // 
            // timerReadReal
            // 
            this.timerReadReal.Interval = 250;
            this.timerReadReal.Tick += new System.EventHandler(this.timerReadReal_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ST1 CASING ADDITION";
            // 
            // btnWriteReal
            // 
            this.btnWriteReal.Location = new System.Drawing.Point(12, 306);
            this.btnWriteReal.Name = "btnWriteReal";
            this.btnWriteReal.Size = new System.Drawing.Size(150, 38);
            this.btnWriteReal.TabIndex = 10;
            this.btnWriteReal.Text = "WRITE(REAL)";
            this.btnWriteReal.UseVisualStyleBackColor = true;
            this.btnWriteReal.Click += new System.EventHandler(this.btnWriteReal_Click);
            // 
            // txtReadForWrite
            // 
            this.txtReadForWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadForWrite.Location = new System.Drawing.Point(13, 274);
            this.txtReadForWrite.Name = "txtReadForWrite";
            this.txtReadForWrite.Size = new System.Drawing.Size(150, 26);
            this.txtReadForWrite.TabIndex = 11;
            this.txtReadForWrite.Text = "0.0";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.BackColor = System.Drawing.Color.Black;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.ForeColor = System.Drawing.Color.Lime;
            this.lblReal.Location = new System.Drawing.Point(46, 237);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(89, 31);
            this.lblReal.TabIndex = 8;
            this.lblReal.Text = "REAL";
            // 
            // btnReadRealArray
            // 
            this.btnReadRealArray.Location = new System.Drawing.Point(269, 253);
            this.btnReadRealArray.Name = "btnReadRealArray";
            this.btnReadRealArray.Size = new System.Drawing.Size(150, 38);
            this.btnReadRealArray.TabIndex = 4;
            this.btnReadRealArray.Text = "READ ARRAY(REAL)";
            this.btnReadRealArray.UseVisualStyleBackColor = true;
            this.btnReadRealArray.Click += new System.EventHandler(this.btnReadRealArray_Click);
            // 
            // FRMMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.txtReadForWrite);
            this.Controls.Add(this.btnWriteReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.btnReadReal);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnWriteArray);
            this.Controls.Add(this.btnReadRealArray);
            this.Controls.Add(this.btnReadArray);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnReadI);
            this.Controls.Add(this.btnReadQ);
            this.Controls.Add(this.txtIOutput);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtQOutput);
            this.Controls.Add(this.txtOutputForWrite);
            this.Controls.Add(this.txtIInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtQInput);
            this.Controls.Add(this.txtInputForWrite);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 397);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(714, 397);
            this.Name = "FRMMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFINET PROTOCOL : DESIGNED BY HOANG VAN LUU";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRMMAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtInputForWrite;
        private System.Windows.Forms.TextBox txtOutputForWrite;
        private System.Windows.Forms.TextBox txtQInput;
        private System.Windows.Forms.TextBox txtQOutput;
        private System.Windows.Forms.Button btnReadQ;
        private System.Windows.Forms.TextBox txtIInput;
        private System.Windows.Forms.TextBox txtIOutput;
        private System.Windows.Forms.Button btnReadI;
        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnWriteArray;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnReadReal;
        private System.Windows.Forms.Timer timerReadReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteReal;
        private System.Windows.Forms.TextBox txtReadForWrite;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Button btnReadRealArray;
    }
}

