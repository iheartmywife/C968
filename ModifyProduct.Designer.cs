﻿namespace kChermak_PA
{
    partial class ModifyProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
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
            this.ProductIDText = new System.Windows.Forms.TextBox();
            this.ProductParts = new System.Windows.Forms.DataGridView();
            this.Parts = new System.Windows.Forms.DataGridView();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Parts Associated with this Product";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(429, 82);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(119, 16);
            this.ProductsLabel.TabIndex = 95;
            this.ProductsLabel.Text = "All candidate Parts";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1018, 311);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(62, 28);
            this.AddButton.TabIndex = 94;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(1018, 642);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(62, 28);
            this.CancelButton.TabIndex = 93;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(950, 642);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(62, 28);
            this.SaveButton.TabIndex = 92;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Location = new System.Drawing.Point(1018, 608);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(62, 28);
            this.DeleteButton.TabIndex = 91;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(769, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(83, 20);
            this.Search.TabIndex = 90;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(858, 54);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(222, 20);
            this.SearchText.TabIndex = 89;
            // 
            // MinText
            // 
            this.MinText.BackColor = System.Drawing.Color.White;
            this.MinText.Location = new System.Drawing.Point(260, 325);
            this.MinText.Name = "MinText";
            this.MinText.Size = new System.Drawing.Size(62, 20);
            this.MinText.TabIndex = 88;
            this.MinText.TextChanged += new System.EventHandler(this.MinText_TextChanged);
            // 
            // MaxText
            // 
            this.MaxText.BackColor = System.Drawing.Color.White;
            this.MaxText.Location = new System.Drawing.Point(130, 325);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(71, 20);
            this.MaxText.TabIndex = 87;
            this.MaxText.TextChanged += new System.EventHandler(this.MaxText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.White;
            this.PriceText.Location = new System.Drawing.Point(130, 285);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(151, 20);
            this.PriceText.TabIndex = 86;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // InventoryText
            // 
            this.InventoryText.BackColor = System.Drawing.Color.White;
            this.InventoryText.Location = new System.Drawing.Point(130, 245);
            this.InventoryText.Name = "InventoryText";
            this.InventoryText.Size = new System.Drawing.Size(151, 20);
            this.InventoryText.TabIndex = 85;
            this.InventoryText.TextChanged += new System.EventHandler(this.InventoryText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.White;
            this.NameText.Location = new System.Drawing.Point(130, 205);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(151, 20);
            this.NameText.TabIndex = 84;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLabel.Location = new System.Drawing.Point(220, 325);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.AddPartMinLabel.TabIndex = 83;
            this.AddPartMinLabel.Text = "Min";
            // 
            // AddPartMaxLabel
            // 
            this.AddPartMaxLabel.AutoSize = true;
            this.AddPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMaxLabel.Location = new System.Drawing.Point(35, 325);
            this.AddPartMaxLabel.Name = "AddPartMaxLabel";
            this.AddPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.AddPartMaxLabel.TabIndex = 82;
            this.AddPartMaxLabel.Text = "Max";
            // 
            // AddPartPriceCostLabel
            // 
            this.AddPartPriceCostLabel.AutoSize = true;
            this.AddPartPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartPriceCostLabel.Location = new System.Drawing.Point(35, 285);
            this.AddPartPriceCostLabel.Name = "AddPartPriceCostLabel";
            this.AddPartPriceCostLabel.Size = new System.Drawing.Size(44, 20);
            this.AddPartPriceCostLabel.TabIndex = 81;
            this.AddPartPriceCostLabel.Text = "Price";
            // 
            // AddPartInventoryLabel
            // 
            this.AddPartInventoryLabel.AutoSize = true;
            this.AddPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartInventoryLabel.Location = new System.Drawing.Point(35, 243);
            this.AddPartInventoryLabel.Name = "AddPartInventoryLabel";
            this.AddPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.AddPartInventoryLabel.TabIndex = 80;
            this.AddPartInventoryLabel.Text = "Inventory";
            // 
            // AddPartNameLabel
            // 
            this.AddPartNameLabel.AutoSize = true;
            this.AddPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLabel.Location = new System.Drawing.Point(35, 205);
            this.AddPartNameLabel.Name = "AddPartNameLabel";
            this.AddPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.AddPartNameLabel.TabIndex = 79;
            this.AddPartNameLabel.Text = "Name";
            // 
            // AddPartIDLabel
            // 
            this.AddPartIDLabel.AutoSize = true;
            this.AddPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartIDLabel.Location = new System.Drawing.Point(35, 165);
            this.AddPartIDLabel.Name = "AddPartIDLabel";
            this.AddPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.AddPartIDLabel.TabIndex = 78;
            this.AddPartIDLabel.Text = "ID";
            // 
            // ProductIDText
            // 
            this.ProductIDText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProductIDText.Location = new System.Drawing.Point(130, 165);
            this.ProductIDText.Name = "ProductIDText";
            this.ProductIDText.Size = new System.Drawing.Size(151, 20);
            this.ProductIDText.TabIndex = 77;
            // 
            // ProductParts
            // 
            this.ProductParts.AllowUserToResizeColumns = false;
            this.ProductParts.AllowUserToResizeRows = false;
            this.ProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductParts.Location = new System.Drawing.Point(432, 398);
            this.ProductParts.MultiSelect = false;
            this.ProductParts.Name = "ProductParts";
            this.ProductParts.ReadOnly = true;
            this.ProductParts.RowHeadersVisible = false;
            this.ProductParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductParts.Size = new System.Drawing.Size(648, 204);
            this.ProductParts.TabIndex = 76;
            // 
            // Parts
            // 
            this.Parts.AllowUserToResizeColumns = false;
            this.Parts.AllowUserToResizeRows = false;
            this.Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parts.Location = new System.Drawing.Point(432, 101);
            this.Parts.MultiSelect = false;
            this.Parts.Name = "Parts";
            this.Parts.ReadOnly = true;
            this.Parts.RowHeadersVisible = false;
            this.Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Parts.Size = new System.Drawing.Size(648, 204);
            this.Parts.TabIndex = 75;
            this.Parts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parts_CellContentClick);
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(12, 6);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(135, 24);
            this.ModifyProductLabel.TabIndex = 74;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchText);
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
            this.Controls.Add(this.ProductIDText);
            this.Controls.Add(this.ProductParts);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.ModifyProductLabel);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.ProductParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button AddButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchText;
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
        private System.Windows.Forms.TextBox ProductIDText;
        private System.Windows.Forms.DataGridView ProductParts;
        private System.Windows.Forms.DataGridView Parts;
        private System.Windows.Forms.Label ModifyProductLabel;
    }
}
