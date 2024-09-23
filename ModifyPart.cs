using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kChermak_PA
{
    public partial class ModifyPart : kChermak_PA.Form1
    {
        public ModifyPart(Part part)
            : base()
        {
            InitializeComponent();
            this.part = part;
            PartIDText.Text = part.PartID.ToString();
            NameText.Text = part.Name;
            InventoryText.Text = (part.InStock).ToString();
            PriceText.Text = part.Price.ToString();
            MaxText.Text = part.Max.ToString();
            MinText.Text = part.Min.ToString();
            if (part.GetType() == typeof(InHouse))
            {
                MachineIDText.Visible = true;
                MachineIDLabel.Visible = true;
                CompanyNameLabel.Visible = false;
                CompanyNameText.Visible = false;
                InHouseRadioButton.Checked = true;
                MachineIDText.Text = ((InHouse)part).MachineID.ToString();
            }
            else
            {
                MachineIDText.Visible = false;
                MachineIDLabel.Visible = false;
                CompanyNameLabel.Visible = true;
                CompanyNameText.Visible = true;
                OutsourcedRadioButton.Checked = true;
                CompanyNameText.Text = ((Outsourced)part).CompanyName;
            }
            NameText.Select();
        }
        private Part part = null;

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDText.Visible = true;
            MachineIDLabel.Visible = true;
            CompanyNameLabel.Visible = false;
            CompanyNameText.Visible = false;
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDText.Visible = false;
            MachineIDLabel.Visible = false;
            CompanyNameLabel.Visible = true;
            CompanyNameText.Visible = true;
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

        private void MachineIDText_TextChanged(object sender, EventArgs e)
        {
            validMachineID = UpdateTextBoxColor(MachineIDText);
        }

        private void CompanyNameText_TextChanged(object sender, EventArgs e)
        {
            validCompanyName = UpdateTextBoxColor2(CompanyNameText);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var updatePart = ValidateAndCreatePart(part.PartID, NameText.Text, InventoryText.Text, PriceText.Text,
                MaxText.Text, MinText.Text, MachineIDText.Text, CompanyNameText.Text, InHouseRadioButton.Checked);

            if (updatePart != null)
            {
                MainInventory.UpdatePart(part.PartID, updatePart);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }
    }
}
