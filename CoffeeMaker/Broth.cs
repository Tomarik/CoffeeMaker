using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    class Broth : Order
    {
        public Broth(decimal payment)
        {
            Price = 0.25M;
            Beverage = Beverage.Broth;
            Change = payment - Price;
        }
    }
}
