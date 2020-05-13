namespace Barcodes
{
    partial class BarcodeGenerator
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
            this.generateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.generateBarcodeButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.replenishStockButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateButton.BackColor = System.Drawing.Color.CadetBlue;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.generateButton.ForeColor = System.Drawing.Color.Black;
            this.generateButton.Location = new System.Drawing.Point(428, 277);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 35);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(5, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 169);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.generateReportButton);
            this.panel1.Controls.Add(this.generateBarcodeButton);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.replenishStockButton);
            this.panel1.Controls.Add(this.addNewProductButton);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 561);
            this.panel1.TabIndex = 2;
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
            this.generateReportButton.TabIndex = 14;
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
            this.generateBarcodeButton.TabIndex = 13;
            this.generateBarcodeButton.Text = "Generate Barcode";
            this.generateBarcodeButton.UseVisualStyleBackColor = false;
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
            this.sellButton.TabIndex = 12;
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
            this.replenishStockButton.TabIndex = 11;
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
            this.addNewProductButton.TabIndex = 10;
            this.addNewProductButton.Text = "Add New Product";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 221);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Generate Barcode";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pathTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.fileNameTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.chooseFolderButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.barcodeTypeComboBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.barcodeNumberTextBox);
            this.panel3.Controls.Add(this.generateButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(144, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 325);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chosen Location:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.pathTextBox.Location = new System.Drawing.Point(155, 135);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(373, 35);
            this.pathTextBox.TabIndex = 9;
            this.pathTextBox.Text = "No Path Chosen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.fileNameTextBox.Location = new System.Drawing.Point(155, 176);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(373, 35);
            this.fileNameTextBox.TabIndex = 8;
            this.fileNameTextBox.Text = "Type Name";
            this.fileNameTextBox.Click += new System.EventHandler(this.fileNameTextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Save To:";
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.BackColor = System.Drawing.Color.CadetBlue;
            this.chooseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseFolderButton.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.chooseFolderButton.Location = new System.Drawing.Point(155, 94);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(373, 35);
            this.chooseFolderButton.TabIndex = 6;
            this.chooseFolderButton.Text = "Choose Folder";
            this.chooseFolderButton.UseVisualStyleBackColor = false;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barcode Type:";
            // 
            // barcodeTypeComboBox
            // 
            this.barcodeTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "EAN-13",
            "Code 128"});
            this.barcodeTypeComboBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.barcodeTypeComboBox.FormattingEnabled = true;
            this.barcodeTypeComboBox.Location = new System.Drawing.Point(155, 53);
            this.barcodeTypeComboBox.Name = "barcodeTypeComboBox";
            this.barcodeTypeComboBox.Size = new System.Drawing.Size(373, 35);
            this.barcodeTypeComboBox.TabIndex = 4;
            this.barcodeTypeComboBox.Text = "Choose Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode Number:";
            // 
            // barcodeNumberTextBox
            // 
            this.barcodeNumberTextBox.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold);
            this.barcodeNumberTextBox.Location = new System.Drawing.Point(155, 12);
            this.barcodeNumberTextBox.Name = "barcodeNumberTextBox";
            this.barcodeNumberTextBox.Size = new System.Drawing.Size(373, 35);
            this.barcodeNumberTextBox.TabIndex = 2;
            this.barcodeNumberTextBox.Text = "Type Number";
            this.barcodeNumberTextBox.Click += new System.EventHandler(this.barcodeNumberTextBox_Click);
            // 
            // BarcodeGenerator
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
            this.MinimizeBox = false;
            this.Name = "BarcodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox barcodeNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox barcodeTypeComboBox;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Button generateBarcodeButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button replenishStockButton;
        private System.Windows.Forms.Button addNewProductButton;
    }
}

