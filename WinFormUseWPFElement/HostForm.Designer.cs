﻿namespace WinFormUseWPFElement
{
    partial class HostForm
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
            this.MyElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // MyElementHost
            // 
            this.MyElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyElementHost.Location = new System.Drawing.Point(0, 0);
            this.MyElementHost.Name = "MyElementHost";
            this.MyElementHost.Size = new System.Drawing.Size(800, 450);
            this.MyElementHost.TabIndex = 0;
            this.MyElementHost.Text = "elementHost1";
            this.MyElementHost.Child = null;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyElementHost);
            this.Name = "HostForm";
            this.Text = "Host Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost MyElementHost;
    }
}
