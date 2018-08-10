using CCWin;
using ESBasic;
using OMCS.Passive;
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

namespace 即时通讯v1._0
{
    public partial class MainForm :Form
    {
        private IMultimediaManager multimediaManager;//初始化多媒体管理器（接口声明）   
        
        public MainForm(IMultimediaManager mgr, string chatRoomID)
        {
            InitializeComponent();

            this.multimediaManager = mgr;
            this.Text = this.Text + " - " + chatRoomID;
        //    this.skinLabel_userID.Text = this.multimediaManager.CurrentUserID;
            this.multiVideoChatContainer1.Initialize(this.multimediaManager, chatRoomID);
        }     
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.multiVideoChatContainer1.Close();
            this.multimediaManager.Dispose();
        }
       
    }
}
