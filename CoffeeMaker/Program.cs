using System;

namespace CoffeeMaker
{


    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine cm = new CoffeeMachine();
            cm.CreateOrder(1.00M, Beverage.Coffee, true);
        }
    }
}
