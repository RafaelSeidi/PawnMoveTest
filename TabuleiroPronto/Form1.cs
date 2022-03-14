using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuleiroPronto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int x = rnd.Next(1, 7);

            pictureBox2.Load("dado" + x.ToString() + ".png");

            string P = ("panel" + x.ToString());

            if (x == 1)
            {
                pictureBox1.Parent = panel1;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
            else if (x == 2)
            {
                pictureBox1.Parent = panel2;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
            else if (x == 3)
            {
                pictureBox1.Parent = panel3;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
            else if (x == 4)
            {
                pictureBox1.Parent = panel4;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
            else if (x == 5)
            {
                pictureBox1.Parent = panel5;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
            else if (x == 6)
            {
                pictureBox1.Parent = panel6;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
            }
        }
    }
}
