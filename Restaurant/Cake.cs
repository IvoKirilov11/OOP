using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal DeafultPrice = 5;
        private const double DeafultGrams = 250;
        private const double DeafultCalories = 1000;


        public Cake(string name) 
            : base(name, DeafultPrice, DeafultGrams, DeafultCalories)
        {
        }
    }
}
