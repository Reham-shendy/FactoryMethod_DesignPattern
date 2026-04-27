using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_FactoryPattern
{
    internal class pizzaFactory 
    {
        public static Ipizza createPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Pepperoni:
                    return new pizzaPepperoni();
                case PizzaType.seafood:
                    return new pizzaSeafood();
                case PizzaType.Cheese:
                    return new pizzaCheese();
                default:
                    throw new NotSupportedException($"Unknown pizza type called: {type}");
            }
        }
        
    }
}
