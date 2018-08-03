﻿using OMCS.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using OMCS.Server;
using OMCS;

namespace 即时通讯v1._0
{
    static class Program
    {
        private static IMultimediaServer MultimediaServer;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 f1 = new Form1();
                if (f1.ShowDialog() != DialogResult.OK)//f1的button点击确定后值为ok，所以返回
                {
                    return;
                }

                GlobalUtil.SetAuthorizedUser(ConfigurationManager.AppSettings["AuthorizedUser"], ConfigurationManager.AppSettings["AuthorizedPassword"]);
                GlobalUtil.SetMaxLengthOfUserID(byte.Parse(ConfigurationManager.AppSettings["MaxLengthOfUserID"]));
                OMCSConfiguration config = new OMCSConfiguration();
                //用于验证登录用户的帐密
                DefaultUserVerifier userVerifier = new DefaultUserVerifier();
                Program.MultimediaServer = MultimediaServerFactory.CreateMultimediaServer(int.Parse(ConfigurationManager.AppSettings["Port"]), userVerifier, config, bool.Parse(ConfigurationManager.AppSettings["SecurityLogEnabled"]));
                sever se = new sever(Program.MultimediaServer);
              /*  if (se.ShowDialog() != DialogResult.OK)
                { return;
                }*/

                IMultimediaManager multimediaManager = MultimediaManagerFactory.GetSingleton();
                multimediaManager.Advanced.AllowDiscardFrameWhenBroadcast = false; //正式部署使用时，建议设置为true。
                multimediaManager.CameraVideoSize = new System.Drawing.Size(320, 240);
                multimediaManager.AutoAdjustCameraEncodeQuality = true;
                multimediaManager.ChannelMode = ChannelMode.P2PDisabled;
                multimediaManager.SecurityLogEnabled = false;
                multimediaManager.CameraDeviceIndex = 0;
                multimediaManager.MicrophoneDeviceIndex = int.Parse(ConfigurationManager.AppSettings["MicrophoneIndex"]);
                multimediaManager.SpeakerIndex = int.Parse(ConfigurationManager.AppSettings["SpeakerIndex"]);
                multimediaManager.DesktopEncodeQuality = 3;
                multimediaManager.Initialize(f1.Bccount, "", ConfigurationManager.AppSettings["ServerIP"], int.Parse(ConfigurationManager.AppSettings["ServerPort"]));
                //  MainForm mainForm = new MainForm(multimediaManager, loginForm.RoomID);
                Form3 f3 = new Form3(multimediaManager, f1.RoomID);
                Application.Run(f3);
            }
            catch (Exception ee)
            { MessageBox.Show(ee.Message); }
        }
    }
}
