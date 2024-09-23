using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kChermak_PA
{
    public partial class AddPart : kChermak_PA.Form1
    {
        public AddPart()
            :base()
        {
            InitializeComponent();
            PartIDText.Text = Part.PeekAtNextPartID.ToString();
            InHouseRadioButton.Checked = true;
            CompanyNameLabel.Visible = false;
            CompanyNameText.Visible = false;
            NameText.Select();
            
        }
        private void InHouseRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            MachineIDLabel.Visible = true;
            CompanyNameLabel.Visible = false;
            MachineIDText.Visible = true;
            CompanyNameText.Visible = false;
        }

        private void OutsourcedRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            MachineIDLabel.Visible = false;
            CompanyNameLabel.Visible = true;
            MachineIDText.Visible = false;
            CompanyNameText.Visible = true;
        }

        private void NameText_TextChanged_1(object sender, EventArgs e)
        {
            validName = UpdateTextBoxColor2(NameText);
        }

        private void InventoryText_TextChanged_1(object sender, EventArgs e)
        {
            validInventory = UpdateTextBoxColor(InventoryText);
        }

        private void PriceText_TextChanged_1(object sender, EventArgs e)
        {
            validPrice = UpdateTextBoxColor3(PriceText);
        }

        private void MaxText_TextChanged_1(object sender, EventArgs e)
        {
            validMax = UpdateTextBoxColor(MaxText);
        }

        private void MinText_TextChanged_1(object sender, EventArgs e)
        {
            validMin = UpdateTextBoxColor(MinText);
        }

        private void MachineIDText_TextChanged_1(object sender, EventArgs e)
        {
            validMachineID = UpdateTextBoxColor(MachineIDText);
        }

        private void CompanyNameText_TextChanged_1(object sender, EventArgs e)
        {
            validCompanyName = UpdateTextBoxColor2(CompanyNameText);
        }

        private void PartIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            var part = ValidateAndCreatePart(-1, NameText.Text, InventoryText.Text, PriceText.Text,
                MaxText.Text, MinText.Text, MachineIDText.Text, CompanyNameText.Text, InHouseRadioButton.Checked);

            if (part != null)
            {
                MainInventory.AddPart(part);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }
    }
}
