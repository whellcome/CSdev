using NutritionCalculator.Models;
using System;
using System.Collections.Generic;

namespace NutritionCalculator.Controllers
{
    class UserController
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

        private List<User> GetUsersData()
        {
            throw new NotImplementedException();
        }
    }
}
