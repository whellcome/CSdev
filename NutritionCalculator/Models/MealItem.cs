
namespace NutritionCalculator.Models
{
    public class MealItem
    {
        public Nutrient Nutrient { get; set; }
        public double Amount { get; set; }
        public MealItem(Nutrient nutrient, double amount)
        {
            Nutrient = nutrient;
            Amount = amount;
        }

        public MealItem()
        {
        }
    }
}
