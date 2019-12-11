using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Codeathon.API.Services;
using Codeathon.API.Utilities;

namespace Codeathon.Desktop.Components
{
    public partial class LoginPanel : DevExpress.XtraEditors.XtraUserControl
    {
       
        OpenFileDialog ofd;
        string avatar = "";
        public LoginPanel()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            ofd.Title = "Select your avatar";
        }

        private void LabelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
           
               Service<UserService>.Use().Login(tbEmail.Text, tbPassword.Text);  
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            Service<UserService>.Use().Register(tbRegisEmail.Text, tbRegisPassword.Text, tbRetypedPassword.Text, new Codeathon.DataModel.Profile()
            {
                Username = tbUsername.Text,
                PhoneNumber = tbPhoneNumber.Text,
                Avatar = avatar
            });
        }

        private void BtChooseAvatar_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                avatar = ofd.FileName.ImagePathToBase64();
            }
        }
    }
}
