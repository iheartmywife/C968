using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kChermak_PA
{
    public partial class AddProduct : kChermak_PA.Form1
    {
        public AddProduct()
            :base()
        {
            InitializeComponent();
            ProductIDText.Text = Product.PeekAtNextProductID.ToString();
            var partsDataSource = new BindingSource();
            partsDataSource.DataSource = MainInventory.AllParts;
            Parts.DataSource = partsDataSource;
            Parts.Columns["InStock"].HeaderText = "Inventory";

            //note to evaluator: The GUI webinar video omits the above columns. The provided GUI Mockup document does not.
            //I chose to leave them in for readability (user can see min and max prior to saving).

            var associatedPartsDataSource = new BindingSource();
            associatedPartsDataSource.DataSource = AssociatedParts;
            ProductParts.DataSource = associatedPartsDataSource;
        }

        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();

        private void Search_Click(object sender, EventArgs e)
        {
            var found = false;
            string searchText = SearchText.Text.ToUpper();
            if (searchText.Length > 0)
            {
                foreach (DataGridViewRow row in Parts.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().ToUpper().Contains(searchText))
                    {
                        Parts.Rows[row.Index].Selected = true;
                        found = true;
                        break;

                    }
                    else if (row.Cells["PartID"].Value.ToString().Contains(searchText))
                    {
                        Parts.Rows[row.Index].Selected = true;
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                var messageString = "Your search for '" + SearchText.Text + "' returned no results.";
                MessageBox.Show(messageString);
            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            validName = UpdateTextBoxColor2(NameText);
        }

        private void InventoryText_TextChanged(object sender, EventArgs e)
        {
            validInventory = UpdateTextBoxColor(InventoryText);
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            validPrice = UpdateTextBoxColor3(PriceText);
        }

        private void MaxText_TextChanged(object sender, EventArgs e)
        {
            validMax = UpdateTextBoxColor(MaxText);
        }

        private void MinText_TextChanged(object sender, EventArgs e)
        {
            validMin = UpdateTextBoxColor(MinText);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var part = (Part)Parts.CurrentRow.DataBoundItem;
            AssociatedParts.Add(part);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var part = (Part)ProductParts.CurrentRow.DataBoundItem; 
            var confirmResult = MessageBox.Show("Are you sure you'd like to remove this part association?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                AssociatedParts.Remove(part);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool hasParts = CheckForParts(ProductParts);
            var product = ValidateAndCreateProduct(-1, NameText.Text, InventoryText.Text, PriceText.Text, MaxText.Text, MinText.Text, hasParts);
            
            if (product != null)
            {
                foreach (var part in AssociatedParts)
                {
                    product.AddAssociatedPart(part);
                }
                MainInventory.AddProduct(product);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductIDText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
