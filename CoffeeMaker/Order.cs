using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    public enum Beverage
    {
        Coffee,
        Broth,
            
    };

    class Order
    {
        private decimal price;
        private decimal change;
        private Beverage beverage;
        private bool addin;

        public decimal Price {
            get;
            set;
            }

        public decimal Change
        {
            get;
            set;
        }

        public Beverage Beverage
        {
            get;
            set;
        }

        public bool Addin
        {
            get;
            set;
        }
    }
}
