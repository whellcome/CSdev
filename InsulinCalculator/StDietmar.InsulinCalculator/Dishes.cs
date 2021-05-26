

namespace StDietmar.InsulinCalculator
{
    public class Dishes
    {
        public string DishName { get; set; }
        public Ingredients Ingredients { get; set; }
        public Dishes(string dishName, Ingredients ingredients = null)
        {
            DishName = dishName;
            if (ingredients == null)
            {
                Products product = new Products(dishName);
                Ingredients = new Ingredients(product, product.DefaultAmount);
            }
            else
            {
                Ingredients = ingredients;
            }
            
            
        }
    }
}
