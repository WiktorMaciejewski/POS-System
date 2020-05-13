using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcodes
{
    public partial class BarcodeGenerator : Form
    {
        
        String savePath = "";
        GlobalMethods gm = new GlobalMethods();
        //Populate Combo Box and set size mode to zoom
        public BarcodeGenerator()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            barcodeTypeComboBox.Items.Add("EAN-13");
            barcodeTypeComboBox.Items.Add("Code 128");
            generateBarcodeButton.Enabled = false;
            generateBarcodeButton.BackColor = Color.Gray;


        }
        //Generates and saves the barcode
        private void generateButton_Click(object sender, EventArgs e)
        {
            Bitmap image = convertFontToImage(barcodeNumberTextBox.Text, barcodeTypeComboBox.SelectedItem.ToString());
            image.Save(savePath + '\\' + fileNameTextBox.Text + ".bmp");
            MessageBox.Show("Barcode Image Saved To" + savePath + '\\' + fileNameTextBox.Text + ".bmp");
            pictureBox1.Image = image;
        }
        //Converts the barcode font into a BMP image 
        public static Bitmap convertFontToImage(string barcodeValue, string barcodeType)
        {

            int getWidth = 0;
            int getHeight = 0;
            
            Bitmap img = new Bitmap(1, 1);
            SolidBrush brush = new SolidBrush(Color.Black);

             

            Graphics graphics = Graphics.FromImage(img);

            Font font = new Font(barcodeType, 60);

            getWidth = (int)graphics.MeasureString(barcodeValue, font).Width;
            getHeight = (int)graphics.MeasureString(barcodeValue, font).Height;

            img = new Bitmap(img, new Size(getWidth,getHeight));

            graphics = Graphics.FromImage(img);
            graphics.Clear(Color.White);
            graphics.DrawString(barcodeValue, font, brush, 0,0);

            

            return img;
        }
      

        //Quit button functionality
        private void quitButton_Click(object sender, EventArgs e)
        {
            gm.quitApplication();
        }
        //Choose folder to save barcode
        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            if (folderBrowse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                savePath = folderBrowse.SelectedPath;
                pathTextBox.Text = savePath;

            }
        }
        //Clear text box when clicked
        private void barcodeNumberTextBox_Click(object sender, EventArgs e)
        {
            barcodeNumberTextBox.Clear();
        }
        //Clear text box when clicked
        private void fileNameTextBox_Click(object sender, EventArgs e)
        {
            fileNameTextBox.Clear();
            
        }

        

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            gm.addNewProductSwitch();
        }

        
    }
}
