using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4dz
{
    public partial class Airplane
    {
        private string make;
        private string model;
        private int year;
        private double price;
        // Статические поля
        private static int totalAirplanes;
        private static double totalPrice;

        public Airplane()
        {
            make = "Unknown";
            model = "Unknown";
            year = DateTime.Now.Year;
            price = 0.0;
            totalAirplanes++;
            totalPrice += price;
        }

        public Airplane(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            totalAirplanes++;
            totalPrice += price;
        }

        internal void CustomMethod()
        {
            throw new NotImplementedException();
        }

        public Airplane(string make, string model)
            : this(make, model, DateTime.Now.Year, 0)
        {
        }

        static Airplane()
        {
            totalAirplanes = 0;
            totalPrice = 0.0;
        }

        public string GetMake()
        {
            return make;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            totalPrice -= this.price;
            totalPrice += price;
            this.price = price;
        }

        

        public void ChangePrice(ref double newPrice)
        {
            totalPrice -= price;
            totalPrice += newPrice;
            price = newPrice;
        }

        public void Start()
        {
            Console.WriteLine($"Starting the {year} {make} {model}.");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping the {year} {make} {model}.");
        }

        public static int GetTotalAirplanes()
        {
            return totalAirplanes;
        }

        public static double GetTotalPrice()
        {
            return totalPrice;
        }
    }

}
