namespace The_DOS_Toolbox
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.UDP = new System.Windows.Forms.Button();
            this.TCP = new System.Windows.Forms.Button();
            this.slowloris = new System.Windows.Forms.Button();
            this.amplifiedudp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "The DOS Toolbox";
            // 
            // UDP
            // 
            this.UDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDP.Location = new System.Drawing.Point(22, 98);
            this.UDP.Name = "UDP";
            this.UDP.Size = new System.Drawing.Size(132, 47);
            this.UDP.TabIndex = 1;
            this.UDP.Text = "UDP";
            this.UDP.UseVisualStyleBackColor = true;
            this.UDP.Click += new System.EventHandler(this.UDP_Click);
            // 
            // TCP
            // 
            this.TCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP.Location = new System.Drawing.Point(294, 98);
            this.TCP.Name = "TCP";
            this.TCP.Size = new System.Drawing.Size(132, 47);
            this.TCP.TabIndex = 2;
            this.TCP.Text = "TCP";
            this.TCP.UseVisualStyleBackColor = true;
            this.TCP.Click += new System.EventHandler(this.TCP_Click);
            // 
            // slowloris
            // 
            this.slowloris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowloris.Location = new System.Drawing.Point(160, 98);
            this.slowloris.Name = "slowloris";
            this.slowloris.Size = new System.Drawing.Size(128, 47);
            this.slowloris.TabIndex = 3;
            this.slowloris.Text = "Slowloris";
            this.slowloris.UseVisualStyleBackColor = true;
            this.slowloris.Click += new System.EventHandler(this.slowloris_Click);
            // 
            // amplifiedudp
            // 
            this.amplifiedudp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplifiedudp.Location = new System.Drawing.Point(160, 166);
            this.amplifiedudp.Name = "amplifiedudp";
            this.amplifiedudp.Size = new System.Drawing.Size(128, 59);
            this.amplifiedudp.TabIndex = 4;
            this.amplifiedudp.Text = "Amplified DOS";
            this.amplifiedudp.UseVisualStyleBackColor = true;
            this.amplifiedudp.Click += new System.EventHandler(this.amplifiedudp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 237);
            this.Controls.Add(this.amplifiedudp);
            this.Controls.Add(this.slowloris);
            this.Controls.Add(this.TCP);
            this.Controls.Add(this.UDP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "The DOS Toolbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UDP;
        private System.Windows.Forms.Button TCP;
        private System.Windows.Forms.Button slowloris;
        private System.Windows.Forms.Button amplifiedudp;
    }
}

