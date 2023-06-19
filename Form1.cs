using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //This method will retrieve the data entered in the textbox and store the data in the properties of the
        //Cellphone class 
        //The variable is an object that is the connection to the Cellphone class
        //When it is called it will retrieve the data from the properties
        private void GetPhoneData(Cellphone phone)
        {
            //variable to store the price
            decimal price;

            //will store the data that was entered in the textbox to the propeties (Brand, Model, and Price) which will then be stored in the
            //constructor
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            /* Try Parse will convert the decimal to a string
             * The data that is entered in the price textbox will be store as the value for price
             * That value will then be saved in the Price property
             * If the data is not a number then a message box will appear stating the data enter is an invalid price
             */
            if(decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid price");
            }
        }
        /*Whe the create Object button is clicked the data from the cellphone class is retrieve and displayed in 
         * the labels.
         */
        private void createObjectButton_Click(object sender, EventArgs e)
        {
           //This object gives access to the data that was stored in the Cellphone class
           Cellphone myPhone = new Cellphone();
            //The method is called to retrieve the data that was stored in the properties
            GetPhoneData(myPhone);

            //The label will display the data that is stored in the properties
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            PriceLabel.Text = myPhone.Price.ToString("c"); //"c" will give currency
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This closes the program.
            this.Close();
        }
    }
}
