﻿using NodaTime;
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
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            var userController = new UserController();
            if (userController.Users.Count > 0)
            {
                foreach (var user in userController.Users)
                {
                    var row = new string[] { user.Name, user.BirthDate.ToString() };
                    _ = new ListViewItem(row)
                    {
                        Tag = user
                    };
                }
            }
            else
            {
                MessageBox.Show("Users list is epty, create a new user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserForm userForm = new UserForm();
                userForm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }
    }
}
