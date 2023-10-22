using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Module4dz
{

    partial class Airplane
    {
        public void CustomMethod()
        {
            Console.WriteLine($"Custom method called for the {year} {make} {model}.");
        }
    }
}

