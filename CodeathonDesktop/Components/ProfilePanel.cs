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
        }

        public void GetOwnChallenge()
        {
            List<object> dataset = new List<object>();
            Service<AuthData>.Use().Get().Challenges.ToList().ForEach((challenge) =>
            {
                dataset.Add(new
                {
                    id = challenge.Id,
                    name = challenge.Name,
                    author = challenge.Owner.Profile.Username,
                    description = challenge.ShortDescription
                });
            });
            challengeExplore1.Dataset = dataset.ToArray();
        }

    }
}
