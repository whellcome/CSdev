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
            tbName.Text = InsulinPlanController.CurrentInsulinPlan.Name;
            RefreshGridView();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            InsulinPlanController.SetNew(tbName.Text, InsulinPlanController.CurrentInsulinPlan.Plan);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InsulinPlanController.CurrentInsulinPlan.Plan.Add(InsulinPlanController.SetNewItem());
            RefreshGridView();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var currItem = dgvInsulinPlan.CurrentRow;
            dgvInsulinPlan.Rows.Remove(currItem);
        }
        
        private void RefreshGridView()
        {
            dgvInsulinPlan.DataSource = null;
            dgvInsulinPlan.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "clmTimeBegin", HeaderText = "Time of begin", DataPropertyName = "LocalTimeBegin" },
                new DataGridViewTextBoxColumn() { Name = "clmEatFactor", HeaderText = "Factor for food", DataPropertyName = "EatFactor" },
                new DataGridViewTextBoxColumn() { Name = "clmTarget", HeaderText = "Target of glucose level", DataPropertyName = "GlucoseLevelTarget" },
                new DataGridViewTextBoxColumn() { Name = "clmTargetFactor", HeaderText = "Factor for glucode level target", DataPropertyName = "TargetFactor" }
            );
            dgvInsulinPlan.DataSource = InsulinPlanController.CurrentInsulinPlan.Plan;
        }
    }
}
