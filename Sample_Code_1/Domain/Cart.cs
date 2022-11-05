using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Code_1.Domain
{
    public class Cart
    {
        private List<Item> items = new List<Item>();
        private List<string> removedItems = new List<string>();

        public void add(Item item)
        {
            if(removedItems.Contains(item.Product.Name))
            {
                removedItems.Remove(item.Product.Name);
            }
            items.Add(item);
        }

        public List<Item> getItems()
        {
            return items;
        }

        public List<string> getRemovedItems()
        {
            return removedItems;
        }

        public void remove(Product product)
        {
            if (!removedItems.Contains(product.Name))
            {
                removedItems.Add(product.Name);
            }
            items.RemoveAll(x=>x.Product.Name == product.Name);
        }

        public override string ToString()
        {
            return $"Cart<products={string.Join(",", items)}>";
        }
    }
}
