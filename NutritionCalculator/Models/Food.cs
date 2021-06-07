

namespace NutritionCalculator.Models
{
    public class Food : Nutrient
    {

        public string Kind { get; set; }

        public Food()
        {
        }

        public override string ToString()
        {
            return $"{Name} : {Kind}";
        }
    }
}
