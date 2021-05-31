using System;
using System.Collections.Generic;
using System.Linq;

namespace IntensivFitness.BL.Model
{
    [Serializable]
    public class Eating
    {
        public DateTime Moment { get; }
        public Dictionary<Food,double> Foods { get; set; }
        public User User { get; }

        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Foods = new Dictionary<Food, double>();
            Moment = DateTime.UtcNow;
        }
        public void Add(Food food, double weight)
        {
            var product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));
            if(product == null)
            {
                Foods.Add(food, weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }
    }
}
