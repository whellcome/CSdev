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
    public partial class FoodForm : Form
    {
        private FoodsController foodsController = new FoodsController();
        private CategoriesController categoriesController = new CategoriesController();
        public FoodForm()
        {
            InitializeComponent();
            NCData.DataSelected = new NCData.EventHandler<Form, NCEventArgs>(eventDataSelected);
        }

        private void btSelectCategory_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(false);
            categoriesForm.Show();
        }
        private void eventDataSelected(Form sender, NCEventArgs args)
        {
            int index = Int32.Parse(args.Message);
            categoriesController.CurrentCategory = categoriesController.Categories[index];
            lbCategory.Text = categoriesController.CurrentCategory.Name;
        }
    }
}
