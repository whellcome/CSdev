using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NutritionCalculator.Models
{
    
    public class InsulinPlan
    {
        
        public User User { get; }
        
        public string Name { get; set; }
        public List<InsulinPlanItem> Plan { get; set; }
        public InsulinPlan(User user)
        {
            User = user;
            Plan = new List<InsulinPlanItem>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
