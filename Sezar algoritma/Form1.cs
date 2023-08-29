using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_algoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string veri = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray(); // ASCI tablosundaji tüm verileri yazmak gerek.  Bak burada normadle char[] karakterler = {'a','b'} benım boyle yapıp tüm karakterli yazmam gerekiyor ama daha kolayı var tochararry dediğim zaman tüm verilerin hepsine aynı adna ulaşabılıyorum . 
            foreach (char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman + 15 - 3).ToString(); // Burada += yazmamızın asıl sebebide eğer o artıyı oraya koymazsak sadece yazdıgımız son elemanın değerini 3 artırır ama bız hepsini istedıgımız ıcın oraya artı koymak zorundayız . 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string sifre = "";
            sifre = textBox2.Text;
            char[] karakterler2 = sifre.ToCharArray();
            foreach (char eleman in karakterler2)
            {
                textBox1.Text += Convert.ToChar(eleman - 15 + 3).ToString();
            }
        }
    }
}
