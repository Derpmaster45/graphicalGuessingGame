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
            // validation code goes here
            // comparison code goes here
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numToGuess=random.Next(1, 19);
            int secondNumToGuess=random.Next(1, 19);
            int product = FindProduct(numToGuess, secondNumToGuess);
            lblProduct.Text = product.ToString();

            int secondNumberToGuess=random.Next(1, 19);
        }
    }
}
