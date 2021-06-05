using NodaTime;
using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public User CurrentUser { get; set; }
        
        public UserController()
        {
            Users = GetUsersData();
            CurrentUser = NutritionCalculatorData.CurrentUser ?? Users.FirstOrDefault();
        }

        public void SetNew(string name, LocalDate birthDate, double weight, double height, bool unitSystemMgdL, bool glutenFree, bool calculateCalories)
        {
            CurrentUser = new User(name, birthDate, weight, height, unitSystemMgdL, glutenFree, calculateCalories);
            Users.Add(CurrentUser);
            Save();
            NutritionCalculatorData.CurrentUser = CurrentUser;
        }

        public void Update(string name, LocalDate birthDate, double weight, double height, bool unitSystemMgdL, bool glutenFree, bool calculateCalories)
        {
            var index = Users.FindIndex(u => u.Name == CurrentUser.Name && u.BirthDate == CurrentUser.BirthDate);
            CurrentUser = new User(name, birthDate, weight, height, unitSystemMgdL, glutenFree, calculateCalories);
            Users[index] = CurrentUser;
            Save();
            NutritionCalculatorData.CurrentUser = CurrentUser;
        }

        public List<User> GetUsersData()
        {
            return Load<User>();
        }

        public void Save()
        {
            Save(Users);
            NutritionCalculatorData.CurrentUser = CurrentUser;
        }
    }
}
