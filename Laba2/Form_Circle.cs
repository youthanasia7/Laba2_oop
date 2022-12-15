using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Laba2
{
    public partial class Form_Circle : Form
    {
        private Circle circle;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Circle(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;
            circle = new Circle(pic, bmp, cmbbx);
        }

        private void RectDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, r = 0;
            try
            {
                x = int.Parse(valX.Text);
                y = int.Parse(valY.Text);
                r = int.Parse(valW.Text);
                circle.DeleteF(circle, true);
                circle = new Circle(x, y, r * 2, pic, bmp, cmbbx);
                circle.Draw();
                cmbbx.Items.Add(circle.Name);
                RectDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BNewCord_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                circle.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewSize_Click(object sender, EventArgs e)
        {
            int r = 0;
            try
            {
                r = int.Parse(newW.Text);
                circle.ChangeRadiusTo(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
