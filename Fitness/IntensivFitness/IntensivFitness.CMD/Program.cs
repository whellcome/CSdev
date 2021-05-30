using IntensivFitness.BL.Controller;
using System;

namespace IntensivFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application IntensiveFitness");
            var name = EnterString("Enter username: ");
            var genderName = EnterString("Enter gender: ");
            var birthday = EnterDateTime("Enter birthday: ");
            var weight = EnterDouble("Enter weight: ");
            var height = EnterDouble("Enter height: ");
            var userController = new UserController(name, genderName, birthday, weight, height);
            userController.Save();
            var user = userController.Load();

            Console.WriteLine(user);
            Console.ReadLine();
        }
        public static string EnterString(string str) //TODO: arrange according to the concept 
        {
            int i = 0;
            string result;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                Console.Write(str);
                i++;
                result = Console.ReadLine();
            }
            while (String.IsNullOrWhiteSpace(result));
            return result;
        }
        public static DateTime EnterDateTime(string str) //TODO: arrange according to the concept
        {
            int i = 0;
            DateTime result;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                Console.Write(str);
                i++;
            }
            while (!DateTime.TryParse(Console.ReadLine(), out result));
            return result;
        }
        public static double EnterDouble(string str) //TODO: arrange according to the concept
        {
            int i = 0;
            double result;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                Console.Write(str);
                i++;
            }
            while (!double.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
