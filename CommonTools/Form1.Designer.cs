﻿namespace CommonTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPing = new System.Windows.Forms.Button();
            this.btnGBK2UTF8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(24, 28);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(132, 23);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "多IP自动Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            // 
            // btnGBK2UTF8
            // 
            this.btnGBK2UTF8.Location = new System.Drawing.Point(24, 76);
            this.btnGBK2UTF8.Name = "btnGBK2UTF8";
            this.btnGBK2UTF8.Size = new System.Drawing.Size(226, 23);
            this.btnGBK2UTF8.TabIndex = 1;
            this.btnGBK2UTF8.Text = "文件夹下GBK转化成UTF8";
            this.btnGBK2UTF8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 443);
            this.Controls.Add(this.btnGBK2UTF8);
            this.Controls.Add(this.btnPing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnGBK2UTF8;
    }
}

