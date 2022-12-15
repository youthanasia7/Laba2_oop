using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form_Polygon : Form
    {
        int i;
        int numPoints;
        bool flag;
        Point[] points;
        Polygon polygon;

        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Polygon(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;
            polygon = new Polygon(pic, bmp, cmbbx);
            flag = false;
            i = 0;
            BDraw.Enabled = false;
            
        }

        private void BsetDots_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(dots_count.Text);
                if (n <= 2)
                {
                    MessageBox.Show("Укажите как минимум 3 точки");
                    numPoints = 0;
                }
                else
                {
                    i = 0;
                    numPoints = n;
                    points = new Point[numPoints];
                    BAddDots.Enabled = true;
                    BsetDots.Enabled = false;
                    dots_count.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BAddDots_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(setX.Text);
                int y = int.Parse(setY.Text);
                points[i].X = x;
                points[i].Y = y;
                i += 1;
                if (i == numPoints)
                {
                    BAddDots.Enabled = false;
                    BDraw.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            polygon.DeleteF(polygon, true);
            polygon = new Polygon(points, pic, bmp, cmbbx);
            polygon.Draw();
            cmbbx.Items.Add(polygon.Name);
            BDraw.Enabled = false;
        }
    }
}
