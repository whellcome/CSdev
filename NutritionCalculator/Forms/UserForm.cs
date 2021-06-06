using NodaTime;
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
    public partial class UserForm : Form
    {
        private bool editMode { get; }
        public UserForm(bool editMode = false)
        {
            InitializeComponent();
            this.editMode = editMode;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                var currentUser = NutritionCalculatorData.CurrentUser;
                btCreateUser.Text = "Save user's data";
                
                tbUserName.Text = currentUser.Name;
                dtBirthDate.Value = currentUser.BirthDate.ToDateTimeUnspecified();
                var insulinPlanController = new InsulinPlanController();
                //cbInsulinPlan.DataSource = insulinPlanController.UserInsulinPlans;
                foreach (var item in insulinPlanController.UserInsulinPlans)
                {
                    cbInsulinPlan.Items.Add(item);
                }
                cbInsulinPlan.SelectedItem = insulinPlanController.CurrentInsulinPlan;

                tbWeight.Text = currentUser.Weight.ToString();
                tbHeight.Text = currentUser.Height.ToString();
                rbUnitSystem1.Checked = currentUser.UnitSystemMgdL;
                cbGlutenFree.Checked = currentUser.GlutenFree;
                cbCalculateCalories.Checked = currentUser.CalculateCalories;
            }
        }

        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void btAddInsulinPlan_Click(object sender, EventArgs e)
        {
            InsulinPlanForm insulinPlanForm = new InsulinPlanForm();
            insulinPlanForm.Show();
        }

        private void btCreateUser_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            var localDate = LocalDateTime.FromDateTime(dtBirthDate.Value);
            if (editMode)
            {
                userController.Update(tbUserName.Text, localDate.Date, Int32.Parse(tbWeight.Text),
                                      Int32.Parse(tbHeight.Text), rbUnitSystem1.Checked, cbGlutenFree.Checked,
                                      cbCalculateCalories.Checked);
            }
            else
            {
                userController.SetNew(tbUserName.Text, localDate.Date, Int32.Parse(tbWeight.Text),
                                          Int32.Parse(tbHeight.Text), rbUnitSystem1.Checked, cbGlutenFree.Checked,
                                          cbCalculateCalories.Checked);
            }
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
            this.Close();
        }
    }
}
