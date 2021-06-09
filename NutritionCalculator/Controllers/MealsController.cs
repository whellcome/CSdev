using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    public class MealsController : DataController
    {
        public User CurrentUser { get; set; }
        public List<Meal> Meals { get; set; }
        public Meal CurrentMeal { get; set; }
        public MealsController()
        {
            CurrentUser = NCData.CurrentUser ?? throw new ArgumentNullException(typeof(User).ToString());
            Meals = GetMealsData();
            CurrentMeal = new Meal
            {
                MealItems = new List<MealItem>
                {
                    SetNewItem()
                }
            };
        }

        public void SetNew()
        {
            CurrentMeal.Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;
        }

        public MealItem SetNewItem(Nutrient nutrient, double amount)
        {
            return new MealItem(nutrient, amount);
        }
        public MealItem SetNewItem()
        {
            return new MealItem();
        }
        public double GetCarbohydrates()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetCarbohydrates(item.Amount);
            return result;
        }
        public double GetCalories()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetCalories(item.Amount);
            return result;
        }
        private List<Meal> GetMealsData()
        {
            return Load<Meal>();
        }

        public void Save()
        {
            Save(Meals);
        }
    }
}
