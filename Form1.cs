using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bresenham
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

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(textBox1.Text);
            int y0 = int.Parse(textBox2.Text);
            int xend = int.Parse(textBox4.Text);
            int yend = int.Parse(textBox3.Text);
            lineBres(x0, y0, xend, yend);
            void lineBres(int x0, int y0, int xEnd, int yEnd)
            {
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int x, y, p = (2 * dy) - dx;
                int twody = 2 * dy;
                int twodymindx = 2 * (dy - dx);
                var aBrush = Brushes.Black;
                var g = panel1.CreateGraphics();
              

                if (x0 > xEnd)
                {
                    x = xEnd;
                    y = yEnd;
                    xEnd = x0;
                }
                else
                {

                    x = x0; y = y0;
                }
                //arr

                g.FillRectangle(aBrush,x, y, 2, 2);
                while (x < xEnd)

                {

                    x++;
                    if (p < 0)
                    {
                        p = p + twody;
                    }
                    else
                    {
                        y++;
                        p = p + twodymindx;
                    }
                    g.FillRectangle(aBrush, x, y, 2, 2);

                }


               
            }

           
          


        }
    }
}
