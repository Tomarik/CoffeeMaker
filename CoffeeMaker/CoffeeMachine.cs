using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    class CoffeeMachine
    {
        private Order currentOrder;


        // does all the magic
        public void CreateOrder(decimal money, Beverage beverageChoice, bool addin)
        {
            switch (beverageChoice)
            {
                case Beverage.Coffee:
                    Coffee coffeeDrink = new Coffee(money, addin);
                    currentOrder = coffeeDrink;
                    break;
                case Beverage.Broth:
                    Broth brothDrink = new Broth(money);
                    currentOrder = brothDrink;
                    break;
            }

            

            MakeDrink();
            DispenseDrink();
            DispenseChange();



        }

      

        public void DispenseDrink()
        {
            if (currentOrder is Coffee && currentOrder.Addin == true)
            {
                System.Console.WriteLine("Dispensing your " + currentOrder.Beverage + " and cream");
            }
            else
            {
                System.Console.WriteLine("Dispensing your432343 " + currentOrder.Beverage);

            }
        }

        public void DispenseChange()
        {
            Console.WriteLine("Heres your change $" + currentOrder.Change);

        }

        public void MakeDrink()
        {
            Console.WriteLine("Brewing your beverage!");
        }
    }
}
