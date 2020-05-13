namespace Barcodes
{
    partial class AddNewProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.generateBarcodeButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.replenishStockButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.packQuantityRB1 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB2 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB4 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB8 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB16 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB32 = new System.Windows.Forms.RadioButton();
            this.packQuantityRB64 = new System.Windows.Forms.RadioButton();
            this.packQuantityRBOther = new System.Windows.Forms.RadioButton();
            this.otherQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.generateReportButton);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.generateBarcodeButton);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.addNewProductButton);
            this.panel1.Controls.Add(this.replenishStockButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 561);
            this.panel1.TabIndex = 3;
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.BackColor = System.Drawing.Color.Crimson;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.quitButton.ForeColor = System.Drawing.Color.Black;
            this.quitButton.Location = new System.Drawing.Point(11, 513);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 35);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 74);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add New Product";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateReportButton.BackColor = System.Drawing.Color.CadetBlue;
            this.generateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateReportButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.generateReportButton.ForeColor = System.Drawing.Color.Black;
            this.generateReportButton.Location = new System.Drawing.Point(11, 283);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(100, 62);
            this.generateReportButton.TabIndex = 19;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = false;
            // 
            // generateBarcodeButton
            // 
            this.generateBarcodeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateBarcodeButton.BackColor = System.Drawing.Color.CadetBlue;
            this.generateBarcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateBarcodeButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.generateBarcodeButton.ForeColor = System.Drawing.Color.Black;
            this.generateBarcodeButton.Location = new System.Drawing.Point(11, 215);
            this.generateBarcodeButton.Name = "generateBarcodeButton";
            this.generateBarcodeButton.Size = new System.Drawing.Size(100, 62);
            this.generateBarcodeButton.TabIndex = 18;
            this.generateBarcodeButton.Text = "Generate Barcode";
            this.generateBarcodeButton.UseVisualStyleBackColor = false;
            this.generateBarcodeButton.Click += new System.EventHandler(this.generateBarcodeButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellButton.BackColor = System.Drawing.Color.CadetBlue;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.sellButton.ForeColor = System.Drawing.Color.Black;
            this.sellButton.Location = new System.Drawing.Point(11, 11);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(100, 62);
            this.sellButton.TabIndex = 17;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            // 
            // replenishStockButton
            // 
            this.replenishStockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replenishStockButton.BackColor = System.Drawing.Color.CadetBlue;
            this.replenishStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replenishStockButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.replenishStockButton.ForeColor = System.Drawing.Color.Black;
            this.replenishStockButton.Location = new System.Drawing.Point(11, 147);
            this.replenishStockButton.Name = "replenishStockButton";
            this.replenishStockButton.Size = new System.Drawing.Size(100, 62);
            this.replenishStockButton.TabIndex = 16;
            this.replenishStockButton.Text = "Replenish Stock";
            this.replenishStockButton.UseVisualStyleBackColor = false;
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewProductButton.BackColor = System.Drawing.Color.CadetBlue;
            this.addNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewProductButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.addNewProductButton.ForeColor = System.Drawing.Color.Black;
            this.addNewProductButton.Location = new System.Drawing.Point(11, 79);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(100, 62);
            this.addNewProductButton.TabIndex = 15;
            this.addNewProductButton.Text = "Add New Product";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addButton);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.priceTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sizeTypeComboBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.sizeTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.otherQuantityTextBox);
            this.panel3.Controls.Add(this.packQuantityRBOther);
            this.panel3.Controls.Add(this.packQuantityRB64);
            this.panel3.Controls.Add(this.packQuantityRB32);
            this.panel3.Controls.Add(this.packQuantityRB16);
            this.panel3.Controls.Add(this.packQuantityRB8);
            this.panel3.Controls.Add(this.packQuantityRB4);
            this.panel3.Controls.Add(this.packQuantityRB2);
            this.panel3.Controls.Add(this.packQuantityRB1);
            this.panel3.Controls.Add(this.productNameTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.productTypeComboBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(144, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 487);
            this.panel3.TabIndex = 5;
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "EAN-13",
            "Code 128"});
            this.productTypeComboBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(155, 3);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(373, 35);
            this.productTypeComboBox.TabIndex = 15;
            this.productTypeComboBox.Text = "Choose Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.productNameTextBox.Location = new System.Drawing.Point(155, 44);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(373, 35);
            this.productNameTextBox.TabIndex = 17;
            this.productNameTextBox.Text = "Name ?";
            // 
            // packQuantityRB1
            // 
            this.packQuantityRB1.AutoSize = true;
            this.packQuantityRB1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB1.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB1.Location = new System.Drawing.Point(155, 85);
            this.packQuantityRB1.Name = "packQuantityRB1";
            this.packQuantityRB1.Size = new System.Drawing.Size(40, 31);
            this.packQuantityRB1.TabIndex = 18;
            this.packQuantityRB1.TabStop = true;
            this.packQuantityRB1.Text = "1";
            this.packQuantityRB1.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB2
            // 
            this.packQuantityRB2.AutoSize = true;
            this.packQuantityRB2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB2.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB2.Location = new System.Drawing.Point(201, 85);
            this.packQuantityRB2.Name = "packQuantityRB2";
            this.packQuantityRB2.Size = new System.Drawing.Size(40, 31);
            this.packQuantityRB2.TabIndex = 19;
            this.packQuantityRB2.TabStop = true;
            this.packQuantityRB2.Text = "2";
            this.packQuantityRB2.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB4
            // 
            this.packQuantityRB4.AutoSize = true;
            this.packQuantityRB4.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB4.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB4.Location = new System.Drawing.Point(247, 85);
            this.packQuantityRB4.Name = "packQuantityRB4";
            this.packQuantityRB4.Size = new System.Drawing.Size(40, 31);
            this.packQuantityRB4.TabIndex = 20;
            this.packQuantityRB4.TabStop = true;
            this.packQuantityRB4.Text = "4";
            this.packQuantityRB4.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB8
            // 
            this.packQuantityRB8.AutoSize = true;
            this.packQuantityRB8.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB8.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB8.Location = new System.Drawing.Point(293, 85);
            this.packQuantityRB8.Name = "packQuantityRB8";
            this.packQuantityRB8.Size = new System.Drawing.Size(40, 31);
            this.packQuantityRB8.TabIndex = 21;
            this.packQuantityRB8.TabStop = true;
            this.packQuantityRB8.Text = "8";
            this.packQuantityRB8.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB16
            // 
            this.packQuantityRB16.AutoSize = true;
            this.packQuantityRB16.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB16.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB16.Location = new System.Drawing.Point(339, 85);
            this.packQuantityRB16.Name = "packQuantityRB16";
            this.packQuantityRB16.Size = new System.Drawing.Size(50, 31);
            this.packQuantityRB16.TabIndex = 22;
            this.packQuantityRB16.TabStop = true;
            this.packQuantityRB16.Text = "16";
            this.packQuantityRB16.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB32
            // 
            this.packQuantityRB32.AutoSize = true;
            this.packQuantityRB32.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB32.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB32.Location = new System.Drawing.Point(395, 85);
            this.packQuantityRB32.Name = "packQuantityRB32";
            this.packQuantityRB32.Size = new System.Drawing.Size(50, 31);
            this.packQuantityRB32.TabIndex = 23;
            this.packQuantityRB32.TabStop = true;
            this.packQuantityRB32.Text = "32";
            this.packQuantityRB32.UseVisualStyleBackColor = true;
            // 
            // packQuantityRB64
            // 
            this.packQuantityRB64.AutoSize = true;
            this.packQuantityRB64.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRB64.ForeColor = System.Drawing.Color.White;
            this.packQuantityRB64.Location = new System.Drawing.Point(451, 85);
            this.packQuantityRB64.Name = "packQuantityRB64";
            this.packQuantityRB64.Size = new System.Drawing.Size(50, 31);
            this.packQuantityRB64.TabIndex = 24;
            this.packQuantityRB64.TabStop = true;
            this.packQuantityRB64.Text = "64";
            this.packQuantityRB64.UseVisualStyleBackColor = true;
            // 
            // packQuantityRBOther
            // 
            this.packQuantityRBOther.AutoSize = true;
            this.packQuantityRBOther.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.packQuantityRBOther.ForeColor = System.Drawing.Color.White;
            this.packQuantityRBOther.Location = new System.Drawing.Point(155, 122);
            this.packQuantityRBOther.Name = "packQuantityRBOther";
            this.packQuantityRBOther.Size = new System.Drawing.Size(74, 31);
            this.packQuantityRBOther.TabIndex = 25;
            this.packQuantityRBOther.TabStop = true;
            this.packQuantityRBOther.Text = "Other";
            this.packQuantityRBOther.UseVisualStyleBackColor = true;
            // 
            // otherQuantityTextBox
            // 
            this.otherQuantityTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.otherQuantityTextBox.Location = new System.Drawing.Point(235, 121);
            this.otherQuantityTextBox.Name = "otherQuantityTextBox";
            this.otherQuantityTextBox.Size = new System.Drawing.Size(293, 35);
            this.otherQuantityTextBox.TabIndex = 26;
            this.otherQuantityTextBox.Text = "Quantity ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pack Quantity:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.sizeTextBox.Location = new System.Drawing.Point(155, 162);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(373, 35);
            this.sizeTextBox.TabIndex = 28;
            this.sizeTextBox.Text = "Size ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Size:";
            // 
            // sizeTypeComboBox
            // 
            this.sizeTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "EAN-13",
            "Code 128"});
            this.sizeTypeComboBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.sizeTypeComboBox.FormattingEnabled = true;
            this.sizeTypeComboBox.Location = new System.Drawing.Point(155, 203);
            this.sizeTypeComboBox.Name = "sizeTypeComboBox";
            this.sizeTypeComboBox.Size = new System.Drawing.Size(373, 35);
            this.sizeTypeComboBox.TabIndex = 30;
            this.sizeTypeComboBox.Text = "Choose Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Size Type:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.priceTextBox.Location = new System.Drawing.Point(155, 244);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(373, 35);
            this.priceTextBox.TabIndex = 32;
            this.priceTextBox.Text = "Price (£) ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Price:";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BackColor = System.Drawing.Color.CadetBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(428, 439);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddNewProduct";
            this.Text = "AddNewProduct";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Button generateBarcodeButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button replenishStockButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.RadioButton packQuantityRB2;
        private System.Windows.Forms.RadioButton packQuantityRB1;
        private System.Windows.Forms.RadioButton packQuantityRBOther;
        private System.Windows.Forms.RadioButton packQuantityRB64;
        private System.Windows.Forms.RadioButton packQuantityRB32;
        private System.Windows.Forms.RadioButton packQuantityRB16;
        private System.Windows.Forms.RadioButton packQuantityRB8;
        private System.Windows.Forms.RadioButton packQuantityRB4;
        private System.Windows.Forms.TextBox otherQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sizeTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
    }
}