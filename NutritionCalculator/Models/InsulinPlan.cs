

using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class InsulinPlan : List<InsulinPlanItem>
    {
        public User User { get; }
        public string Name { get; set; }
        public InsulinPlan(User user)
        {
            User = user;
        }
    }
}
