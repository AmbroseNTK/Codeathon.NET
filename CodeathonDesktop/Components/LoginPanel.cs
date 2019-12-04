﻿using System;
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

namespace CodeathonDesktop.Components
{
    public partial class LoginPanel : DevExpress.XtraEditors.XtraUserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
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
            Service<UserService>.Use().Register(tbRegisEmail.Text, tbRegisPassword.Text, tbRetypedPassword.Text);
        }
    }
}
