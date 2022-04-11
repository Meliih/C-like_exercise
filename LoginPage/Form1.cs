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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "aa" && textBox2.Text == "bb")
            {
                this.timer1.Stop();
                this.Hide();
                MessageBox.Show("GİRİŞ BAŞARILI OLDU");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Parola Yanlış girildi. 10 sn içerisinde kullanıcı ve parolayı yeniden giriniz");
              
                this.timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1); // 1 saniye attırarak ilerle

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("SÜRENİZ DOLDU");
                //this.Hide();//sayfayı kapat gizle
                this.Close();
            }

        }
    }
}
