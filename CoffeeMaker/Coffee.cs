using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    class Coffee : Order
    {
        public bool creamer;
        public Coffee(decimal payment, bool creamer)
        {
            Price = 0.50M;
            Beverage = Beverage.Coffee;
            Change = payment - Price;
            this.creamer = creamer;
        }

    }
}
