using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ipizza pizza = pizzaFactory.createPizza(PizzaType.Pepperoni);
                pizza.Prepare();
                Ipizza pizza2 = pizzaFactory.createPizza(PizzaType.Cheese);
                pizza2.Prepare();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
