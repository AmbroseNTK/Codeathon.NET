using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Codeathon;
using Codeathon.API;
using Codeathon.API.Services;
using Codeathon.API.Utilities;

using Codeathon.DataModel;

namespace Codeathon.Desktop.Components
{
    public partial class ProfileInfo : UserControl
    {
        User authUser;
        public ProfileInfo()
        {
            InitializeComponent();
            authUser = Service<AuthData>.Use().Get();
            if (authUser != null)
            {
                picAvatar.Image = authUser.Profile.Avatar.MakeImage();
                lbUsername.Text = authUser.Profile.Username;
                lbEmail.Text = authUser.Email;
                lbPhone.Text = authUser.Profile.PhoneNumber;
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
