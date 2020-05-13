using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcodes
{
    public class GlobalMethods 
    {
        public GlobalMethods() { 
        
        }

        public void addNewProductSwitch() {

            AddNewProduct nextForm = new AddNewProduct();
            Form.ActiveForm.Hide();
            nextForm.Show();
        }
        public void generateBarcodeSwitch() {
            BarcodeGenerator nextForm = new BarcodeGenerator();
            Form.ActiveForm.Hide();
            nextForm.Show();
        }
        public void quitApplication() {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
