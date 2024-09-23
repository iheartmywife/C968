namespace kChermak_PA
{
    partial class ModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.MachineIDText = new System.Windows.Forms.TextBox();
            this.MachineIDLabel = new System.Windows.Forms.Label();
            this.MinText = new System.Windows.Forms.TextBox();
            this.MaxText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.InventoryText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddPartMinLabel = new System.Windows.Forms.Label();
            this.AddPartMaxLabel = new System.Windows.Forms.Label();
            this.AddPartPriceCostLabel = new System.Windows.Forms.Label();
            this.AddPartInventoryLabel = new System.Windows.Forms.Label();
            this.AddPartNameLabel = new System.Windows.Forms.Label();
            this.AddPartIDLabel = new System.Windows.Forms.Label();
            this.PartIDText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutsourcedRadioButton
            // 
            this.OutsourcedRadioButton.AutoSize = true;
            this.OutsourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedRadioButton.Location = new System.Drawing.Point(275, 19);
            this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            this.OutsourcedRadioButton.Size = new System.Drawing.Size(94, 20);
            this.OutsourcedRadioButton.TabIndex = 104;
            this.OutsourcedRadioButton.TabStop = true;
            this.OutsourcedRadioButton.Text = "Outsourced";
            this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.OutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadioButton.Location = new System.Drawing.Point(181, 19);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(79, 20);
            this.InHouseRadioButton.TabIndex = 103;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(374, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 27);
            this.CancelButton.TabIndex = 102;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(312, 348);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 27);
            this.SaveButton.TabIndex = 101;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.BackColor = System.Drawing.Color.White;
            this.CompanyNameText.Location = new System.Drawing.Point(218, 314);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(151, 20);
            this.CompanyNameText.TabIndex = 100;
            this.CompanyNameText.TextChanged += new System.EventHandler(this.CompanyNameText_TextChanged);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(90, 314);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(122, 20);
            this.CompanyNameLabel.TabIndex = 99;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // MachineIDText
            // 
            this.MachineIDText.BackColor = System.Drawing.Color.White;
            this.MachineIDText.Location = new System.Drawing.Point(218, 314);
            this.MachineIDText.Name = "MachineIDText";
            this.MachineIDText.Size = new System.Drawing.Size(151, 20);
            this.MachineIDText.TabIndex = 98;
            this.MachineIDText.TextChanged += new System.EventHandler(this.MachineIDText_TextChanged);
            // 
            // MachineIDLabel
            // 
            this.MachineIDLabel.AutoSize = true;
            this.MachineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineIDLabel.Location = new System.Drawing.Point(122, 314);
            this.MachineIDLabel.Name = "MachineIDLabel";
            this.MachineIDLabel.Size = new System.Drawing.Size(90, 20);
            this.MachineIDLabel.TabIndex = 97;
            this.MachineIDLabel.Text = "Machine ID";
            // 
            // MinText
            // 
            this.MinText.BackColor = System.Drawing.Color.White;
            this.MinText.Location = new System.Drawing.Point(368, 271);
            this.MinText.Name = "MinText";
            this.MinText.Size = new System.Drawing.Size(62, 20);
            this.MinText.TabIndex = 96;
            this.MinText.TextChanged += new System.EventHandler(this.MinText_TextChanged);
            // 
            // MaxText
            // 
            this.MaxText.BackColor = System.Drawing.Color.White;
            this.MaxText.Location = new System.Drawing.Point(218, 271);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(71, 20);
            this.MaxText.TabIndex = 95;
            this.MaxText.TextChanged += new System.EventHandler(this.MaxText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.White;
            this.PriceText.Location = new System.Drawing.Point(218, 231);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(151, 20);
            this.PriceText.TabIndex = 94;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // InventoryText
            // 
            this.InventoryText.BackColor = System.Drawing.Color.White;
            this.InventoryText.Location = new System.Drawing.Point(218, 191);
            this.InventoryText.Name = "InventoryText";
            this.InventoryText.Size = new System.Drawing.Size(151, 20);
            this.InventoryText.TabIndex = 93;
            this.InventoryText.TextChanged += new System.EventHandler(this.InventoryText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.White;
            this.NameText.Location = new System.Drawing.Point(218, 151);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(151, 20);
            this.NameText.TabIndex = 92;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLabel.Location = new System.Drawing.Point(328, 271);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.AddPartMinLabel.TabIndex = 91;
            this.AddPartMinLabel.Text = "Min";
            // 
            // AddPartMaxLabel
            // 
            this.AddPartMaxLabel.AutoSize = true;
            this.AddPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMaxLabel.Location = new System.Drawing.Point(174, 271);
            this.AddPartMaxLabel.Name = "AddPartMaxLabel";
            this.AddPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.AddPartMaxLabel.TabIndex = 90;
            this.AddPartMaxLabel.Text = "Max";
            // 
            // AddPartPriceCostLabel
            // 
            this.AddPartPriceCostLabel.AutoSize = true;
            this.AddPartPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartPriceCostLabel.Location = new System.Drawing.Point(123, 231);
            this.AddPartPriceCostLabel.Name = "AddPartPriceCostLabel";
            this.AddPartPriceCostLabel.Size = new System.Drawing.Size(89, 20);
            this.AddPartPriceCostLabel.TabIndex = 89;
            this.AddPartPriceCostLabel.Text = "Price / Cost";
            // 
            // AddPartInventoryLabel
            // 
            this.AddPartInventoryLabel.AutoSize = true;
            this.AddPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartInventoryLabel.Location = new System.Drawing.Point(138, 189);
            this.AddPartInventoryLabel.Name = "AddPartInventoryLabel";
            this.AddPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.AddPartInventoryLabel.TabIndex = 88;
            this.AddPartInventoryLabel.Text = "Inventory";
            // 
            // AddPartNameLabel
            // 
            this.AddPartNameLabel.AutoSize = true;
            this.AddPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLabel.Location = new System.Drawing.Point(161, 151);
            this.AddPartNameLabel.Name = "AddPartNameLabel";
            this.AddPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.AddPartNameLabel.TabIndex = 87;
            this.AddPartNameLabel.Text = "Name";
            // 
            // AddPartIDLabel
            // 
            this.AddPartIDLabel.AutoSize = true;
            this.AddPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartIDLabel.Location = new System.Drawing.Point(186, 111);
            this.AddPartIDLabel.Name = "AddPartIDLabel";
            this.AddPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.AddPartIDLabel.TabIndex = 86;
            this.AddPartIDLabel.Text = "ID";
            // 
            // PartIDText
            // 
            this.PartIDText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PartIDText.Location = new System.Drawing.Point(218, 111);
            this.PartIDText.Name = "PartIDText";
            this.PartIDText.ReadOnly = true;
            this.PartIDText.Size = new System.Drawing.Size(151, 20);
            this.PartIDText.TabIndex = 85;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(9, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(82, 24);
            this.TitleLabel.TabIndex = 84;
            this.TitleLabel.Text = "Add Part";
            // 
            // ModifyPart
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.OutsourcedRadioButton);
            this.Controls.Add(this.InHouseRadioButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CompanyNameText);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.MachineIDText);
            this.Controls.Add(this.MachineIDLabel);
            this.Controls.Add(this.MinText);
            this.Controls.Add(this.MaxText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InventoryText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AddPartMinLabel);
            this.Controls.Add(this.AddPartMaxLabel);
            this.Controls.Add(this.AddPartPriceCostLabel);
            this.Controls.Add(this.AddPartInventoryLabel);
            this.Controls.Add(this.AddPartNameLabel);
            this.Controls.Add(this.AddPartIDLabel);
            this.Controls.Add(this.PartIDText);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OutsourcedRadioButton;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TextBox MachineIDText;
        private System.Windows.Forms.Label MachineIDLabel;
        private System.Windows.Forms.TextBox MinText;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox InventoryText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label AddPartMinLabel;
        private System.Windows.Forms.Label AddPartMaxLabel;
        private System.Windows.Forms.Label AddPartPriceCostLabel;
        private System.Windows.Forms.Label AddPartInventoryLabel;
        private System.Windows.Forms.Label AddPartNameLabel;
        private System.Windows.Forms.Label AddPartIDLabel;
        private System.Windows.Forms.TextBox PartIDText;
        private System.Windows.Forms.Label TitleLabel;
    }
}
