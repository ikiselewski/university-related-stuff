using System ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int n = 20;
            float a = 25f, b = 50f, step;
            float x, y;
            step = (b - a) / n;
            int xc = this.Width / 2;
            int yc = this.Height / 2;
            Graphics gr = e.Graphics;
            gr.TranslateTransform(xc,yc);
            gr.DrawLine(new Pen(Color.Black, 2.0f), 0, -200, 0, 200);
            gr.DrawLine(new Pen(Color.Black,2.0f),200,0,-200,0);
            for(float i = a;i<=b;i += step)
            {
                x = i;
                y =(float) Math.Sqrt(i+1) - 1/i ;
                gr.DrawEllipse(new Pen(Color.Red, 0.5f),x,-y,1,1);
                

            }
            
        }
    }
}
