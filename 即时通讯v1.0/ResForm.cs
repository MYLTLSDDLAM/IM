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
using CCWin;

namespace 即时通讯v1._0
{
    public partial class ResForm : CCSkinMain
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filepath);
        private string IniFilePath;
        public ResForm()
        {
            InitializeComponent();
            IniFilePath = Application.StartupPath + "\\Config.ini";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void res_Click(object sender, EventArgs e)
        {
                    
            if ((resaccount.Text.Trim() != "") && (respass.Text.Trim() != ""))
            {
                string Section = cate.Text.Trim();
              
               WritePrivateProfileString(Section, "account", resaccount.Text.Trim(), IniFilePath);
               WritePrivateProfileString(Section, "password", respass.Text, IniFilePath);
                MessageBox.Show("注册成功");
            }
            this.Close();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            resaccount.Text = "请输入账号";
            respass.Text = "请输入密码";
        }
    }
}

