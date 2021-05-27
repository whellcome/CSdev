using StDietmar.InsulinCalculator.DbStructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StDietmar.InsulinCalculator
{
    using DP = Calculator.DayPart;
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ICDbContext())
            {
                if (!context.Products.Any(x => x.Id == 1)) //Initiate, when not exist
                {
                    var prod = new Product()
                    {
                        Name = "Apple",
                        Art = "Green",
                        Carbohydrates = 90,
                        GlycemicIndex = 35,
                        DefaultAmount = 100
                    };


                    var dish = new Dish()
                    {
                        Name = "Half an apple ",
                        DefaultAmount = 50,
                        RoastProcent = 100
                    };

                    context.Products.Add(prod);
                    context.Dishes.Add(dish);
                    context.SaveChanges();


                    var ingredients = new List<Ingredient>()
                    {
                        new Ingredient() { ProductId = prod.Id, DishId = dish.Id, Amount = 50 },
                        new Ingredient() { ProductId = prod.Id, DishId = dish.Id, Amount = 50}
                    };
                    context.Ingredients.AddRange(ingredients);
                    context.SaveChanges();
                }

            }

            Calculator insulinPlan = new Calculator();
            insulinPlan.FactorPlan[(int)DP.Night_0_3] = 0.5;
            insulinPlan.FactorPlan[(int)DP.Night_3_6] = 0.5;
            insulinPlan.FactorPlan[(int)DP.Morning_6_9] = 0.8;
            insulinPlan.FactorPlan[(int)DP.Morning_9_12] = 0.8;
            insulinPlan.FactorPlan[(int)DP.Day_12_3] = 0.7;
            insulinPlan.FactorPlan[(int)DP.Day_3_6] = 0.6;
            insulinPlan.FactorPlan[(int)DP.Evening_6_9] = 0.5;
            insulinPlan.FactorPlan[(int)DP.Evening_9_12] = 0.5;

            Person p = new Person("Andreas", "Steinle", insulinPlan);

            Console.WriteLine($"Inslin factorplan for {p.FullName}: {String.Join(", ", insulinPlan.FactorPlan)}");
            double carb = EnterNumber("Enter the amount of carbohydrates: ");
            Console.WriteLine($"For {carb}g. carbohydrates, {p.FirstName} needs to supply {insulinPlan.GetInsulinAmount(carb, DateTime.Now)} unit of insulin");

            Console.ReadLine();
        }
        public static double EnterNumber(string str)
        {
            double result;
            var i = 0;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                i++;
                Console.Write(str);
            }
            while (!double.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
