using NutritionCalculator.Models;
using System;
using System.Collections.Generic;

namespace NutritionCalculator.Controllers
{
    public class UserController : DataController
    {

        /// <summary>
        /// List of users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Current user
        /// </summary>
        public User CurrentUser { get; }
        
        public UserController()
        {
            Users = GetUsersData();
        }

        public List<User> GetUsersData()
        {
            return Load<User>();
        }

        public void Save()
        {
            Save(Users);
        }
    }
}
