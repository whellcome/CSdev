using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    public class FoodController : DataController
    {
        public List<Food> Foods { get; }
        
        public FoodController()
        {
            Foods = GetFoodsData();
        }

        private List<Food> GetFoodsData()
        {
            return Load<Food>();
        }

        public void Save()
        {
            Save(Foods);
        }
    }
}
