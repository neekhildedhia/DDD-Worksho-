using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Code_1.Domain
{
    public class Cart
    {
        private List<Product> products = new List<Product>();

        public void add(Product product)
        {
            products.Add(product);
        }

        public List<Product> getProducts()
        {
            return products;
        }

        public override string ToString()
        {
            return "Cart{" +
                    "products=" + products +
                    '}';
        }
    }
}
