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
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var userController = new UserController();
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

        }

        private void btCreateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
