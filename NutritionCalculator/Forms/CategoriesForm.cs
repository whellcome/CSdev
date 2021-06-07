using NutritionCalculator.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class CategoriesForm : Form
    {
        private CategoriesController CategoriesController = new CategoriesController();
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            CategoriesController.Categories.Add(CategoriesController.SetNewItem());
            dgvCategories.DataSource = CategoriesController.Categories;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var list = categoriesBindingSource.List;
            CategoriesController.Categories.Clear();
            foreach (var item in list)
            {
                CategoriesController.Categories.Add((Models.Category)item);

                CategoriesController.Save();
            }

        }
        private void dgvCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var list = categoriesBindingSource.List;
            if (dgvCategories.CurrentRow != null && dgvCategories.CurrentRow.Index == CategoriesController.Categories.Count-1)
            {
                CategoriesController.Categories.Add(CategoriesController.SetNewItem());
                dgvCategories.DataSource = null;
                dgvCategories.DataSource = CategoriesController.Categories;
            }
        }
    }
}

