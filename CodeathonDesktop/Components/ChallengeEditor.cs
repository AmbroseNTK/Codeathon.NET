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
            public string Id { get; set; }
            public string Input { get; set; }
            public string ExpectedOutput { get; set; }
            public int Timeout { get; set; }
            public bool AllowView { get; set; }
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
            dataTable.Columns.Add("AllowView");
            gridControl1.DataSource = dataTable;

            LoadChallenges();

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
            try
            {
                selectedCategory = categories[comboCategory.SelectedIndex];
            }
            catch
            {
                selectedCategory = categories[0];
            }
        }

        private void ComboChallengeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChallengeId.SelectedIndex != 0)
            {
                try
                {
                    selectedChallenge = challenges[comboChallengeId.SelectedIndex - 1];
                }
                catch
                {
                    selectedChallenge = new Challenge();
                }
                textName.Text = selectedChallenge.Name;
                textTitle.Text = selectedChallenge.Title;
                textShortDescription.Text = selectedChallenge.ShortDescription;
                textDescription.Text = selectedChallenge.Description;
                try
                {
                    comboCategory.SelectedIndex = comboCategory.Properties.Items.IndexOf(selectedChallenge.Category.Name);
                }
                catch
                {
                    comboCategory.SelectedIndex = 0;
                }
                btUpdate.Enabled = true;
                btDelete.Enabled = true;
                btCreate.Enabled = false;

            }
            else
            {
                selectedChallenge = new Challenge();

                textName.Text = "";
                textTitle.Text = "";
                textShortDescription.Text = "";
                textDescription.Text = "";
                comboCategory.SelectedIndex = 0;
                btCreate.Enabled = true;
                btUpdate.Enabled = false;
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
            List<TestCase> testcases = new List<TestCase>();
            foreach(DataRow row in dataTable.Rows)
            {
                if (row.ItemArray[0].ToString() == "")
                {
                    testcases.Add(new TestCase()
                    {
                        Input = row.ItemArray[1].ToString(),
                        ExpectedOutput = row.ItemArray[2].ToString(),
                        Timeout = int.Parse(row.ItemArray[3].ToString()),
                        AllowView = true
                    });
                }
            }
            Service<ChallengeService>.Use().Create(
                textName.Text,
                textTitle.Text,
                textShortDescription.Text,
                textDescription.Text,
                selectedCategory,
                testcases,
                checkIsPublic.Checked
                );
            LoadChallenges();
        }

        private void LoadTestCases()
        {
            dataTable.Rows.Clear();
            if (selectedChallenge != null)
            {
                selectedChallenge.TestCases.ToList().ForEach((testcase) =>
                {

                    dataTable.Rows.Add(new object[] { testcase.Id, testcase.Input, testcase.ExpectedOutput,testcase.Timeout, testcase.AllowView });
                });
            }
        }

        private void LoadChallenges()
        {
            comboChallengeId.Properties.Items.Clear();
            comboChallengeId.Properties.Items.Add("CREATE NEW CHALLENGE");
            challenges = Service<ChallengeService>.Use().GetOwnChallenges();
       
            challenges.ForEach((challenge) =>
            {
                comboChallengeId.Properties.Items.Add(challenge.Name);
            });

            challengeExplore1.Dataset = challenges;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (selectedChallenge != null)
            {
                selectedChallenge.Title = textTitle.Text;
                selectedChallenge.ShortDescription = textShortDescription.Text;
                selectedChallenge.Description = textDescription.Text;
                selectedChallenge.Category = selectedCategory;
                Service<ChallengeService>.Use().Update(selectedChallenge);
     
            }
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.ItemArray[0].ToString() != "")
                {
                    TestCase testCase = Service<TestcaseService>.Use().Read((test) => test.Id == int.Parse(row.ItemArray[0].ToString())).FirstOrDefault();
                    if (testCase != null)
                    {
                        testCase.Input = row.ItemArray[1].ToString();
                        testCase.ExpectedOutput = row.ItemArray[2].ToString();
                        testCase.Timeout = int.Parse(row.ItemArray[3].ToString());
                        Service<TestcaseService>.Use().Update(int.Parse(row.ItemArray[0].ToString()), testCase);
                        Service<TestcaseService>.Use().SaveChanges();
                    }

                }
                else
                {
                    selectedChallenge.TestCases.Add(new TestCase()
                    {
                        Input = row.ItemArray[1].ToString(),
                        ExpectedOutput = row.ItemArray[2].ToString(),
                        Timeout = int.Parse(row.ItemArray[3].ToString()),
                        AllowView = true
                    });
                    Service<TestcaseService>.Use().SaveChanges();
                }
            }
            LoadChallenges();
            LoadTestCases();
        }
    }
}
