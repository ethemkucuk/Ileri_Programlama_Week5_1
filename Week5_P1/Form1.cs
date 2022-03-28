using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10] { 45, 51, 14, 12, 1, 67, 89, 34, 112, 155 };
            Random rnd = new Random();
            int say = rnd.Next(0, 10);
            textBox1.Text = a[say].ToString();
        }
    }
}
