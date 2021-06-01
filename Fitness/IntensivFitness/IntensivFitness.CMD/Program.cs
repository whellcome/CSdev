using IntensivFitness.BL.Controller;
using System;
using System.Globalization;
using System.Resources;

namespace IntensivFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.CurrentCulture; //CreateSpecificCulture("de-de");
            var resourceManager = new ResourceManager("IntensivFitness.CMD.Localisations.Local",typeof(Program).Assembly);
            Console.WriteLine(resourceManager.GetString("welcome",culture));
            var userController = new UserController();
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }
        
    }
}
