using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinasıNormal
{
    public partial class Form1 : Form
    {
        float sayi1, sayi2, sonuc;
        int islem = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = sayi2 = sonuc = islem = 0;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi2 = float.Parse(textBox1.Text);
            if (islem == 1) {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
            } 
            else if (islem == 2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == 3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == 4)
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
