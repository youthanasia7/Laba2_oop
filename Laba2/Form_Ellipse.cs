using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Laba2
{
    public partial class Form_Ellipse : Form
    {
        private Ellipse ellipse;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Ellipse(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;
            ellipse = new Ellipse(pic, bmp, cmbbx);
        }

        private void Form_Ellipse_Load(object sender, EventArgs e)
        {

        }

        private void RectDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0, h = 0;
            try
            {
                x = int.Parse(valX.Text);
                y = int.Parse(valY.Text);
                w = int.Parse(valW.Text);
                h = int.Parse(valH.Text);
                
                ellipse.DeleteF(ellipse, true);
                ellipse = new Ellipse(x, y, w, h, pic, bmp, cmbbx);
                ellipse.Draw();
                cmbbx.Items.Add(ellipse.Name);

                RectDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewCord_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                ellipse.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewSize_Click(object sender, EventArgs e)
        {
            int w = 0, h = 0;
            try
            {
                w = int.Parse(newW.Text);
                h = int.Parse(newH.Text);
                ellipse.ChangeSizeTo(w, h);
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
    }
}
