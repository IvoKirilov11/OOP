using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal DefualtPrice = 3.5M;
        private const double DefaultMililiters = 50;
        
        public Coffee(string name, double caffeine) 
            : base(name, DefualtPrice, DefaultMililiters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
