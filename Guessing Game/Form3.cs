using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form3 : Form
    {
     
        int b, count = 0;
        public string b1;

        public Form3()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            b += 6;
            count++;
            this.button2.Enabled = false;
            this.button2.Text = "6";
            this.button2.Text = Convert.ToString(random.Next(5, 21));
            if (count > 1 )
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b += 9;
            count++;
            this.button3.Enabled = false;
            this.button3.Text = "9";
            this.button3.Text = Convert.ToString(random.Next(7, 19));
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b += 12;
            count++;
            this.button4.Enabled = false;
            this.button4.Text = "12";
            this.button4.Text = Convert.ToString(random.Next(10, 27));
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b += 14;
            count++;
            this.button1.Enabled = false;
            this.button1.Text = "14";
    
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button1.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b += 2;
            count++;
            this.button6.Enabled = false;
            this.button6.Text = "2";
            this.button6.Text = Convert.ToString(random.Next(1, 17));
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button1.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b += 3;
            count++;
            this.button1.Enabled = false;
            this.button1.Text = "3";
      
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if(b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("Your Lose" + b1);
                }

            }
           
        }
    }
}
