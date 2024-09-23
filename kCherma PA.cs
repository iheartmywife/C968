using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kChermak_PA
{
    public partial class MainScreen : kChermak_PA.Form1
    {
        public MainScreen()
            :base()
        {
            InitializeComponent();
            InitializeInventory();
        }
        

        private void InitializeInventory()
        {


            Part wheel = new InHouse(Part.NextPartID, "Wheel", 10, 14, 5, 20, 1337);
            Part pedal = new Outsourced(Part.NextPartID, "Pedal", 5, 12, 10, 40, "Shimano");
            Part chain = new InHouse(Part.NextPartID, "Chain", 2, 7, 5, 20, 1338);
            Part biframe = new Outsourced(Part.NextPartID, "Biframe", 25, 3, 2, 5, "Cannondale");
            Part uniframe = new InHouse(Part.NextPartID, "Uniframe", 12, 2, 1, 5, 1339);
            Part handlebars = new Outsourced(Part.NextPartID, "Handlebars", 10, 10, 5, 20, "Bianchi");
            Part horn = new InHouse(Part.NextPartID, "Horn", 3, 2, 1, 5, 1340);
            Part brake = new Outsourced(Part.NextPartID, "Brake", 5, 5, 3, 8, "Colnago");

            MainInventory.AddPart(wheel);
            MainInventory.AddPart(pedal);
            MainInventory.AddPart(chain);
            MainInventory.AddPart(biframe);
            MainInventory.AddPart(uniframe);
            MainInventory.AddPart(handlebars);
            MainInventory.AddPart(horn);
            MainInventory.AddPart(brake);


            Product bicycle = new Product(Product.NextProductID, "Bicyle", 100, 8, 5, 15);
            Product unicycle = new Product(Product.NextProductID, "Unicycle", 50, 5, 3, 10);

            bicycle.AddAssociatedPart(wheel);
            bicycle.AddAssociatedPart(wheel);
            bicycle.AddAssociatedPart(pedal);
            bicycle.AddAssociatedPart(pedal);
            bicycle.AddAssociatedPart(chain);
            bicycle.AddAssociatedPart(biframe);
            bicycle.AddAssociatedPart(handlebars);
            bicycle.AddAssociatedPart(horn);
            bicycle.AddAssociatedPart(brake);

            unicycle.AddAssociatedPart(wheel);
            unicycle.AddAssociatedPart(pedal);
            unicycle.AddAssociatedPart(pedal);
            unicycle.AddAssociatedPart(chain);
            unicycle.AddAssociatedPart(uniframe);
            unicycle.AddAssociatedPart(brake);

            MainInventory.AddProduct(bicycle);
            MainInventory.AddProduct(unicycle);


            var partsDataSource = new BindingSource();
            partsDataSource.DataSource = MainInventory.AllParts;
            Parts.DataSource = partsDataSource;

            var productsDataSource = new BindingSource();
            productsDataSource.DataSource = MainInventory.Products;
            Products.DataSource = productsDataSource;


        }
        private void Parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PartsAddButton_Click_1(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void PartsSearchButton_Click_1(object sender, EventArgs e)
        {
            string searchText = PartsSearchTextBox.Text.ToUpper();
            if (searchText.Length > 0)
            {
                foreach (DataGridViewRow row in Parts.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().ToUpper().Contains(searchText))
                    {
                        Parts.Rows[row.Index].Selected = true;
                        break;

                    }
                }
            }
        }

        private void PartsModifyButton_Click_1(object sender, EventArgs e)
        {
            var part = (Part)Parts.CurrentRow.DataBoundItem;
            new ModifyPart(part).ShowDialog();
        }

        private void PartsDeleteButton_Click_1(object sender, EventArgs e)
        {
            var part = (Part)Parts.CurrentRow.DataBoundItem;
            var confirmResult = MessageBox.Show("Are you sure to delete this part?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MainInventory.DeletePart(part);
            }
            else
            {
                return;
            }
        }


        private void ProductsAddButton_Click_1(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void ProductsModifyButton_Click_1(object sender, EventArgs e)
        {
            var product = (Product)Products.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
        }

        private void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            var product = (Product)Products.CurrentRow.DataBoundItem; 
            var confirmResult = MessageBox.Show("Are you sure to delete this product?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MainInventory.RemoveProduct(product.ProductID);
            }
            else
            {
                return;
            }
        }

        private void InventoryManagementSystemExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = ProductsSearchTextBox.Text.ToUpper();
            if (searchText.Length > 0)
            {
                foreach (DataGridViewRow row in Products.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().ToUpper().Contains(searchText))
                    {
                        Products.Rows[row.Index].Selected = true;
                        break;

                    }
                }
            }
        }

        private void ProductsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
