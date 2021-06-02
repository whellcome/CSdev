using NodaTime;

namespace NutritionCalculator.Models
{
    public class InsulinPlanItem
    {
        private User user { get; }
        public string Name { get; set; }
        public LocalTime LocalTimeBegin { get; set; }
        public LocalTime LocalTimeEnd { get; set; }
        public double EatFactor { get; set; }
        public double GlucoseLevelTarget { get; set; }
        public double TargetFactor { get; set; }
    }
}
