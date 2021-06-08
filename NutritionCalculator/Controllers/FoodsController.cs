using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    public class FoodsController : DataController
    {
        public List<Food> Foods { get; }
        public Food CurrentFood { get; set; }
        public FoodsController()
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

        public void SaveOrNew(Category category, string name, string art, string description,
                                        string carbohydrates, string proteins, string fats, string calories, 
                                        string glycemicIndex)
        {
            if(string.IsNullOrWhiteSpace(name))  throw new ArgumentNullException(nameof(name));
            Food food = new Food
            {
                Name = name,
                Kind = art,
                Categorie = category,
                Description = description,
                Carbohydrates = double.Parse(carbohydrates),
                Proteins = double.Parse(proteins),
                Fats = double.Parse(fats),
                Calories = double.Parse(calories),
                GlycemicIndex = double.Parse(glycemicIndex)
            };
            if (Foods.SingleOrDefault(f => f.Name == name && f.Kind == art) != null)
            {
                var index = Foods.FindIndex(f => f.Name == name && f.Kind == art); //TODO: overwrite warning 
                Foods[index] = food;
            }
            else
            {
                Foods.Add(food);
            }
            Save();
        }
    }
}
