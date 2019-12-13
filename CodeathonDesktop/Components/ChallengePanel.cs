using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraTab;

using Codeathon;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace Codeathon.Desktop.Components
{
    public partial class ChallengePanel : UserControl
    {
        public ChallengePanel()
        {
            InitializeComponent();
            xtraTabControl1.CloseButtonClick += (sender, e) =>
            {
                xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.TabIndex);
            };
            challengeExplore1.OnSelectedChallenge += (challenge) =>
            {
                XtraTabPage tabPage = new XtraTabPage();
                tabPage.Text = challenge.Title;
                ChallengeCoding coding = new ChallengeCoding() { Dock = DockStyle.Fill, SelectedChallenge = challenge };
                tabPage.Controls.Add(coding);
                xtraTabControl1.TabPages.Add(tabPage);
            };
        }

        private void ChallengePanel_Load(object sender, EventArgs e)
        {
            challengeExplore1.Dataset = Service<ChallengeService>.Use().GetPublicChallenges();
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
