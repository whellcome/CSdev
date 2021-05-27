

namespace StDietmar.InsulinCalculator.DbStructure
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string InsulinPlan { get; set; }
        public bool GlutenFree { get; set; }
    }
}
