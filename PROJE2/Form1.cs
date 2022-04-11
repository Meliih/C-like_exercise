using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            int count = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                textBox2.Text = "ASAL SAYI ";
            }
            else
            {
                textBox2.Text = "ASAL SAYI DEGİLDİR";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox2.Text = Convert.ToString(karekok);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fact = Convert.ToInt32(textBox1.Text);
            int a = 1;
            if (fact < 20)
            {


                if (fact == 0)
                {
                    fact = 1;
                    textBox2.Text = Convert.ToString(fact);
                }
                else if (fact > 0)
                {
                    for (int i = 1; i <= fact; i++)
                    {
                        a = a * i;
                    }
                    textBox2.Text = Convert.ToString(a);
                }
            }
            else
            {
                MessageBox.Show("Bit Dışına Çıktı Sayı");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
