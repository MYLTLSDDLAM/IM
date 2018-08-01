using CCWin;
using OMCS.Passive;
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
    public partial class Form3 :Form
    {
        private IMultimediaManager multimediaManager;//初始化多媒体管理器（接口声明）
       
        public Form3(IMultimediaManager mgr, string chatRoomID)
        {
            InitializeComponent();

            this.multimediaManager = mgr;
            this.Text = this.Text + " - " + chatRoomID;
        //    this.skinLabel_userID.Text = this.multimediaManager.CurrentUserID;
            this.multiVideoChatContainer1.Initialize(this.multimediaManager, chatRoomID);
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.multiVideoChatContainer1.Close();
            this.multimediaManager.Dispose();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
