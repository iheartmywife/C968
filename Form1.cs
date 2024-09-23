using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kChermak_PA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
        }

        public static Inventory MainInventory { get; } = new Inventory();

        protected bool validName = false;
        protected bool validInventory = false;
        protected bool validPrice = false;
        protected bool validMax = false;
        protected bool validMin = false;
        protected bool validMachineID = false;
        protected bool validCompanyName = false;

        protected bool UpdateTextBoxColor(System.Windows.Forms.TextBox textBox)
        {
            var color = Color.IndianRed;
            var text = textBox.Text;
            if (text.Length > 0)
            {
                int value = 0;
                if (int.TryParse(text, out value))
                {
                    color = Color.White;
                }
            }
            textBox.BackColor = color;
            return (color == Color.White);
        }
        protected bool UpdateTextBoxColor2(System.Windows.Forms.TextBox textBox)
        {
            var color = Color.IndianRed;
            if (textBox.Text.Length > 0)
            {
                color = Color.White;
            }
            textBox.BackColor = color;
            return (color == Color.White);
        }
        protected bool UpdateTextBoxColor3(System.Windows.Forms.TextBox textBox)
        {
            var color = Color.IndianRed;
            var text = textBox.Text;
            if (text.Length > 0)
            {
                decimal value = 0;
                if (decimal.TryParse(text, out value))
                {
                    color = Color.White;
                }
            }
            textBox.BackColor = color;
            return (color == Color.White);
        }

        protected Part ValidateAndCreatePart(int partID, string name, string inventoryText, string priceText, string maxText, string minText, string machineIDText, string companyName, bool isInHouse)
        {
            Part newPart = null;
            bool valid = (validName && validInventory && validPrice && validMax && validMin);
            if (valid)
            {
                var inventory = int.Parse(inventoryText);
                var price = decimal.Parse(priceText);
                var max = int.Parse(maxText);
                var min = int.Parse(minText);


                if (inventory <= max)
                {
                    if (inventory >= min)
                    {
                        if (min <= max)
                        {
                            if (isInHouse)
                            {
                                if (validMachineID)
                                {
                                    var machineID = int.Parse(machineIDText);
                                    int newPartID = (partID < 0) ? Part.NextPartID : partID;
                                    newPart = new InHouse(newPartID, name, price, inventory, min, max, machineID);
                                }
                                else
                                {
                                    MessageBox.Show("Machine ID is invalid");
                                }
                            }
                            else
                            {
                                if (validCompanyName)
                                {
                                    int newPartID = (partID < 0) ? Part.NextPartID : partID;
                                    newPart = new Outsourced(newPartID, name, price, inventory, min, max, companyName);
                                }
                                else
                                {
                                    MessageBox.Show("Company Name is invalid");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Maximum cannot be greater than minimum");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inventory cannot be less than minimum");
                    }
                }
                else
                {
                    MessageBox.Show("Inventory cannot be greater than maximum");
                }
            }
            else
            {
                MessageBox.Show("One or more fields is invalid");
            }
            return newPart;
        }
        public bool CheckForParts(DataGridView dgv)
        {
            return (dgv.Rows.Count > 0);
        }

        protected Product ValidateAndCreateProduct(int productID, string name, string inventoryText, string priceText, string maxText, string minText, bool hasParts)
        {
            Product newProduct = null;
            bool valid = (validName && validInventory && validPrice && validMax && validMin);
            if (valid)
            {
                var inventory = int.Parse(inventoryText);
                var price = decimal.Parse(priceText);
                var max = int.Parse(maxText);
                var min = int.Parse(minText);


                if (inventory <= max)
                {
                    if (inventory >= min)
                    {
                        if (min <= max)
                        {
                            if (hasParts)
                            {
                                int newProductID = (productID < 0) ? Product.NextProductID : productID;
                                newProduct = new Product(newProductID, name, price, inventory, min, max);
                            }
                            else
                            {
                                MessageBox.Show("Please associate parts with this product");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Maximum cannot be greater than minimum");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inventory cannot be less than minimum");
                    }
                }
                else
                {
                    MessageBox.Show("Inventory cannot be greater than maximum");
                }
            }
            else
            {
                MessageBox.Show("One or more fields is invalid");
            }
            return newProduct;
        }

        private void WelcomeText2_Click(object sender, EventArgs e)
        {
        }

        private void Launch_Click(object sender, EventArgs e)
        {
        }

    }
}
