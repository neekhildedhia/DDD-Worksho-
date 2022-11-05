using System;
using System.Collections.Generic;
namespace Sample_Code_1.Domain
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Product(String name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return $"Product<name={name}>";
        }
    }
}
