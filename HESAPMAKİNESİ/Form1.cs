using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAPMAKİNESİ
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" )
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0 )
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
            
        }

        private void button16_Click(object sender, EventArgs e) // eşittir
        {
            y = Convert.ToDouble(textBox1.Text);


            if (islem == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
            if (islem == "us")
            {
                textBox1.Text = Convert.ToString(Math.Pow(x,y));
                label1.Text = "";
            }
            




        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double bolux = Convert.ToDouble(textBox1.Text);
            bolux = 1/bolux;
            textBox1.Text = Convert.ToString(bolux);
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int fact = Convert.ToInt32(textBox1.Text);
            int a = 1;
            if(fact == 0)
            {
                fact = 1;
                textBox1.Text = Convert.ToString(fact);
            }
            else if (fact > 0)
            {
                for (int i = 1; i <= fact; i++)
                {
                    a = a * i;
                }
                textBox1.Text = Convert.ToString(a);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            if (x >= 0)
            {
                textBox1.Text = Convert.ToString(x);

            }
            else
            {
                textBox1.Text = Convert.ToString(-x);

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "us";
            label1.Text = textBox1.Text + "^";
            textBox1.Text = "0";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = "10^";

            if (x == 0)
            {
                textBox1.Text = Convert.ToString("1");
            }
            else if (x > 0)
            {
                textBox1.Text = Convert.ToString(Math.Pow(10,x));
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);

            if (x == 0)
            {
                textBox1.Text = Convert.ToString("Geçersiz giriş");
            }
            else
            {
                textBox1.Text = Convert.ToString(Math.Log10(x));
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);

            if (x == 0)
            {
                textBox1.Text = Convert.ToString("Geçersiz giriş");
            }
            else
            {
                textBox1.Text = Convert.ToString(Math.Log(x));
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            a = -a;
            textBox1.Text = Convert.ToString(a);
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(x) + ",";
            }
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }




    }
}
