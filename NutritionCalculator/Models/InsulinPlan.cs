using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NutritionCalculator.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class InsulinPlan : List<InsulinPlanItem>
    {
        [JsonProperty]
        public User User { get; }
        [JsonProperty]
        public string Name { get; set; }
        public InsulinPlan(User user)
        {
            User = user;
        }
    }
}
