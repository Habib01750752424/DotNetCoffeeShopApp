using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName = "";
            string contactNo = "";
            string address = "";
            string order = "";
            int quantity;
            double coffeCost;


            customerName = customerNameTextBox.Text;
            contactNo = contactNoTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;

            
            try
            {
                quantity = Convert.ToInt32(quantityTextBox.Text);
                if (order == "Black-120")
                {
                    coffeCost = quantity * 120;
                }
                else if (order == "Cold-100")
                {
                    coffeCost = quantity * 100;
                }
                else if (order == "Hot-90")
                {
                    coffeCost = quantity * 90;
                }
                else
                {
                    coffeCost = quantity * 80;
                }

                
                storeRichTextBox.Text = "Customer Name:  " + customerName+ "\nContact NO:  " + contactNo+ 
                    "\nOder:  " + order+ "\nUnit Price:  " + coffeCost / quantity + "\nTotal Price:  "
                    + Convert.ToString(coffeCost);

                customerNameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                contactNoTextBox.Text = "";
                quantityTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Quantity field required  numeric value: ");
                quantityTextBox.Text = "";
            }
        }
    }
}
