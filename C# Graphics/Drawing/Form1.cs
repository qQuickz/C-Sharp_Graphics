using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        int x1 = 0;
        int y1 = 0;
        int countloop;
        int countloop2;
        int line = 200;
        int countvertline;
        int countvertline2;
        int total;
        int rect0 = 50;
        int rect1 = 330;
        int rect2 = 225;
        int rect3 = 225;
        int rectcount;
        int rectcount2;

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            countloop++;
            countloop2++;
            label1.Text = "Ellipse "+ countloop.ToString() +"/x";
            label2.Text = "Ellipse "+countloop2.ToString() +"/20";
            Graphics gg = panel1.CreateGraphics();
            Pen pp = new Pen(Color.Green);
            gg.DrawEllipse(pp, 50, 50, 100, 100);
            gg.DrawEllipse(pp, 200, 50, 5, 5);
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Red);
            x = x + 5;
            y = y + 5;
            if (x == 100 & y == 100 & countloop2 == 20)
            {
                x = 0;
                y = 0;
                countloop2 = 0;
                line = 200;
                countvertline2 = 0;
                rect0 = 50;
                rect1 = 330;
                rect2 = 225;
                rect3 = 225;
                rectcount2 = 0;
                g.Clear(Color.Black);
            }
            g.DrawEllipse(p, 50, 50, x, y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //reverse
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Red);
            x1 = x1 - 5;
            y1 = y1 - 5;
            if (x == 0 & y == 0)
            {
                x1 = 100;
                y1 = 100;
                g.Clear(Color.Black);            
            }
            g.DrawEllipse(p, 200, 50, x1, y1);
        }

        private void VertikalLine_Tick(object sender, EventArgs e)
        {
            Graphics ggg = panel1.CreateGraphics();
            Pen ppp = new Pen(Color.Green);
            line = line + 5;
            countvertline++;
            countvertline2++;
            ggg.DrawLine(ppp, 600, line, 0, line);
            label4.Text = "Vertikal Line " + countvertline.ToString() + "/x";
            label3.Text = "Vertikal Line " + countvertline2.ToString() + "/20";
        }

        private void TotalGraph_Tick(object sender, EventArgs e)
        {
            total = countloop + countvertline + rectcount;
            Text = "/Total_Graph/" + total.ToString();
        }

        private void HorizontalLine_Tick(object sender, EventArgs e)
        {
            ///50, 330, 200, 200
            rectcount++;
            rectcount2++;
            rect0 = rect0 + 5;
            rect1 = rect1 + 5;
            rect2 = rect2 - 10;
            rect3 = rect3 - 10;
            Graphics gggg = panel1.CreateGraphics();
            Pen pppp = new Pen(Color.Red);
            Pen ppppp = new Pen(Color.Green);
            gggg.DrawRectangle(ppppp, 150, 430, 25, 25);
            gggg.DrawRectangle(pppp, rect0, rect1, rect2, rect3);
            label6.Text = "Rectangle " + rectcount.ToString() + "/x";
            label5.Text = "Rectangle " + rectcount2.ToString() + "/20";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
