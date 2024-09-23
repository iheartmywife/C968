using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kChermak_PA
{
    public class Inventory
    {
        public BindingList<Product> Products { get; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; } = new BindingList<Part>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public bool RemoveProduct(int productID)
        {
            bool found = false;
            foreach (Product product in Products)
            {

                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    found = true;
                    break;
                }

            }
            return found;
        }
        public Product LookupProduct(int productID)
        {
            Product lookup = null;
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    lookup = product;
                    break;
                }
            }
            return lookup;
        }
        public void UpdateProduct(int productID, Product product)
        {
            Product oldProduct = LookupProduct(productID);
            if (oldProduct != null)
            {
                RemoveProduct(oldProduct.ProductID);
                AddProduct(product);

            }
        }
        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool AssociationCheck(Part part)
        {
            var associated = false;
            foreach (Product product in Products)
            {
                if (product.IsAssociatedPart(part.PartID)) 
                { 
                    associated = true; 
                    break;
                }
            }
            return associated;
        }
        public bool DeletePart(Part part)
        {
            foreach (Product product in Products)
            {
                bool found = true;
                while (found)
                {
                    found = product.RemoveAssociatedPart(part.PartID);
                }
            }
            return AllParts.Remove(part);
        }
        public Part LookupPart(int partID)
        {
            Part lookup = null;
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    lookup = part;
                    break;
                }

            }
            return lookup;
        }
        public void UpdatePart(int oldPartID, Part part)
        {
            Part oldPart = LookupPart(oldPartID);
            if (oldPart != null)
            {
                AllParts.Add(part);
                foreach (Product product in Products)
                {
                    bool found = true;
                    int count = 0;
                    while (found)
                    {
                        found = product.RemoveAssociatedPart(oldPartID);
                        if (found)
                        {
                            ++count;
                        }
                    }
                    for (; count > 0; --count)
                    {
                        product.AddAssociatedPart(part);
                    }
                }
                AllParts.Remove(oldPart);
            }
        }


    }
}
