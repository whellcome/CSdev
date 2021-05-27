
namespace StDietmar.InsulinCalculator.DbStructure
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DefaultAmount { get; set; }
        public int RoastProcent { get; set; }
    }
}
