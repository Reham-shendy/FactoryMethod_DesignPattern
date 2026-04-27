using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_FactoryPattern
{
    internal class pizzaCheese : Ipizza
    {
        public void Prepare()
        {
            Console.WriteLine("cheese pizza prepared");
        }
    }
}
