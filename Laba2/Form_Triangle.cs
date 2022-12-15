using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form_Triangle : Form
    {
        Triangle tg;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Triangle(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;
            tg = new Triangle(pic, bmp, cmbbx);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(setX1.Text);
                int y1 = int.Parse(setY1.Text);
                int x2 = int.Parse(setX2.Text);
                int y2 = int.Parse(setY2.Text);
                int x3 = int.Parse(setX3.Text);
                int y3 = int.Parse(setY3.Text);
                Point pt1 = new Point(x1, y1);
                Point pt2 = new Point(x2, y2);
                Point pt3 = new Point(x3, y3);
                Point[] points = { pt1, pt2, pt3 };
                tg.DeleteF(tg, true);
                tg = new Triangle(points, pic, bmp, cmbbx);
                tg.Draw();
                cmbbx.Items.Add(tg.Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
