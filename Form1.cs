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

            szescian();
        }

        private void szescian()
        {
            listBox1.Items.Clear();
            string a = textBox1.Text;

            int a1 = 0; int volume = 0; int area = 0;
            try
            {
                a1 = Convert.ToInt32(a);
                volume = (int)(Math.Pow(a1, 3));
                if (a1 > 0)
                {
                    area = (6 * (a1 * a1));
                    listBox1.Items.Add("volume - " + volume.ToString());
                    listBox1.Items.Add("Cube surface area - " + area.ToString());
                }
                else
                {
                    MessageBox.Show("1 Zadanie - error. Enter only a > 0");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error.Enter only INT numbers");

            }
        }

        private void suma()
        {
            listBox1.Items.Clear();
            int a = 0; int b = 0; int c = 0;
            Random random = new Random();
            int sum = 0;

            try
            {
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
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
                listBox1.Items.Add("Result: " + c.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show("Error. Enter only INT numbers");
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
            suma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = "";
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox4.Text);
                if (a > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        if (a % i == 0)
                        {
                            s += i + " ";
                        }

                    }
                    listBox1.Items.Add("Result: " + s);
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
            listBox1.Items.Clear();
            int max = 0;
            foreach (int b in list)
            {
                if (b > max)
                {
                    max = b;
                }

            }
            listBox1.Items.Add(max);
            list.Clear();

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

        private void listBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



