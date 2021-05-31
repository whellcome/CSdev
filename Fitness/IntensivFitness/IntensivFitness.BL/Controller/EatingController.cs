﻿using IntensivFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntensivFitness.BL.Controller
{
    public class EatingController : BaseController
    {
        private readonly User user;
        public List<Food> Foods { get; }
        public Eating Eating { get; }
        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
            Foods = GetAllFoods();
            Eating = GetEating();
        }
        public void Add(Food food, double weight)
        {
            var product = Foods.SingleOrDefault(f => f.Name == food.Name);
            if (product == null)
            {
                Foods.Add(food);
                Eating.Add(food, weight);
                Save();
            }
            else
            {
                Eating.Add(product, weight);
                Save();
            }
        }
        private static List<Food> GetAllFoods()
        {
            return Load<Food>();
        }
        private Eating GetEating()
        {
            return Load<Eating>().FirstOrDefault() ?? new Eating(user);
        }
        private void Save()
        {
            Save(Foods);
            Save(new List<Eating>() { Eating });
        }
    }
}
