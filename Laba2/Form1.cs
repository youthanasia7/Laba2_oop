using MeinLib;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_Rectangle_Click(object sender, EventArgs e)
        {
            Form_Rectangle Rect = new Form_Rectangle(pictureBox1, bitmap, B_Rectangle, comboBox1);
            
            Rect.Show();
            B_Rectangle.Enabled = false;
        }

        private void B_Square_Click(object sender, EventArgs e)
        {
            Form_Square Square = new Form_Square(pictureBox1, bitmap, B_Square, comboBox1);
            Square.Show();
            B_Square.Enabled = false;
        }

        private void B_Ellipse_Click(object sender, EventArgs e)
        {
            Form_Ellipse Ellipse = new Form_Ellipse(pictureBox1, bitmap, B_Ellipse, comboBox1);
            Ellipse.Show();
            B_Ellipse.Enabled = false;
        }

        private void B_Circle_Click(object sender, EventArgs e)
        {
            Form_Circle Circle = new Form_Circle(pictureBox1, bitmap, B_Circle, comboBox1);
            Circle.Show();
            B_Circle.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Flist.figures.Count() > 0)
            {
                Counters.Reset();
                Flist.figures[0].Clear();
                Flist.figures.Clear();
                comboBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                Flist.figures[comboBox1.SelectedIndex].DeleteF(Flist.figures[comboBox1.SelectedIndex], true);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.SelectedItem = null;
            }
        }

        private void B_Move_Click(object sender, EventArgs e)
        {
            Form_Move move = new Form_Move(Flist.figures[comboBox1.SelectedIndex], B_Move);
            move.Show();
            B_Move.Enabled = false;

        }

        private void B_Polygon_Click(object sender, EventArgs e)
        {
            Form_Polygon Polygon = new Form_Polygon(pictureBox1, bitmap, B_Polygon, comboBox1);
            Polygon.Show();
            B_Polygon.Enabled = false;
        }

        private void B_Triangle_Click(object sender, EventArgs e)
        {
            Form_Triangle Triangle = new Form_Triangle(pictureBox1, bitmap, B_Triangle, comboBox1);
            Triangle.Show();
            B_Triangle.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Plane Plane = new Form_Plane(pictureBox1, bitmap, B_Plane, comboBox1);
            Plane.Show();
            B_Plane.Enabled = false;
        }
    }
}
