using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 + sayi2;

            textBox3.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 - sayi2;

            textBox3.Text = Convert.ToString(toplam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 * sayi2;

            textBox3.Text = Convert.ToString(toplam);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 / sayi2;

            textBox3.Text = Convert.ToString(toplam);
        }

       
    }
}
