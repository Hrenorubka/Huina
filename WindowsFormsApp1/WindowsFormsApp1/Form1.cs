using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /*
            Pen MyPen = new Pen(Brushes.Black);
            //e.Graphics.DrawLine(MyPen, new PointF(100, 100), new PointF(100, 200));
            e.Graphics.DrawEllipse(MyPen, new RectangleF(200, 50, 100, 200));
            e.Graphics.DrawEllipse(MyPen, new RectangleF(130, 230, 100, 100));
            e.Graphics.DrawEllipse(MyPen, new RectangleF(270, 230, 100, 100));*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
            */
            
            System.Drawing.Pen MyPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Graph;
            Graph = this.pictureBox1.CreateGraphics();

            //Graph.DrawRectangle(MyPen, new Rectangle(10, 10, 100, 100));
            /*Graph.DrawEllipse(MyPen, new RectangleF(200, 50, 100, 200));
            Graph.DrawEllipse(MyPen, new RectangleF(130, 230, 100, 100));
            Graph.DrawEllipse(MyPen, new RectangleF(270, 230, 100, 100));*/
            Graph.DrawPie(MyPen, new RectangleF(270, 230, 100, 100), 100, 100);
            MyPen.Dispose();
            Graph.Dispose();
            this.pictureBox1.Visible = true;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
