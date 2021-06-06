using NutritionCalculator.Models;
using System;


namespace NutritionCalculator
{
    internal static class NCData
    {
        public static User CurrentUser { get; internal set; }
        public delegate void DataSaved(string data);
        public static DataSaved EventHandler;
    }
}
