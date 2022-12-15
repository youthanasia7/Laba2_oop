using MeinLib;
using System;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form_Move : Form
    {
        private Figure figure;
        private Button butt;
        public Form_Move(Figure figure, Button butt)
        {
            this.figure = figure;
            this.butt = butt;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            try

            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                            
                
               figure.MoveTo(x, y);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }
    }
}
