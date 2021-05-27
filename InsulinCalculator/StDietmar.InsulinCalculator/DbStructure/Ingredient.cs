namespace StDietmar.InsulinCalculator.DbStructure
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DishId { get; set; }
        public double Amount { get; set; }
        public virtual Product Product { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
