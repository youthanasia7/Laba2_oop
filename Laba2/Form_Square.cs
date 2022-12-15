using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form_Square : Form
    {

        private Square square;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;


        public Form_Square(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx;
            square = new Square(pic, bmp, cmbbx);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RectDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0;
            try
            {
                x = int.Parse(valX.Text);
                y = int.Parse(valY.Text);
                w = int.Parse(valW.Text);

                square.DeleteF(square, true);
                square = new Square(x, y, w, pic, bmp, cmbbx);
                square.Draw();
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
                square.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewSize_Click(object sender, EventArgs e)
        {
            int w = 0;
            try
            {
                w = int.Parse(newW.Text);
                square.ChangeSizeTo(w);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }
        /*******************************************(*******************************************************************/
        private void button1_Click_2(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void RectDraw_Click_1(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0;
            try
            {
                x = int.Parse(valX.Text);
                y = int.Parse(valY.Text);
                w = int.Parse(valW.Text);

                square.DeleteF(square, true);
                square = new Square(x, y, w, pic, bmp, cmbbx);
                square.Draw();
                cmbbx.Items.Add(square.Name);
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
                square.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewSize_Click_1(object sender, EventArgs e)
        {
            int w = 0;
            try
            {
                w = int.Parse(newW.Text);
                square.ChangeSizeTo(w);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void newW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newY_TextChanged(object sender, EventArgs e)
        {

        }

        private void newX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void valW_TextChanged(object sender, EventArgs e)
        {

        }

        private void valY_TextChanged(object sender, EventArgs e)
        {

        }

        private void valX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }

}
