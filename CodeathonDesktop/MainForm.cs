using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Codeathon;
using Codeathon.Desktop;
using Codeathon.API;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

using DevExpress.XtraEditors;

namespace Codeathon.Desktop
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ImageList imageList = new ImageList();
       

        public MainForm()
        {
            InitializeComponent();
            Service<Notificator>.Use().OnPushNotification += MainForm_OnPushNotification;
            Service<AuthData>.Use().OnAuthenticated += MainForm_OnAuthenticated;

            imageList.ImageSize = new Size(25, 25);
        
        }

        private void MainForm_OnAuthenticated(User auth)
        {
            
            imageList.Images.Add("avatar", auth.Profile.Avatar.MakeImage());
            barAuthButton.ImageOptions.Image = imageList.Images["avatar"];
            
            barAuthButton.Caption = auth.Profile.Username;
        }

        private void MainForm_OnPushNotification(Notification notification)
        {
            XtraMessageBox.Show(notification.Info,notification.Status.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);
            Service<Notificator>.Use().Discard();
        }

        private void btMenuProfile_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Components.ProfilePanel() { Dock = DockStyle.Fill });
        }

        private void btMenuChallenge_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Components.ChallengeEditor() { Dock = DockStyle.Fill });
        }
    }
}
