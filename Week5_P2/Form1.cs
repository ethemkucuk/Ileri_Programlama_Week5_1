using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hareket(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: panel1.Left -= 10;break;
                case Keys.Right: panel1.Left += 10; break;
                case Keys.Up: panel1.Top -= 10;break;
                case Keys.Down: panel1.Top += 10;break;

            }
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Top += 2;
            label2.Top -= 2;

            if (label2.Top > 500) 
            { 
                label2.Left = rnd.Next(0, 500);
                label2.Top = 0;
            }
            if(label2.Top < 0) 
            {
                label1.Left = rnd.Next(0, 500);
                label1.Top = 500;
            }

            if(panel1.Top == label1.Top && panel1.Left > (label1.Left) && panel1.Left < (label1.Left + 100))
            {
                timer1.Enabled = false;
                label3.Text = " G A M E  O V E R ";

            }
            if(panel1.Top == label1.Top && panel1.Left > (label1.Left) && panel1.Left < (label1.Left + 100))
                {
                timer1.Enabled = false;
                label3.Text = " G A M E  O V E R ";
            }
        }
    }
}
