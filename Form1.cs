using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista2
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string a = textBox1.Text;

            int a1 = 0; int volume = 0; int area = 0;
            try
            {
                a1 = Convert.ToInt32(a);

                volume = (int)(Math.Pow(a1, 3));
                area = (6 * (a1 * a1));
            }
                else
                {
                    MessageBox.Show("1 Zadanie - error. Enter only a > 0");
                }
            }
            catch (Exception er)
            {
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = 0; int b = 0; int c = 0;
            Random random = new Random();
            int sum = 0;

            try
            {
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);


            }
            catch (Exception err)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                label5.Text = "Error. Enter only INT numbers";
                Console.WriteLine(err.Message);
            }

            sum = a + b;
            if (sum <= 10 && sum > 0)
            {
                c = (int)(Math.Pow(a, 3) * Math.Pow(b, 3));
            }
            else if (sum >= 10 && sum <= 100)
            {
                c = sum;
            }
            else if (sum > 100)
            {
                c = a - b;
            }
            else if (sum <= 0)
            {
                c = random.Next();
            }
            else
            {
                c = 0;
            }
        }
            catch (Exception err)
            {
                MessageBox.Show("Error. Enter only INT numbers");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = "";
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox4.Text);
            {
                textBox4.Text = "";
                label9.Text = "Error.Enter only INT numbers";
            }
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    s += i + " ";
                }
            }
                    listBox1.Items.Add(s);
        }
                else
                {
                    MessageBox.Show("Error.Enter only A > 0");

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error.Enter only INT numbers and A > 0");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            do
            {
                if (s[i] == '0')
                { break; }
                x = s[i];
                y = x - '0';
                max = Math.Max(max, y);
                i++;
            } while (true);
             label12.Text = Convert.ToString(max);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception err)
            {
            }

            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox6.Text);
            {
                label15.Text = "Error.Enter only INT numbers";
            }
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    int result = i * j;
                }
            catch (Exception err)
            {
                
                MessageBox.Show("Error.Enter only INT numbers");
            }

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}



