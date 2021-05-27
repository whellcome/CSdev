using System.Collections;
using System.Collections.Generic;

namespace StDietmar.InsulinCalculator.DbStructure
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Art { get; set; }
        public int Carbohydrates { get; set; }
        public int GlycemicIndex { get; set; }
        public double DefaultAmount { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
