using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sample_Code_1.Domain
{
    public class Item
    {
        private Product product;
        private int quantity;

        public Product Product
        {
            get
            {
                return this.product;
            }
            set
            {
                this.product = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public Item(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public Product getProduct()
        {
            return product;
        }

        
        public override string ToString()
        {
            return $"Item<product={product}, quantity={quantity}>{Environment.NewLine}";
        }



    }
}
