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
            CurrentUser = NCData.CurrentUser ?? Users.FirstOrDefault();
            NCData.EventHandler = new NCData.DataSaved(eventDataSaved);
        }

        private void eventDataSaved(string data)
        {
            if (data.Contains(typeof(InsulinPlan).Name))
            {
                Save();
            }
        }

        public void SetNew(string name, LocalDate birthDate, InsulinPlan insulinPlan, double weight, double height, bool unitSystemMgdL, bool glutenFree, bool calculateCalories)
        {
            CurrentUser = new User(name, birthDate, insulinPlan, weight, height, unitSystemMgdL, glutenFree, calculateCalories);
            Users.Add(CurrentUser);
            Save();
            NCData.CurrentUser = CurrentUser;
        }

        public void Update(string name, LocalDate birthDate, InsulinPlan insulinPlan, double weight, double height, bool unitSystemMgdL, bool glutenFree, bool calculateCalories)
        {
            var index = Users.FindIndex(u => u.Name == CurrentUser.Name && u.BirthDate == CurrentUser.BirthDate);
            CurrentUser = new User(name, birthDate, insulinPlan, weight, height, unitSystemMgdL, glutenFree, calculateCalories);
            Users[index] = CurrentUser;
            Save();
            NCData.CurrentUser = CurrentUser;
        }

        public List<User> GetUsersData()
        {
            return Load<User>();
        }

        public void Save()
        {
            Save(Users);
            NCData.CurrentUser = CurrentUser;
        }
    }
}
