namespace 即时通讯v1._0
{
    partial class MainForm
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
            this.multiVideoChatContainer1 = new 即时通讯v1._0.multiVideoChatContainer();
            this.SuspendLayout();
            // 
            // multiVideoChatContainer1
            // 
            this.multiVideoChatContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.multiVideoChatContainer1.Location = new System.Drawing.Point(2, 5);
            this.multiVideoChatContainer1.Name = "multiVideoChatContainer1";
            this.multiVideoChatContainer1.Size = new System.Drawing.Size(749, 507);
            this.multiVideoChatContainer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 524);
            this.Controls.Add(this.multiVideoChatContainer1);
            this.Name = "MainForm";
            this.Text = "视频聊天";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private multiVideoChatContainer multiVideoChatContainer1;
    }
}