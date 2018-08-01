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

namespace 即时通讯v1._0
{
    public partial class Form1 : CCSkinMain

    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private string IniFilePath;
        public string RoomID = "R100";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            account.Text = "请输入账号";
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

          string Account;//临时账号变量
        public string Bccount { get { return Account; } }
        public void login_Click(object sender, EventArgs e)
        {
            IniFilePath = Application.StartupPath + "\\Config.ini";
            string Section = cate.Text.Trim();
            string outString;
          //  string Account;//临时账号变量
             string Password;//临时密码变量        
            GetValue(Section, "account", out outString);//获取账号 
            Account = outString;
            GetValue(Section, "password", out outString);//获取密码
            Password = outString;
            if ((account.Text == Account) && (password.Text == Password))
            {
                MessageBox.Show("登录成功");
                this.Hide();
                /* Form3 f3 = new Form3();
                 f3.Show();*/
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

    }
}
