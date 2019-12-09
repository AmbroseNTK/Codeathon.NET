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
    public partial class CategoryEditor : UserControl
    {

        public class CategoryEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int NumOfChallenge { get; set; }
        }

        Category selectedCategory;
        List<CategoryEntity> categories = new List<CategoryEntity>();
        public CategoryEditor()
        {
            InitializeComponent();
            LoadCategoryData();
            xtraOpenFileDialog1.Title = "Open cover image";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        private void btCreateCat_Click(object sender, EventArgs e)
        {
            
            Service<CategoryService>.Use().Add(new Category()
            {
                Name = textNameCat.Text,
                Description = textDescriptionCat.Text,
                CoverImage = xtraOpenFileDialog1.FileName.ImagePathToBase64()
            });
            xtraOpenFileDialog1.FileName = "";
            LoadCategoryData();
        }

        private void btOpenCoverCat_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picCoverCat.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
        }

        public void LoadCategoryData()
        {
            try
            {
                categories = new List<CategoryEntity>();
                Service<CategoryService>.Use().GetOwnCategory().ForEach((category) =>
                {
                    categories.Add(new CategoryEntity()
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Description = category.Description,
                        NumOfChallenge = category.Challenges.Count
                    });
                });
                gridCat.DataSource = categories;
            }
            catch { }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int id = categories[gridView1.FocusedRowHandle].Id;
            selectedCategory = Service<CategoryService>.Use().GetCategoryById(id);
            LoadCategoryToEditor();
        }

        public void LoadCategoryToEditor()
        {
            if (selectedCategory != null)
            {
                textNameCat.Text = selectedCategory.Name;
                textDescriptionCat.Text = selectedCategory.Description;
                picCoverCat.Image = selectedCategory.CoverImage.MakeImage();
            }
        }

        private void btUpdateCat_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textNameCat.Text;
            selectedCategory.Description = textDescriptionCat.Text;
            if (xtraOpenFileDialog1.FileName != "")
            {
                selectedCategory.CoverImage = xtraOpenFileDialog1.FileName.ImagePathToBase64();
            }
            Service<CategoryService>.Use().Update(selectedCategory);
            LoadCategoryData();
        }

        private void btDeleteCat_Click(object sender, EventArgs e)
        {
            Service<CategoryService>.Use().Delete(selectedCategory);
            LoadCategoryToEditor();
            LoadCategoryData();
        }
    }
}
