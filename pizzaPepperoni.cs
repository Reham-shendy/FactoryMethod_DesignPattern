using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_FactoryPattern
{
    internal class pizzaPepperoni : Ipizza
    {
        public void Prepare()
        {
            Console.WriteLine("Pepperoni pizza prepared");
        }
    }
}
