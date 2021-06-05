using NutritionCalculator.Models;
using System;


namespace NutritionCalculator
{
    internal static class NutritionCalculatorData
    {
        public static User CurrentUser { get; set; }
        public static InsulinPlan CurrentInsulinPlan { get; internal set; }
    }
}
