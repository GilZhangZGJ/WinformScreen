﻿namespace CompositingTable
{
    partial class Main
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
            this.Btn = new System.Windows.Forms.Button();
            this.pictureBoxRet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRet)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(88, 12);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 0;
            this.Btn.Text = "合成按钮";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // pictureBoxRet
            // 
            this.pictureBoxRet.Location = new System.Drawing.Point(43, 54);
            this.pictureBoxRet.Name = "pictureBoxRet";
            this.pictureBoxRet.Size = new System.Drawing.Size(904, 508);
            this.pictureBoxRet.TabIndex = 1;
            this.pictureBoxRet.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 574);
            this.Controls.Add(this.pictureBoxRet);
            this.Controls.Add(this.Btn);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.PictureBox pictureBoxRet;
    }
}
