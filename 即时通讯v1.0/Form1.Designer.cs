namespace 即时通讯v1._0
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
            this.components = new System.ComponentModel.Container();
            this.account = new CCWin.SkinControl.SkinTextBox();
            this.password = new CCWin.SkinControl.SkinTextBox();
            this.login = new CCWin.SkinControl.SkinButton();
            this.register = new System.Windows.Forms.Label();
            this.cate = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.DownBack = null;
            this.account.Icon = null;
            this.account.IconIsButton = false;
            this.account.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.account.IsPasswordChat = '\0';
            this.account.IsSystemPasswordChar = false;
            this.account.Lines = new string[0];
            this.account.Location = new System.Drawing.Point(225, 169);
            this.account.Margin = new System.Windows.Forms.Padding(0);
            this.account.MaxLength = 32767;
            this.account.MinimumSize = new System.Drawing.Size(28, 28);
            this.account.MouseBack = null;
            this.account.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.account.Multiline = false;
            this.account.Name = "account";
            this.account.NormlBack = null;
            this.account.Padding = new System.Windows.Forms.Padding(5);
            this.account.ReadOnly = false;
            this.account.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.account.Size = new System.Drawing.Size(309, 28);
            // 
            // 
            // 
            this.account.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.account.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.account.SkinTxt.Name = "BaseText";
            this.account.SkinTxt.Size = new System.Drawing.Size(299, 22);
            this.account.SkinTxt.TabIndex = 0;
            this.account.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.account.SkinTxt.WaterText = "";
            this.account.TabIndex = 0;
            this.account.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.account.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.account.WaterText = "";
            this.account.WordWrap = true;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.DownBack = null;
            this.password.Icon = null;
            this.password.IconIsButton = false;
            this.password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.password.IsPasswordChat = '\0';
            this.password.IsSystemPasswordChar = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(225, 230);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.MaxLength = 32767;
            this.password.MinimumSize = new System.Drawing.Size(28, 28);
            this.password.MouseBack = null;
            this.password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.NormlBack = null;
            this.password.Padding = new System.Windows.Forms.Padding(5);
            this.password.ReadOnly = false;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.Size = new System.Drawing.Size(309, 28);
            // 
            // 
            // 
            this.password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.password.SkinTxt.Name = "BaseText";
            this.password.SkinTxt.Size = new System.Drawing.Size(299, 22);
            this.password.SkinTxt.TabIndex = 0;
            this.password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.password.SkinTxt.WaterText = "";
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.password.WaterText = "";
            this.password.WordWrap = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.login.DownBack = null;
            this.login.Location = new System.Drawing.Point(271, 317);
            this.login.MouseBack = null;
            this.login.Name = "login";
            this.login.NormlBack = null;
            this.login.Size = new System.Drawing.Size(215, 62);
            this.login.TabIndex = 2;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Location = new System.Drawing.Point(341, 285);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(67, 15);
            this.register.TabIndex = 3;
            this.register.Text = "点击注册";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // cate
            // 
            this.cate.BackColor = System.Drawing.Color.Transparent;
            this.cate.DownBack = null;
            this.cate.Icon = null;
            this.cate.IconIsButton = false;
            this.cate.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.cate.IsPasswordChat = '\0';
            this.cate.IsSystemPasswordChar = false;
            this.cate.Lines = new string[0];
            this.cate.Location = new System.Drawing.Point(225, 110);
            this.cate.Margin = new System.Windows.Forms.Padding(0);
            this.cate.MaxLength = 32767;
            this.cate.MinimumSize = new System.Drawing.Size(28, 28);
            this.cate.MouseBack = null;
            this.cate.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.cate.Multiline = false;
            this.cate.Name = "cate";
            this.cate.NormlBack = null;
            this.cate.Padding = new System.Windows.Forms.Padding(5);
            this.cate.ReadOnly = false;
            this.cate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cate.Size = new System.Drawing.Size(309, 28);
            // 
            // 
            // 
            this.cate.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cate.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cate.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.cate.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.cate.SkinTxt.Name = "BaseText";
            this.cate.SkinTxt.Size = new System.Drawing.Size(299, 22);
            this.cate.SkinTxt.TabIndex = 0;
            this.cate.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cate.SkinTxt.WaterText = "";
            this.cate.TabIndex = 4;
            this.cate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cate.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cate.WaterText = "";
            this.cate.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(174, 118);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(39, 20);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "类别";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(174, 238);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(39, 20);
            this.skinLabel2.TabIndex = 6;
            this.skinLabel2.Text = "密码";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(174, 177);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(39, 20);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "账号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 506);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Name = "Form1";
            this.Text = "IM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox account;
        private CCWin.SkinControl.SkinTextBox password;
        private CCWin.SkinControl.SkinButton login;
        private System.Windows.Forms.Label register;
        private CCWin.SkinControl.SkinTextBox cate;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}

