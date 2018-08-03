using OMCS.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESBasic;

namespace 即时通讯v1._0
{
    public partial class sever : Form
    {
        private IMultimediaServer multimediaServer;
        private System.Threading.Timer timer;
        public sever(IMultimediaServer server)
        {
            InitializeComponent();
         //   this.TextChanged += new EventHandler(ServerForm_TextChanged);
            this.multimediaServer = server;
            this.multimediaServer.UserConnected += new CbGeneric<string>(multimediaServer_UserConnected);
            this.multimediaServer.UserDisconnected += new CbGeneric<string>(multimediaServer_UserDisconnected);
            this.label_time.Text = DateTime.Now.ToString();
            this.label_port.Text = this.multimediaServer.Port.ToString();
        }
        void multimediaServer_UserDisconnected(string userID)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string>(this.multimediaServer_UserDisconnected), userID);
            }
            else
            {
                this.label_userCount.Text = this.multimediaServer.UserCount.ToString();
            //    this.toolStripLabel_msg.Text = string.Format("{0} 下线。{1}", userID, DateTime.Now.ToString());
            }
        }
        void multimediaServer_UserConnected(string userID)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string>(this.multimediaServer_UserConnected), userID);
            }
            else
            {
                this.label_userCount.Text = this.multimediaServer.UserCount.ToString();
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
                this.label_userCount.Text = this.multimediaServer.UserCount.ToString();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.multimediaServer.AgileChannelBusyGuesserEnabled = this.checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
