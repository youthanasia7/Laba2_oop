using MeinLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form_Plane : Form
    {
        private Plane plane;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public Form_Plane(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            this.cmbbx = cmbbx; 
            plane = new Plane(pic, bmp, cmbbx);

        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(setX.Text);
                int y = int.Parse(setY.Text);
                plane.DeleteF(plane, true);
                plane = new Plane(x, y, pic, bmp, cmbbx);
                plane.Draw();
                cmbbx.Items.Add(plane.Name);
                BDraw.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }
    }
}
