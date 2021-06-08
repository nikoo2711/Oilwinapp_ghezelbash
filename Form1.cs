using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber_Ghezelbash
{
    public partial class Form1 : Form
    {
        Random randomGenerator = new Random();
        int value; 
        public Form1()
        {
            InitializeComponent();
            value = randomGenerator.Next(1, 100);
        }
        int counter = 0;
        private void GuessButon_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 7)
            {
                MessageBox.Show("Gameover");
                /*return*/;
            }
            int guess = int.Parse(NumbertextBox.Text);
            if (guess > value)
            {
                resultLable.Text = "Enter Lower Number";
            }
            else if (guess < value)
            {
                resultLable.Text="Enter Higher Number";
            }
            else
            {
                MessageBox.Show("you win:)))");
               
            }
            NumbertextBox.Text = string.Empty;
          
            CounteLable.Text = counter .ToString();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            counter = 0;
            value = randomGenerator.Next(1, 100);
            CounteLable.Text = counter.ToString();
        }
    }
}
