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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace number_game
{
    public partial class Form1 : Form
    {
        private int count = 10;
        private int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            count--;

            if (count == 0)
            {
                MessageBox.Show("You have exceeded the number of attempts. The number was " + number);
            }
            else if (guess < number)
            {
                MessageBox.Show("The number is greater than " + guess);
            }
            else if (guess > number)
            {
                MessageBox.Show("The number is less than A " + guess);
            }
            else
            {
                MessageBox.Show("Congratulations! You have guessed the number in " + count + " attempts.");
            }
            label4.Text = count.ToString();
        }
    }
}