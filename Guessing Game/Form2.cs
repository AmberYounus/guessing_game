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
    public partial class Form2 : Form
    {
        int n, count = 0;
        public string n1;

        public Form2()
        {
            InitializeComponent();
        }

        static Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            n += 3;
            count++;
            this.button1.Enabled = false;
            this.button1.Text = "3";
            this.button1.Text = Convert.ToString(random.Next(1, 15));
            if (count > 3){
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            if(n  > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n += 18;
            count++;
            this.button2.Enabled = false;
            this.button2.Text = "18";
            this.button2.Text = Convert.ToString(random.Next(8, 20));
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n += 20;
            count++;
            this.button3.Enabled = false;
            this.button3.Text = "20";
            this.button3.Text = Convert.ToString(random.Next(10, 20));
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n += 23;
            count++;
            this.button4.Enabled = false;
            this.button4.Text = "23";
            this.button4.Text = Convert.ToString(random.Next(9, 25));
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n += 3;
            count++;
            this.button5.Enabled = false;
            this.button5.Text = "3";
           
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button2.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n += 4;
            count++;
            this.button6.Enabled = false;
            this.button6.Text = "4";
            this.button6.Text = Convert.ToString(random.Next(3, 15));
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button2.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n += 2;
            count++;
            this.button7.Enabled = false;
            this.button7.Text = "2";
         
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button2.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n += 5;
            count++;
            this.button8.Enabled = false;
            this.button8.Text = "5";

            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button2.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n += 12;
            count++;
            this.button9.Enabled = false;
            this.button9.Text = "12";
  
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button2.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("Your Lose" + n1);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] values = { 10, 15, 21, 5, 14, 18 };
            int n1, n2, n3, n4, n5, n6;
            Random random = new Random();
            n1 = random.Next(values.Length);
            button1.Text = "";
            n2 = random.Next(values.Length);
            button2.Text = "";
            n3 = random.Next(values.Length);
            button3.Text = "";
            n4 = random.Next(values.Length);
            button4.Text = "";
            n5 = random.Next(values.Length);
            button5.Text = "";
            n6 = random.Next(values.Length);
            button6.Text = "";
           


        }

        private void button10_Click(object sender, EventArgs e)
        {
            count = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
        }
    }
}
