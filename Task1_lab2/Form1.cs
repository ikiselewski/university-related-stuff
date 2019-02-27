using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] a = text.Split(' ', '\n');
            int m = int.Parse(a[0]);
            richTextBox2.Text = "максимальное значение: ";
            int max = 0;
            for (int i = 0; i < 6; i++)
            {
                if (int.Parse(a[i]) > int.Parse(a[max]))
                {
                    max = i;
                }
            }
            richTextBox2.AppendText("a[" + max + "] " + "= " + a[max]);
        }
    }
}
