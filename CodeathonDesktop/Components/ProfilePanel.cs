﻿using System;
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
using Codeathon.API.Interfaces;
using Codeathon.API.Services;
using Codeathon.API.Utilities;

using Codeathon.DataModel;

namespace Codeathon.Desktop.Components
{
    public partial class ProfilePanel : UserControl
    {
        public ProfilePanel()
        {
            InitializeComponent();
            GetOwnChallenge();

            Reports.UserProfileReport profileReport = new Reports.UserProfileReport();
            profileReport.Parameters[0].Value = Service<AuthData>.Use().Get().Email;
            documentViewer1.DocumentSource = profileReport;

        }

        public void GetOwnChallenge()
        {
           
            challengeExplore1.Dataset = Service<AuthData>.Use().Get().Challenges.ToList();
        }

    }
}
