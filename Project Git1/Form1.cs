using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Git1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int fak = 1;
            for(int z = 2; z <= x; z++)
            {
                fak *= z;
            }
            MessageBox.Show("Faktoriál čísla " + x + " je " + fak,"Faktoriál",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double n = Convert.ToInt32(textBox2.Text);
            double an = Math.Pow(a, n);
            MessageBox.Show(a +" na "+n + " se rovná "+an, "a ana n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
