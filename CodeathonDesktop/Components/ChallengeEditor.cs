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

using DevExpress.XtraEditors;

namespace Codeathon.Desktop.Components
{
  
    public partial class ChallengeEditor : UserControl
    {

        public class TestcaseEntity
        {
            public int Id { get; set; }
            public string Input { get; set; }
            public string ExpectedOutput { get; set; }
            public decimal Timeout { get; set; }
            public bool IsPublic { get; set; }
        }

        List<TestcaseEntity> datasource;
        List<Category> categories;
        List<Challenge> challenges;
        Category selectedCategory;
        Challenge selectedChallenge;
        DataTable dataTable;

        public ChallengeEditor()
        {
            InitializeComponent();

            datasource = new List<TestcaseEntity>();
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Input");
            dataTable.Columns.Add("ExpectedOutput");
            dataTable.Columns.Add("Timeout");
            dataTable.Columns.Add("IsPublic");
            gridControl1.DataSource = dataTable;

            comboChallengeId.Properties.Items.Add("CREATE NEW CHALLENGE");
            challenges = Service<ChallengeService>.Use().GetOwnChallenges();
            challenges.ForEach((challenge) =>
            {
                comboChallengeId.Properties.Items.Add(challenge.Name);
            });

            comboChallengeId.SelectedIndexChanged += ComboChallengeId_SelectedIndexChanged;
            comboChallengeId.SelectedIndex = 0;
            categories = Service<CategoryService>.Use().GetCategories();
            categories.ForEach((category) =>
            {
                comboCategory.Properties.Items.Add(category.Name);
            });

            comboCategory.SelectedIndexChanged += ComboCategory_SelectedIndexChanged;
            comboCategory.SelectedIndex = 0;
            
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = categories[comboCategory.SelectedIndex];
        }

        private void ComboChallengeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChallengeId.SelectedIndex != 0)
            {
                selectedChallenge = challenges[comboChallengeId.SelectedIndex-1];
            }
            else
            {
                selectedChallenge = new Challenge();
            }
            LoadTestCases();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            //Service<ChallengeService>.Use().Create(textName.Text,textTitle.Text,textShortDescription.Text,textDescription.Text,selectedCategory)
        }

        private void LoadTestCases()
        {
            dataTable.Rows.Clear();
            if (selectedChallenge != null)
            {
                selectedChallenge.TestCases.ToList().ForEach((testcase) =>
                {
                    dataTable.Rows.Add(testcase);
                });
            }
        }
    }
}
