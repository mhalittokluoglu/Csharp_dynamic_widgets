using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Table_01
{
    public partial class Form1 : Form
    {
        public static int xa, xb, xc, xd;
        public static int[] y = new int[4];
        public static int[] ya = new int[4];
        public static int[] yb = new int[4];
        public static int[] pos = new int[4];
        public static int i;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            a0.SetBounds(xa, y[0], 100, 20);
            b0.SetBounds(xb, y[0], 100, 20);
            c0.SetBounds(xc, y[0], 100, 20);
            d0.SetBounds(xd, y[0], 100, 20);
            a1.SetBounds(xa, y[1], 100, 20);
            b1.SetBounds(xb, y[1], 100, 20);
            c1.SetBounds(xc, y[1], 100, 20);
            d1.SetBounds(xd, y[1], 100, 20);
            a2.SetBounds(xa, y[2], 100, 20);
            b2.SetBounds(xb, y[2], 100, 20);
            c2.SetBounds(xc, y[2], 100, 20);
            d2.SetBounds(xd, y[2], 100, 20);
            a3.SetBounds(xa, y[3], 100, 20);
            b3.SetBounds(xb, y[3], 100, 20);
            c3.SetBounds(xc, y[3], 100, 20);
            d3.SetBounds(xd, y[3], 100, 20);
            for (i = 0; i < 4; i++)
            {
                if (y[i] < yb[i])
                {
                    y[i]++;
                }
                if (y[i] > yb[i])
                {
                    y[i]--;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change(pos[0], pos[1], 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change(pos[1], pos[2], 1, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change(pos[2], pos[3], 2, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a0.Text = "1st row";
            b0.Text = "1st row";
            c0.Text = "1st row";
            d0.Text = "1st row";
            a1.Text = "2nd row";
            b1.Text = "2nd row";
            c1.Text = "2nd row";
            d1.Text = "2nd row";
            a2.Text = "3rd row";
            b2.Text = "3rd row";
            c2.Text = "3rd row";
            d2.Text = "3rd row";
            a3.Text = "4th row";
            b3.Text = "4th row";
            c3.Text = "4th row";
            d3.Text = "4th row";
            xa = 100;
            xb = 230;
            xc = 360;
            xd = 490;
            y[0] = 120;
            y[1] = 150;
            y[2] = 180;
            y[3] = 210;
            ya[0] = 120;
            ya[1] = 150;
            ya[2] = 180;
            ya[3] = 210;
            yb[0] = 120;
            yb[1] = 150;
            yb[2] = 180;
            yb[3] = 210;
            pos[0] = 0;
            pos[1] = 1;
            pos[2] = 2;
            pos[3] = 3;
        }
        private void flippos(int j, int k)
        {
            int pass;
            pass = pos[j];
            pos[j] = pos[k];
            pos[k] = pass;
        }
        private void change(int j, int k, int l, int m)
        {
            yb[j] = ya[m];
            yb[k] = ya[l];
            flippos(l, m);
        }
    }
}
