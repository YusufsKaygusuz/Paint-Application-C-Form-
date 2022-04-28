using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Application
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        bool MouseDown;
        Point mouseDownLocation;

        public Form1()
        {
            InitializeComponent();
            MouseDown = false;
            pen = new Pen(Color.Black, trackBar1.Value);
            mouseDownLocation = new Point();

            graphics = panel1.CreateGraphics();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
            MouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseDown)
            {
                graphics.DrawLine(pen, mouseDownLocation, e.Location);
                mouseDownLocation = e.Location;
            }


        }

        private void LabelBasildi(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            pen.Color = clickedLabel.BackColor;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
    }
}
