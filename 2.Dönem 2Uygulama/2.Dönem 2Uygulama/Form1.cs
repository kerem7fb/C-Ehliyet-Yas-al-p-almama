using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Dönem_2Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas, dtarihi;
            string isim;
            isim = textBox1.Text;
            dtarihi = Convert.ToInt32(textBox2.Text);
            yas = 2023 - dtarihi;
            if (yas > 17)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/2.Dönem 2Uygulama/tik.png");
                MessageBox.Show(isim + " Ehliyet Alabilirsiniz");

            }
            else 
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/2.Dönem 2Uygulama/false.png");
                MessageBox.Show(isim + " Yaşınız Tutmuyor");
            }


        }
    }
}
