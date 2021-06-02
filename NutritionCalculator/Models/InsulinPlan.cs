

using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    class InsulinPlan : List<InsulinPlanItem>
    {
        private User user { get; }
        public string Name { get; set; }
    }
}
