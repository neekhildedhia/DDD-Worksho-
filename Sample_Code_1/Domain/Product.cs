using System;
using System.Collections.Generic;
namespace Sample_Code_1.Domain
{
    public class Product
    {
        private string name;
        private int quantity;

        public Product(String name, int quantity = 1)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return $"Product<name={name}, quantity={quantity}>";
        }
    }
}
