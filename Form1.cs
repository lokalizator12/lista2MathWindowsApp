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

            string a = textBox1.Text;

            int a1 = 0; int volume = 0; int area = 0;
            try
            {
                a1 = Convert.ToInt32(a);

                volume = (int)(Math.Pow(a1, 3));

                area = (6 * (a1 * a1));
                label2.Text = "Result: \nvolume - " + volume.ToString() + "\nCube surface area - " + area.ToString();
            }
            catch (Exception er)
            {
                textBox1.Text = "";
                label2.Text = "Error. Enter only INT numbers";
                Console.WriteLine(er.Message);
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
            label5.Text = "Result: " + c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception err)
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
                label9.Text = "Result: " + s;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int max = 0, x ,y ,intS;
           
            string s = Convert.ToString(textBox5.Text);

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
            int intS = 0;
            int max = 0;
            try
            {
                intS = Convert.ToInt32(textBox5.Text);
            }
            catch (Exception err)
            {
                label12.Text = "Error.Enter only INT numbers";
            }
            if (intS > max)
            {
                max = intS;
                label12.Text = max.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox6.Text);
            }
            catch (Exception err)
            {
                label15.Text = "Error.Enter only INT numbers";
            }
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    int result = i * j;
                  //  listBox1.Text ="| " + i + "*" + j + "=" + result + " |";
                }
                
            }
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}



