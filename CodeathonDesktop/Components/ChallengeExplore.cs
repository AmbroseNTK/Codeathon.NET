using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Codeathon.DataModel;

namespace Codeathon.Desktop.Components
{
    public delegate void SelectChallengeHandler(Challenge selected);
    public partial class ChallengeExplore : UserControl
    {
        public event SelectChallengeHandler OnSelectedChallenge;
        public class ChallengeEntity
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string ShortDescription { get; set; }
            public string Category { get; set; }
            public DateTime LastUpdate { get; set; }
            public string Author { get; set; }
        }
        private List<Challenge> challenges;
        private List<ChallengeEntity> dataset;
        public ChallengeExplore()
        {
            InitializeComponent();
        }

        public List<Challenge> Dataset {
            set
            {
                challenges = value;
                dataset = new List<ChallengeEntity>();
                if (challenges != null)
                {
                    challenges.ForEach((challenge) =>
                    {
                        dataset.Add(new ChallengeEntity()
                        {
                            Id = challenge.Id.ToString(),
                            Name = challenge.Name,
                            Title = challenge.Title,
                            ShortDescription = challenge.ShortDescription,
                            Category = challenge.Category.Name,
                            LastUpdate = challenge.LastUpdate,
                            Author = challenge.Owner.Profile.Username
                        });
                    });
                }

                gridControl1.DataSource = dataset;
                gridControl1.RefreshDataSource();
            }
        }
        private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            OnSelectedChallenge?.Invoke(challenges[e.FocusedRowHandle]);
        }
    }
}
