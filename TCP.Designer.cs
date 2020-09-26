namespace The_DOS_Toolbox
{
    partial class TCP
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
            this.floodTimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.intervalTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.middleEast = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.australia = new System.Windows.Forms.RadioButton();
            this.proxyStatus = new System.Windows.Forms.CheckBox();
            this.southAmerica = new System.Windows.Forms.RadioButton();
            this.northAmerica = new System.Windows.Forms.RadioButton();
            this.asia = new System.Windows.Forms.RadioButton();
            this.europe = new System.Windows.Forms.RadioButton();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // floodTimer
            // 
            this.floodTimer.Tick += new System.EventHandler(this.floodTimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Message";
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(12, 158);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(113, 20);
            this.messageTxt.TabIndex = 2;
            this.messageTxt.Text = "ABC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Packet Interval";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(176, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop Attack";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start Attack";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "80 is the recommended port. Change port number if needed.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.messageTxt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.intervalTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // intervalTxt
            // 
            this.intervalTxt.Location = new System.Drawing.Point(12, 66);
            this.intervalTxt.Name = "intervalTxt";
            this.intervalTxt.Size = new System.Drawing.Size(113, 20);
            this.intervalTxt.TabIndex = 0;
            this.intervalTxt.Text = "1";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(12, 173);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(151, 20);
            this.portTxt.TabIndex = 5;
            this.portTxt.Text = "80";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(12, 62);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(151, 20);
            this.ipTxt.TabIndex = 3;
            this.ipTxt.Text = "0.0.0.0";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.portTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ipTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "TCP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "The DOS Toolbox";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 262);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.middleEast);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.australia);
            this.tabPage3.Controls.Add(this.proxyStatus);
            this.tabPage3.Controls.Add(this.southAmerica);
            this.tabPage3.Controls.Add(this.northAmerica);
            this.tabPage3.Controls.Add(this.asia);
            this.tabPage3.Controls.Add(this.europe);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(294, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proxy Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // middleEast
            // 
            this.middleEast.AutoSize = true;
            this.middleEast.Location = new System.Drawing.Point(107, 121);
            this.middleEast.Name = "middleEast";
            this.middleEast.Size = new System.Drawing.Size(80, 17);
            this.middleEast.TabIndex = 17;
            this.middleEast.TabStop = true;
            this.middleEast.Text = "Middle East";
            this.middleEast.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Proxy Location";
            // 
            // australia
            // 
            this.australia.AutoSize = true;
            this.australia.Location = new System.Drawing.Point(107, 98);
            this.australia.Name = "australia";
            this.australia.Size = new System.Drawing.Size(65, 17);
            this.australia.TabIndex = 16;
            this.australia.TabStop = true;
            this.australia.Text = "Australia";
            this.australia.UseVisualStyleBackColor = true;
            // 
            // proxyStatus
            // 
            this.proxyStatus.AutoSize = true;
            this.proxyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyStatus.Location = new System.Drawing.Point(9, 14);
            this.proxyStatus.Name = "proxyStatus";
            this.proxyStatus.Size = new System.Drawing.Size(99, 24);
            this.proxyStatus.TabIndex = 10;
            this.proxyStatus.Text = "Use Proxy";
            this.proxyStatus.UseVisualStyleBackColor = true;
            this.proxyStatus.CheckedChanged += new System.EventHandler(this.proxyStatus_CheckedChanged);
            // 
            // southAmerica
            // 
            this.southAmerica.AutoSize = true;
            this.southAmerica.Location = new System.Drawing.Point(107, 75);
            this.southAmerica.Name = "southAmerica";
            this.southAmerica.Size = new System.Drawing.Size(94, 17);
            this.southAmerica.TabIndex = 15;
            this.southAmerica.TabStop = true;
            this.southAmerica.Text = "South America";
            this.southAmerica.UseVisualStyleBackColor = true;
            // 
            // northAmerica
            // 
            this.northAmerica.AutoSize = true;
            this.northAmerica.Location = new System.Drawing.Point(9, 75);
            this.northAmerica.Name = "northAmerica";
            this.northAmerica.Size = new System.Drawing.Size(92, 17);
            this.northAmerica.TabIndex = 12;
            this.northAmerica.TabStop = true;
            this.northAmerica.Text = "North America";
            this.northAmerica.UseVisualStyleBackColor = true;
            // 
            // asia
            // 
            this.asia.AutoSize = true;
            this.asia.Location = new System.Drawing.Point(9, 121);
            this.asia.Name = "asia";
            this.asia.Size = new System.Drawing.Size(45, 17);
            this.asia.TabIndex = 14;
            this.asia.TabStop = true;
            this.asia.Text = "Asia";
            this.asia.UseVisualStyleBackColor = true;
            // 
            // europe
            // 
            this.europe.AutoSize = true;
            this.europe.Location = new System.Drawing.Point(9, 98);
            this.europe.Name = "europe";
            this.europe.Size = new System.Drawing.Size(59, 17);
            this.europe.TabIndex = 13;
            this.europe.TabStop = true;
            this.europe.Text = "Europe";
            this.europe.UseVisualStyleBackColor = true;
            // 
            // TCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TCP";
            this.Text = "TCP";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer floodTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox intervalTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton middleEast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton australia;
        private System.Windows.Forms.CheckBox proxyStatus;
        private System.Windows.Forms.RadioButton southAmerica;
        private System.Windows.Forms.RadioButton northAmerica;
        private System.Windows.Forms.RadioButton asia;
        private System.Windows.Forms.RadioButton europe;
    }
}