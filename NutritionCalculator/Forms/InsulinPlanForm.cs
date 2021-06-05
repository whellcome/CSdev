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
    public partial class InsulinPlanForm : Form
    {
        private InsulinPlanController InsulinPlanController { get; set; }
        public InsulinPlanForm()
        {
            InitializeComponent();
        }

        private void InsulinPlanForm_Load(object sender, EventArgs e)
        {
            InsulinPlanController = new InsulinPlanController();
            dgvInsulinPlan.DataSource = InsulinPlanController.CurrentInsulinPlan;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            InsulinPlanController.SetNew(tbName.Text, InsulinPlanController.CurrentInsulinPlan);
        }
    }
}
