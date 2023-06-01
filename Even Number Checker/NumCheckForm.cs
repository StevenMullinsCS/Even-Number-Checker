using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class NumCheckForm : Form
    {
        
        ulong num;
        public NumCheckForm()
        {
            InitializeComponent();
        }

        

        private void txtbox_userInput_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
            if (e.KeyChar == 13)
            {

                try
                {
                    // Takes in value from Textbox
                    num = ulong.Parse(txtbox_userInput.Text);

                    // Gets rid of annoying windows error sound.
                    e.Handled = true;

                    // Performs a mod function to determine whether the value is odd or even.
                    if (num % 2 == 0)
                    {
                        // Displays yes if number is Even
                        lbl_primeResult.Text = "Yes!";
                    }
                    else
                        // Displays No if number is odd.
                        lbl_primeResult.Text = "No.";
                }
                // Prevents a string from being input into the text box.
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input. Please input a positive number less than 18,446,744,073,709,551,615.");
                }
                //Prevents a negative value or value outside of the bounds of a ulong from being entered.
                catch (OverflowException)
                {
                    MessageBox.Show("Invalid Input. Please input a positive number less than 18,446,744,073,709,551,615.");
                }
            }
        }
    }
}
