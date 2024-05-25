using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int durum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int s1, s2, s3, s4;
            s1 = rast.Next(1,5);
            s2 = rast.Next(1,5);
            s3 = rast.Next(1,5);
            s4 = rast.Next(1,5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            //s1
            if(textBox1.Text == label1.Text )
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            //s2
            if(textBox2.Text == label2.Text )
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor= Color.Red;
            }

            //s3
            if (textBox3.Text == label3.Text )
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor= Color.Red;
            }

            //s4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            
            if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green
               || textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green && textBox4.BackColor == Color.Green
               || textBox1.BackColor == Color.Green && textBox3.BackColor == Color.Green && textBox4.BackColor == Color.Green
               || textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green && textBox4.BackColor == Color.Green)
            {
                this.BackColor = Color.Yellow;
                durum++;
                textBox1.BackColor = Color.White;   
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White; 
                textBox4.BackColor = Color.White;
            }

            label6.Text = durum.ToString();
            
            


            if (textBox1.BackColor == Color.Red && textBox2.BackColor == Color.Red || textBox1.BackColor == Color.Red && textBox3.BackColor == Color.Red 
                || textBox1.BackColor == Color.Red && textBox4.BackColor== Color.Red || textBox2.BackColor== Color.Red && textBox3.BackColor == Color.Red 
                || textBox2.BackColor == Color.Red && textBox4.BackColor == Color.Red || textBox3.BackColor == Color.Red && textBox4.BackColor == Color.Red)
            {
                this.BackColor= Color.DarkTurquoise;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text = "";
            textBox2.BackColor = Color.White;
            textBox2.Text = "";
            textBox3.BackColor = Color.White;
            textBox3.Text = "";
            textBox4.BackColor = Color.White;
            textBox4.Text = "";

            textBox1.Focus();
        }

        private void oyununKurallarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-4 (dahil) arasında istediğiniz sayıları kutulara girniz.Ardından çekiliş btonunu kullanarak rastgele rakamları tahmin etmeye çalışınız." +
                "Temizle butonunu kullanrak tekrar rakam girişi yapabilirsiniz.");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
