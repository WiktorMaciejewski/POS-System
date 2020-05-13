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
    public partial class AddNewProduct : Form
    {


        GlobalMethods gm = new GlobalMethods();
        public AddNewProduct()
        {
            InitializeComponent();
            addNewProductButton.Enabled = false;
            addNewProductButton.BackColor = Color.Gray;
            
        }

        private void generateBarcodeButton_Click(object sender, EventArgs e)
        {
            gm.generateBarcodeSwitch();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            gm.quitApplication();
        }
    }
}
