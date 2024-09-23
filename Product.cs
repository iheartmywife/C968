using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kChermak_PA
{
    public class Product
    {
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        static private int _nextProductID = 0;
        static public int NextProductID
        {
            get
            {
                return _nextProductID++;
            }
        }

        static public int PeekAtNextProductID
        {
            get
            {
                return _nextProductID;
            }
        }
        public int ProductID { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool found = false;
            foreach (Part part in AssociatedParts)
            {

                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    found = true;
                    break;
                }

            }
            return found;
        }

        public bool IsAssociatedPart(int partID)
        {
            bool isAssociated = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    isAssociated = true;
                    break;
                }
            }
            return isAssociated;
        }
        public Part LookupAssociatedPart(int partID)
        {
            Part lookup = null;
            foreach (Part part in AssociatedParts)
            {

                if (part.PartID == partID)
                {
                    lookup = part;
                    break;
                }

            }
            return lookup;
        }
        public void Update(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            InStock = product.InStock;
            Min = product.Min;
            Max = product.Max;
        }
    }
}
