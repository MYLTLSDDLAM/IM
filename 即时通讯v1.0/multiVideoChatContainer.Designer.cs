namespace 即时通讯v1._0
{
    partial class multiVideoChatContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multiVideoChatContainer));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.decibelDisplayer_speaker = new VideoChatRoom.DecibelDisplayer();
            this.decibelDisplayer_mic = new VideoChatRoom.DecibelDisplayer();
            this.skinCheckBox_speaker = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox_mic = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox_camera = new CCWin.SkinControl.SkinCheckBox();
            this.groupBox_members = new CCWin.SkinControl.SkinGroupBox();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.skinGroupBox1.SuspendLayout();
            this.groupBox_members.SuspendLayout();
            this.skinToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.White;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.Controls.Add(this.decibelDisplayer_speaker);
            this.skinGroupBox1.Controls.Add(this.decibelDisplayer_mic);
            this.skinGroupBox1.Controls.Add(this.skinCheckBox_speaker);
            this.skinGroupBox1.Controls.Add(this.skinCheckBox_mic);
            this.skinGroupBox1.Controls.Add(this.skinCheckBox_camera);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(726, 109);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "我的设备";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Enter += new System.EventHandler(this.skinGroupBox1_Enter);
            // 
            // decibelDisplayer_speaker
            // 
            this.decibelDisplayer_speaker.BackColor = System.Drawing.Color.White;
            this.decibelDisplayer_speaker.Location = new System.Drawing.Point(419, 59);
            this.decibelDisplayer_speaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decibelDisplayer_speaker.Name = "decibelDisplayer_speaker";
            this.decibelDisplayer_speaker.Size = new System.Drawing.Size(48, 23);
            this.decibelDisplayer_speaker.TabIndex = 7;
            this.decibelDisplayer_speaker.ValueVisialbe = false;
            this.decibelDisplayer_speaker.Working = true;
            // 
            // decibelDisplayer_mic
            // 
            this.decibelDisplayer_mic.BackColor = System.Drawing.Color.White;
            this.decibelDisplayer_mic.Location = new System.Drawing.Point(259, 59);
            this.decibelDisplayer_mic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decibelDisplayer_mic.Name = "decibelDisplayer_mic";
            this.decibelDisplayer_mic.Size = new System.Drawing.Size(48, 23);
            this.decibelDisplayer_mic.TabIndex = 6;
            this.decibelDisplayer_mic.ValueVisialbe = false;
            this.decibelDisplayer_mic.Working = true;
            // 
            // skinCheckBox_speaker
            // 
            this.skinCheckBox_speaker.AutoSize = true;
            this.skinCheckBox_speaker.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_speaker.Checked = true;
            this.skinCheckBox_speaker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_speaker.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_speaker.DownBack = null;
            this.skinCheckBox_speaker.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_speaker.Location = new System.Drawing.Point(336, 59);
            this.skinCheckBox_speaker.MouseBack = null;
            this.skinCheckBox_speaker.Name = "skinCheckBox_speaker";
            this.skinCheckBox_speaker.NormlBack = null;
            this.skinCheckBox_speaker.SelectedDownBack = null;
            this.skinCheckBox_speaker.SelectedMouseBack = null;
            this.skinCheckBox_speaker.SelectedNormlBack = null;
            this.skinCheckBox_speaker.Size = new System.Drawing.Size(76, 24);
            this.skinCheckBox_speaker.TabIndex = 5;
            this.skinCheckBox_speaker.Text = "扬声器";
            this.skinCheckBox_speaker.UseVisualStyleBackColor = false;
            this.skinCheckBox_speaker.CheckedChanged += new System.EventHandler(this.skinCheckBox_speaker_CheckedChanged);
            // 
            // skinCheckBox_mic
            // 
            this.skinCheckBox_mic.AutoSize = true;
            this.skinCheckBox_mic.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_mic.Checked = true;
            this.skinCheckBox_mic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_mic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_mic.DownBack = null;
            this.skinCheckBox_mic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_mic.Location = new System.Drawing.Point(186, 59);
            this.skinCheckBox_mic.MouseBack = null;
            this.skinCheckBox_mic.Name = "skinCheckBox_mic";
            this.skinCheckBox_mic.NormlBack = null;
            this.skinCheckBox_mic.SelectedDownBack = null;
            this.skinCheckBox_mic.SelectedMouseBack = null;
            this.skinCheckBox_mic.SelectedNormlBack = null;
            this.skinCheckBox_mic.Size = new System.Drawing.Size(76, 24);
            this.skinCheckBox_mic.TabIndex = 4;
            this.skinCheckBox_mic.Text = "麦克风";
            this.skinCheckBox_mic.UseVisualStyleBackColor = false;
            this.skinCheckBox_mic.CheckedChanged += new System.EventHandler(this.skinCheckBox_mic_CheckedChanged);
            // 
            // skinCheckBox_camera
            // 
            this.skinCheckBox_camera.AutoSize = true;
            this.skinCheckBox_camera.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_camera.Checked = true;
            this.skinCheckBox_camera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_camera.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_camera.DownBack = null;
            this.skinCheckBox_camera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_camera.Location = new System.Drawing.Point(38, 59);
            this.skinCheckBox_camera.MouseBack = null;
            this.skinCheckBox_camera.Name = "skinCheckBox_camera";
            this.skinCheckBox_camera.NormlBack = null;
            this.skinCheckBox_camera.SelectedDownBack = null;
            this.skinCheckBox_camera.SelectedMouseBack = null;
            this.skinCheckBox_camera.SelectedNormlBack = null;
            this.skinCheckBox_camera.Size = new System.Drawing.Size(76, 24);
            this.skinCheckBox_camera.TabIndex = 3;
            this.skinCheckBox_camera.Text = "摄像头";
            this.skinCheckBox_camera.UseVisualStyleBackColor = false;
            this.skinCheckBox_camera.CheckedChanged += new System.EventHandler(this.skinCheckBox_camera_CheckedChanged);
            // 
            // groupBox_members
            // 
            this.groupBox_members.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_members.BorderColor = System.Drawing.Color.DimGray;
            this.groupBox_members.Controls.Add(this.skinToolStrip1);
            this.groupBox_members.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_members.ForeColor = System.Drawing.Color.Black;
            this.groupBox_members.Location = new System.Drawing.Point(3, 118);
            this.groupBox_members.Name = "groupBox_members";
            this.groupBox_members.RectBackColor = System.Drawing.Color.White;
            this.groupBox_members.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupBox_members.Size = new System.Drawing.Size(723, 596);
            this.groupBox_members.TabIndex = 2;
            this.groupBox_members.TabStop = false;
            this.groupBox_members.Text = "成员列表";
            this.groupBox_members.TitleBorderColor = System.Drawing.Color.Transparent;
            this.groupBox_members.TitleRectBackColor = System.Drawing.Color.White;
            this.groupBox_members.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.AutoSize = false;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 4;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.skinToolStrip1.Location = new System.Drawing.Point(3, 21);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(717, 25);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 1;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.skinToolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "邀请好友加入";
            this.toolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(704, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // multiVideoChatContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox_members);
            this.Controls.Add(this.skinGroupBox1);
            this.Name = "multiVideoChatContainer";
            this.Size = new System.Drawing.Size(726, 589);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.groupBox_members.ResumeLayout(false);
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_speaker;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_mic;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_camera;
        private VideoChatRoom.DecibelDisplayer decibelDisplayer_speaker;
        private VideoChatRoom.DecibelDisplayer decibelDisplayer_mic;
        private CCWin.SkinControl.SkinGroupBox groupBox_members;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
