﻿using System;
using System.Globalization;
namespace Exercicio_12.Entities {
    class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            string date = ManufactureDate.ToString("dd/MM/yyyy");
            return $"{Name} (used) $ {Price.ToString("F2",CultureInfo.InvariantCulture)} (Manufacture date: {date})";
        }
    }
}
