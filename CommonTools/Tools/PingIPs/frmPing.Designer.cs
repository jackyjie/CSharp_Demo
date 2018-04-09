namespace CommonTools.Tools.PingIPs
{
    partial class frmPing
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPingIcmp = new System.Windows.Forms.Button();
            this.btnPingMultiIcmp = new System.Windows.Forms.Button();
            this.btnPingMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 159);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(134, 165);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(139, 23);
            this.btnPing.TabIndex = 1;
            this.btnPing.Text = "PingClass_Ping单线程";
            this.btnPing.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "间隔字符串";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = ",";
            // 
            // btnPingIcmp
            // 
            this.btnPingIcmp.Location = new System.Drawing.Point(134, 194);
            this.btnPingIcmp.Name = "btnPingIcmp";
            this.btnPingIcmp.Size = new System.Drawing.Size(138, 23);
            this.btnPingIcmp.TabIndex = 4;
            this.btnPingIcmp.Text = "ICMP_Ping单线程";
            this.btnPingIcmp.UseVisualStyleBackColor = true;
            // 
            // btnPingMultiIcmp
            // 
            this.btnPingMultiIcmp.Location = new System.Drawing.Point(133, 252);
            this.btnPingMultiIcmp.Name = "btnPingMultiIcmp";
            this.btnPingMultiIcmp.Size = new System.Drawing.Size(138, 23);
            this.btnPingMultiIcmp.TabIndex = 6;
            this.btnPingMultiIcmp.Text = "ICMP_Ping多线程";
            this.btnPingMultiIcmp.UseVisualStyleBackColor = true;
            // 
            // btnPingMulti
            // 
            this.btnPingMulti.Location = new System.Drawing.Point(133, 223);
            this.btnPingMulti.Name = "btnPingMulti";
            this.btnPingMulti.Size = new System.Drawing.Size(139, 23);
            this.btnPingMulti.TabIndex = 5;
            this.btnPingMulti.Text = "PingClass_Ping多线程";
            this.btnPingMulti.UseVisualStyleBackColor = true;
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.btnPingMultiIcmp);
            this.Controls.Add(this.btnPingMulti);
            this.Controls.Add(this.btnPingIcmp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmPing";
            this.Text = "IP地址Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPingIcmp;
        private System.Windows.Forms.Button btnPingMultiIcmp;
        private System.Windows.Forms.Button btnPingMulti;
    }
}