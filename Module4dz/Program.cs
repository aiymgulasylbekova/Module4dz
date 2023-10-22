using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Module4dz
{
    internal class Program
    {
        static void Main()
        {
            Airplane[] airplanes = new Airplane[5];

            airplanes[0] = new Airplane("Boeign", "767", 2023, 25000);
            airplanes[1] = new Airplane("Boeign", "GA-1", 2022, 22000);
            airplanes[2] = new Airplane("Boeign", "Model 40", 2023, 28000);
            airplanes[3] = new Airplane("Boeign", "Monomail", 2022, 24000);
            airplanes[4] = new Airplane("Boeign", "NLA", 2023, 23000);

            airplanes[0].Start();
            airplanes[1].Stop();

            double newPrice = 26000;
            airplanes[2].ChangePrice(ref newPrice);

            Console.WriteLine($"Total car count: {Airplane.GetTotalAirplanes()}");
            Console.WriteLine($"Total car value: ${Airplane.GetTotalPrice()}");

            airplanes[0].CustomMethod();
        }
    }
}
