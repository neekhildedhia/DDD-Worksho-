using System;
using System.Collections.Generic;
namespace Sample_Code_1.Domain
{
    public class Product
    {
        private String name;

        public Product(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Product{" +
                   "name='" + name + '\'' +
                   '}';
        }
    }
}
