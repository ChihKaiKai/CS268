using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public Color Color
        {
            get
            {
                switch (this.Status)
                {
                    default:
                        return Color.Black;

                    case "熱賣":
                        return Color.Red;

                    case "綠標":
                        return Color.Green;

                    case "降價":
                        return Color.Blue;
                }
            }
        }

        public int CompareTo(Product other)
        {
            return this.Price - other.Price;
        }

        public override string ToString()
        {
            return string.Format("產品名稱:{0}, 價格:{1}", this.Name, this.Price);
        }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product other = obj as Product;
                return this.Name == other.Name && this.Price == other.Price;
            }
            else
            {
                return false;
            }
        }
    }
}