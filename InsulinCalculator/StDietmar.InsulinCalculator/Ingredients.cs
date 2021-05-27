using Json.Net;
using System;
using System.Collections.Generic;


namespace StDietmar.InsulinCalculator
{
    public class Ingredients
    {
        public Dictionary<Products, double> Composition;
        public Ingredients(Products product, double amount)
        {
            Composition = new Dictionary<Products, double>() { { product, amount } };
        }
        public static Ingredients operator +(Ingredients ingredient, Products product2)
        {
            try
            {
                ingredient.Composition.Add(product2, product2.DefaultAmount);
            }
            catch (ArgumentException)
            {
                ingredient.Composition[product2] += product2.DefaultAmount;
            }
            return ingredient;
        }
        public static Ingredients operator -(Ingredients ingredient, Products product2)
        {
            
            try
            {
                ingredient.Composition.Remove(product2);
            }
            catch (ArgumentException)
            {
                //ignor
            }
            return ingredient;
        }

        public static Ingredients operator +(Ingredients ingredient, Ingredients ingredient2)
        {
            foreach(Products product in ingredient2.Composition.Keys)
            {
                try
                {
                    ingredient.Composition.Add(product, ingredient2.Composition[product]);
                }
                catch (ArgumentException)
                {
                    ingredient.Composition[product] += ingredient2.Composition[product];
                }
            }
            return ingredient;
        }
        public static Ingredients operator -(Ingredients ingredient, Ingredients ingredient2)
        {

            foreach (Products product in ingredient2.Composition.Keys)
            {
                try
                {
                    ingredient.Composition[product] -= ingredient2.Composition[product];
                    if (ingredient.Composition[product] <= 0.0) ingredient.Composition.Remove(product);
                }
                catch (KeyNotFoundException)
                {
                    //ignor
                }
                
            }
            return ingredient;
        }
        public void SerializeWithJSONNet() //TODO: implement to exchange with the database
        {
            //Ingredients ingredient1 = new Ingredients(new Products("Apple"), 100);
            //var ing = JsonNet.Serialize(ingredient1);
        }

    }

}
