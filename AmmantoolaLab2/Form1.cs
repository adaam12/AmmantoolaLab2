using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmantoolaLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            //This will close the program
          this.Close();
        }

        private void btnPicture_Click_Click(object sender, EventArgs e)
        {
            //this will show the picture
            picImage_Click.Show();
            lbltext.Hide();

        }

        private void btnReset_Click_Click(object sender, EventArgs e)
        {
            //this will clear the textboes and lable

            txtNumber.Clear();
            txtMultiplier.Clear();
            lblShowAnswer.Text = "";

            //this will put the cursor back on the first text box 

            txtNumber.Focus();

            
          
        }

        private void btnHide_Click_Click(object sender, EventArgs e)
        {
            //this will hide the image

            picImage_Click.Hide();

            // this will hide the data
            lbltext.Hide();
           
        }

        private void btnData_Click_Click(object sender, EventArgs e)
        {
            //this will display the information about maurituis beaches
            string lblTopic = "Maurituis Beaches";

            //this will hide the picture

            picImage_Click.Hide();

            // this will display the data

            lbltext.Show();
            lbltext.Text = "My topic is " + lblTopic + "\n\nMaurituis Clear warm colored blue turquoise water, and endless white beaches with coconut trees." +
                "Mauritius an ideal tropical dream beach holiday destination." +
                "\n\nMauritius Island offers the visitors a large variety of beautiful white sandy beaches and blue lagoons" +
                "Mauritius is said to be the paradise of the Indian Ocean." + "\n\n I love Maurituis i wish i could go back there.";



        }

        private void picImage_Click_Click(object sender, EventArgs e)
        {
            // this will show a message when click on the picture
            MessageBox.Show("I love Maurituis <3 ","Adaam Yassine Ammantoola");
        }

        private void btnCalculate_Click_Click(object sender, EventArgs e)
        {
            //this will do a multiplication of the two number that you input in the text box when the program run

            int Number = Convert.ToInt32(txtNumber.Text);   
            int Multiplier = Convert.ToInt32(txtMultiplier.Text);
            int Answer = Number * Multiplier;
            
            //this will display the asnwer 

            lblShowAnswer.Text = Convert.ToString(Answer);
            
        }
        //this button will show a message when clicked 
        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World" , "Yassine Adaam Ammantoola");
        }
    }
}
