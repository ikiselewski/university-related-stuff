using System;
using System.Windows.Forms;

namespace gaymersRiseUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] a = text.Split(' ', '\n');
            int m = int.Parse(a[0]);
            richTextBox2.Text = "пиздец, максимальное значение: ";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
