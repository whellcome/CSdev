using NodaTime;

namespace NutritionCalculator.Models
{
    internal class User
    {
        public string Name { get; set; }
        public LocalDate BirthDate { get; set; }
        public InsulinPlan InsulinPlan { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool UnitSystemMgdL { get; set; }
        public bool GlutenFree { get; set; }
        public bool CalculateCalories { get; set; }

    }
}