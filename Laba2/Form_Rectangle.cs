using System;
using System.Drawing;
using System.Windows.Forms;
namespace Laba2
{
    public partial class Form_Rectangle : Form
    {
        private MeinLib.Rectangle rect;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Rectangle(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;

            rect = new MeinLib.Rectangle(pic, bmp, cmbbx);
        }

        private void Form_Rectangle_Load(object sender, EventArgs e)
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
                rect.DeleteF(rect, true);
                rect = new MeinLib.Rectangle(x, y, w, h, pic, bmp, cmbbx);
                rect.Draw();

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
                rect.MoveTo(x, y);
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
                rect.ChangeSizeTo(w, h);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
/**************************************************************************************/
        private void RectDraw_Click_1(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0, h = 0;
            try
            {
                x = int.Parse(valX.Text);
                y = int.Parse(valY.Text);
                w = int.Parse(valW.Text);
                h = int.Parse(valH.Text);
                rect.DeleteF(rect, true);
                rect = new MeinLib.Rectangle(x, y, w, h, pic, bmp, cmbbx);
                rect.Draw();
                cmbbx.Items.Add(rect.Name);
                RectDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewCord_Click_1(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                rect.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewSize_Click_1(object sender, EventArgs e)
        {
            int w = 0, h = 0;
            try
            {
                w = int.Parse(newW.Text);
                h = int.Parse(newH.Text);
                rect.ChangeSizeTo(w, h);
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
