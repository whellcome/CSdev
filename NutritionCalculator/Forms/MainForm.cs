using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (NutritionCalculatorData.CurrentUser != null)
            {
                buttonSelectUser.Text = $"User: {NutritionCalculatorData.CurrentUser.Name} " +
                                        $"Change user";
            }
            else
            {
                buttonSelectUser.Text = "Select a user";
            }
            this.Refresh();
        }
    }
}
