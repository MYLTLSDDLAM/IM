using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OMCS.Server;
using ESBasic;

namespace 即时通讯v1._0
{
    public partial class LoginForm : CCSkinMain        
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private string IniFilePath;
        public string RoomID = "R100";
        private IMultimediaServer multimediaServer;//服务器声明
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // account.Text = "请输入账号";
          
        }

        private void register_Click(object sender, EventArgs e)
        {
            ResForm f2 = new ResForm();
            f2.Show();
        }

          string Account;//临时账号变量
          string Password;//临时密码变量 
        public string Bccount { get { return Account; } }//自动实现属性
        public string Cccount { get { return Password; } }
        public void login_Click(object sender, EventArgs e)
        {
            try
            {
                IniFilePath = Application.StartupPath + "\\Config.ini";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            string Section = cate.Text.Trim();
            string outString;//临时变量                  
            GetValue(Section, "account", out outString);//获取账号 
            Account = outString;
            GetValue(Section, "password", out outString);//获取密码
            Password = outString;
            if ((account.Text == Account) && (password.Text == Password))
            {
                MessageBox.Show("登录成功");
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("登录出错，请检查账号和密码");
            }
        }
        private void GetValue(string section, string key, out string value)
        {

            StringBuilder stringBuilder = new StringBuilder();
            GetPrivateProfileString(section, key, "", stringBuilder, 1024, IniFilePath);
            value = stringBuilder.ToString();
        }
        private void account_MouseClick(object sender, MouseEventArgs e)
        {
            account.Text = "";
        }
        public void sever2(IMultimediaServer server)
        {
            InitializeComponent();
            //   this.TextChanged += new EventHandler(ServerForm_TextChanged);
            this.multimediaServer = server;
            this.multimediaServer.UserConnected += new CbGeneric<string>(multimediaServer_UserConnected);
            this.multimediaServer.UserDisconnected += new CbGeneric<string>(multimediaServer_UserDisconnected);
            multimediaServer.AgileChannelBusyGuesserEnabled = true;
        }
        void multimediaServer_UserDisconnected(string userID)
        {
            if (this.InvokeRequired)
            { 
                this.BeginInvoke(new CbGeneric<string>(this.multimediaServer_UserDisconnected), userID);
                //主线程结束后在执行这个
            }
         
        }
        void multimediaServer_UserConnected(string userID)
        {
            if (this.InvokeRequired)
            //invokeRequired用于判断是否是控件所在线程调用的，不是的话为true；Invoke用于跨线程调用控件进行操作。
            {
                this.BeginInvoke(new CbGeneric<string>(this.multimediaServer_UserConnected), userID);
                //主线程结束后在执行这个
            }
            else
            {
                //this.label_userCount.Text = this.multimediaServer.UserCount.ToString();
                //this.toolStripLabel_msg.Text = string.Format("{0} 上线。{1}", userID, DateTime.Now.ToString());
            }
        }
        private void Callback(object state)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<object>(this.Callback), state);
            }
            else
            {
              //  this.label_userCount.Text = this.multimediaServer.UserCount.ToString();
            }
        }
    }
}
