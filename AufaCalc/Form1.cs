using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count; 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
        }
       
        public void compute()
        {
            switch (count) //membuat operasi perhitungan
            {
                case 2:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 1:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 5:
                    ans = num = float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "*";
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "/";
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "-";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "+";
        }

        private void btnHasil_Click(object sender, EventArgs e) //Sama dengan
        {
            compute();
            label1.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e) //Clear
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
            textBox1.ForeColor = Color.Black;
            
        }

        private void btnCE_Click(object sender, EventArgs e) //Backspace Button
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

      
    }   
}
