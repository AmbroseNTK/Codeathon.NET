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
using Codeathon.DataModel;
using DevExpress.XtraEditors;

namespace Codeathon.Desktop.Components
{
    public partial class ChallengeCoding : UserControl
    {

        public ChallengeCoding()
        {
            InitializeComponent();
            Service<PLanguageService>.Use().Read().ToList().ForEach((language) =>
            {
                comboLanguage.Items.Add(language.Name);
            });
            comboLanguage.SelectedIndexChanged += ComboLanguage_SelectedIndexChanged;
        }

        private void ComboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBoxEdit = (sender as ComboBoxEdit);

            selectedLanguageId = comboBoxEdit.SelectedIndex;
        }

        int selectedLanguageId = 0;
        Challenge challenge;

        public Challenge SelectedChallenge { set {

                challenge = value;
                lbName.Text = challenge.Name;
                lbTitle.Text = challenge.Title;
                lbAuthor.Text = challenge.Owner.Email;
                lbLastUpdate.Text = challenge.LastUpdate.ToShortDateString();
                tbDescription.Text = challenge.Description;
                
            }
        }

        private void btRun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Service<ChallengeService>.Use().SubmitSolution(challenge,selectedLanguageId, tbCode.Text,(execTime)=> {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Challenge Completed in " + execTime + "s"
                });
            },
            (message)=> {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Error: "+message
                });
            });
        }
    }
}
