﻿using System;
using System.Globalization;
using SolucaoSemInterface.Entities;
namespace SolucaoSemInterface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model:");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}
