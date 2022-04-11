using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İç Anadolu Bölgesi");
            comboBox1.Items.Add("Ege Bölgesi");
            comboBox1.Items.Add("Marmara Bölgesi");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "İç Anadolu Bölgesi")
            {
                comboBox2.Items.Add("ANKARA");
                comboBox2.Items.Add("KONYA");
                comboBox2.Items.Add("KIRIKKALE");
            }
            if (comboBox1.Text == "Ege Bölgesi")
            {
                comboBox2.Items.Add("İZMİR");
                comboBox2.Items.Add("MUĞLA");
                comboBox2.Items.Add("AYDIN");
            }
            if (comboBox1.Text == "MARMARA")
            {
                comboBox2.Items.Add("İSTANBUL");
                comboBox2.Items.Add("KOCAELİ");
                comboBox2.Items.Add("BURSA");
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (comboBox2.Text == "İZMİR")
            {
                comboBox3.Items.Add("BUCA");
                comboBox3.Items.Add("KONAK");
            }
            if (comboBox2.Text == "MUĞLA")
            {
                comboBox3.Items.Add("BODRUM");
                comboBox3.Items.Add("DATÇA");
                comboBox3.Items.Add("FETHİYE");
                comboBox3.Items.Add("DALAMAN");
            }
            if (comboBox2.Text == "AYDIN")
            {
                comboBox3.Items.Add("DİDİM");
                comboBox3.Items.Add("EFELER");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"BÖLGE: {comboBox1.Text} ŞEHİR: {comboBox2.Text} İLÇE: {comboBox3.Text}");
            this.Close();
        }
    }
}
