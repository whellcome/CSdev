

using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class InsulinPlan : List<InsulinPlanItem>
    {
        private User user { get; }
        public string Name { get; set; }
    }
}
