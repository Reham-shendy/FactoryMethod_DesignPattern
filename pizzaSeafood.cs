using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_FactoryPattern
{
    internal class pizzaSeafood : Ipizza
    {
        public void Prepare()
        {
            Console.WriteLine("seafood pizza prepared");
        }
    }
}
