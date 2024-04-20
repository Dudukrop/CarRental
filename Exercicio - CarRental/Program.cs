using System;
using System.Globalization;
using Exercicio___CarRental.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

            Console.WriteLine(carRental);
            Console.ReadLine();
        }
    }
}