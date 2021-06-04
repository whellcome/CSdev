﻿using NodaTime;
using System;

namespace NutritionCalculator.Models
{
    public class User
    {
        #region Properties
        public string Name { get; set; }
        public LocalDate BirthDate { get; set; }
        public InsulinPlan InsulinPlan { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool UnitSystemMgdL { get; set; }
        public bool GlutenFree { get; set; }
        public bool CalculateCalories { get; set; }
        #endregion
        public User(string name, LocalDate birthDate, double weight, double height, bool unitSystemMgdL, bool glutenFree, bool calculateCalories)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            UnitSystemMgdL = unitSystemMgdL;
            GlutenFree = glutenFree;
            CalculateCalories = calculateCalories;
        }

        public User()
        {
        }
    }
}