using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    
    public partial class frmMain : Form
    {
         

        public frmMain()
        {
            InitializeComponent();
            Random rnd = new Random();
            int numToGuess = rnd.Next(1, 19);
            int secondNumToGuess = rnd.Next(1, 19);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // this was an accidental event creation. 
            
        }
        private int FindProduct(int num1, int num2)
        {
            return num1 * num2;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
             Random rnd = new Random();
         int numToGuess = rnd.Next(1, 19);
         int secondNumToGuess = rnd.Next(1, 19);
        int product=FindProduct(numToGuess, secondNumToGuess);
            lblProduct.Text = product.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int guess1 = Convert.ToInt32(txtGuess1.Text);
            int guess2 = Convert.ToInt32(txtGuess2.Text);
           int guessProduct= FindProduct(guess1, guess2);
            int intialProduct = Convert.ToInt32(lblProduct.Text);
            int successfulSubmitCount =0;
            if(guessProduct == intialProduct) 
            {
                MessageBox.Show("Congratulations, you guessed the numbers correct.","You Win",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                successfulSubmitCount++;
            }
            else
            {
                MessageBox.Show("Incorrect. Please Try Again","Wrong Answer",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Random random = new Random();
            int numToGuess = random.Next(1, 19);
            int secondNumToGuess = random.Next(1, 19);
            int product = FindProduct(numToGuess, secondNumToGuess);
            lblProduct.Text = product.ToString();

            int secondNumberToGuess = random.Next(1, 19);
            txtGuess1.Text = "";
            txtGuess2.Text = "";
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numToGuess=random.Next(1, 19);
            int secondNumToGuess=random.Next(1, 19);
            int product = FindProduct(numToGuess, secondNumToGuess);
            lblProduct.Text = product.ToString();

            int secondNumberToGuess=random.Next(1, 19);
            txtGuess1.Text = "";
            txtGuess2.Text = "";
        }

        private void txtGuess1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = "";
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                // leave this code block empty, error should not arise when numbers are entered

            }
            else 
            {
                message = "Numbers are required in this field.";
                MessageBox.Show(message,"Unexpected answer",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                // handle error
                e.Handled = true;
            }
        }

        private void txtGuess2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = "";
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                // leave this code block empty, error should not arise when numbers are entered

            }
            else
            {
                message = "Numbers are required in this field.";
                MessageBox.Show(message, "Unexpected answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                // handle error
                e.Handled = true;
            }
        }
    }
}
