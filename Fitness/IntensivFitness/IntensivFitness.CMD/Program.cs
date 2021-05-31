using IntensivFitness.BL.Controller;
using System;

namespace IntensivFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application IntensiveFitness");
            var userController = new UserController();
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }
        
    }
}
