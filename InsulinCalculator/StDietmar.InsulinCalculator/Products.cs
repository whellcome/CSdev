using System;

namespace StDietmar.InsulinCalculator
{
    public class Products
    {
        public string Name { get; set; }
        public string Art { get; set; }
        public int Carbohydrates { get; set; }
        public int GlycemicIndex { get; set; }
        public double DefaultAmount { get; set; }

        public Products(string name, string art = "", int carbs = 0, int glycIndex = 0, double amount = 100.0)
        {
            Name = name;
            Art = art;
            Carbohydrates = carbs;
            GlycemicIndex = glycIndex;
            DefaultAmount = amount;
        }
        public static bool operator == (Products product1, Products product2)
        {
            return String.Equals(product1.Name + product1.Art, product2.Name + product2.Art, StringComparison.OrdinalIgnoreCase);
        }
        public static bool operator !=(Products product1, Products product2)
        {
            return String.Equals(product1.Name + product1.Art, product2.Name + product2.Art, StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Ingredients operator +(Products product1, Products product2)
        {
            var ingredient = new Ingredients(product1, product1.DefaultAmount);
            return ingredient;
        }
    }
}
