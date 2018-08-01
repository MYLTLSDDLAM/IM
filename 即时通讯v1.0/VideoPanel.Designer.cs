namespace 即时通讯v1._0
{
    partial class VideoPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.pictureBox_Mic = new System.Windows.Forms.PictureBox();
            this.label_tip = new System.Windows.Forms.Label();
            this.pictureBox_Camera = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.decibelDisplayer1 = new VideoChatRoom.DecibelDisplayer();
            this.toolStripLabel_displayName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Camera)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(322, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Black;
            this.skinPanel1.Controls.Add(this.pictureBox_Mic);
            this.skinPanel1.Controls.Add(this.label_tip);
            this.skinPanel1.Controls.Add(this.pictureBox_Camera);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(3, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(316, 239);
            this.skinPanel1.TabIndex = 2;
            // 
            // pictureBox_Mic
            // 
            this.pictureBox_Mic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mic.Image")));
            this.pictureBox_Mic.Location = new System.Drawing.Point(289, 4);
            this.pictureBox_Mic.Name = "pictureBox_Mic";
            this.pictureBox_Mic.Size = new System.Drawing.Size(26, 31);
            this.pictureBox_Mic.TabIndex = 2;
            this.pictureBox_Mic.TabStop = false;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.BackColor = System.Drawing.Color.Black;
            this.label_tip.ForeColor = System.Drawing.Color.White;
            this.label_tip.Location = new System.Drawing.Point(105, 118);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(91, 15);
            this.label_tip.TabIndex = 1;
            this.label_tip.Text = "正在连接...";
            // 
            // pictureBox_Camera
            // 
            this.pictureBox_Camera.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Camera.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Camera.Image")));
            this.pictureBox_Camera.Location = new System.Drawing.Point(131, 96);
            this.pictureBox_Camera.Name = "pictureBox_Camera";
            this.pictureBox_Camera.Size = new System.Drawing.Size(31, 37);
            this.pictureBox_Camera.TabIndex = 0;
            this.pictureBox_Camera.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Camera, "对方禁用了摄像头");
            // 
            // decibelDisplayer1
            // 
            this.decibelDisplayer1.BackColor = System.Drawing.Color.White;
            this.decibelDisplayer1.Location = new System.Drawing.Point(271, 10);
            this.decibelDisplayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decibelDisplayer1.Name = "decibelDisplayer1";
            this.decibelDisplayer1.Size = new System.Drawing.Size(47, 15);
            this.decibelDisplayer1.TabIndex = 3;
            this.decibelDisplayer1.ValueVisialbe = false;
            this.decibelDisplayer1.Working = true;
            // 
            // toolStripLabel_displayName
            // 
            this.toolStripLabel_displayName.AutoSize = true;
            this.toolStripLabel_displayName.Location = new System.Drawing.Point(40, 10);
            this.toolStripLabel_displayName.Name = "toolStripLabel_displayName";
            this.toolStripLabel_displayName.Size = new System.Drawing.Size(47, 15);
            this.toolStripLabel_displayName.TabIndex = 4;
            this.toolStripLabel_displayName.Text = "XT001";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zheng.jpg");
            this.imageList1.Images.SetKeyName(1, "stop.jpg");
            this.imageList1.Images.SetKeyName(2, "guan.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "zheng.jpg");
            this.imageList2.Images.SetKeyName(1, "stop.jpg");
            this.imageList2.Images.SetKeyName(2, "guan.png");
            // 
            // VideoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripLabel_displayName);
            this.Controls.Add(this.decibelDisplayer1);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VideoPanel";
            this.Size = new System.Drawing.Size(322, 270);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Mic;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.PictureBox pictureBox_Camera;
        private System.Windows.Forms.ToolTip toolTip1;
        private VideoChatRoom.DecibelDisplayer decibelDisplayer1;
        private System.Windows.Forms.Label toolStripLabel_displayName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
