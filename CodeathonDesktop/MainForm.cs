using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Codeathon.API;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace CodeathonDesktop
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ImageList imageList = new ImageList();
       

        public MainForm()
        {
            InitializeComponent();
            Service<Notificator>.Use().OnPushNotification += MainForm_OnPushNotification;
            Service<AuthData>.Use().OnAuthenticated += MainForm_OnAuthenticated;

            imageList.ImageSize = new Size(30, 30);
        }

        private void MainForm_OnAuthenticated(User auth)
        {
            
            imageList.Images.Add("avatar", auth.Profile.Avatar.MakeImage());
            barAuthButton.ImageOptions.Image = imageList.Images["avatar"];
            
            barAuthButton.Caption = auth.Profile.Username;
        }

        private void MainForm_OnPushNotification(Notification notification)
        {
            MessageBox.Show(notification.Info);
            Service<Notificator>.Use().Discard();
        }
    }
}
