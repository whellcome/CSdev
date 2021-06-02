
using NodaTime;
using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class Meal : List<MealItem>
    {
        private User user { get; set; }
        public string Name { get; set; }
        public LocalDateTime LocalDateTime { get; set; }
    }
}
