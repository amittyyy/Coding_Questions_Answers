using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Isolated : Form
    {
        public Isolated()
        {
            InitializeComponent();
        }

        private void Isolated_Load(object sender, EventArgs e)
        {
            label1.Text = IsIsolated(163).ToString();
            label2.Text = IsIsolated(162).ToString();
            label3.Text = IsIsolated(63).ToString();
            label4.Text = IsIsolated(58).ToString();
            label5.Text = IsIsolated(34).ToString();
            label6.Text = IsIsolated(2097152).ToString();
            label7.Text = IsIsolated(0).ToString();
            label8.Text = IsIsolated(28).ToString();
            label9.Text = IsIsolated(24).ToString();
            label10.Text = IsIsolated(14).ToString();
        }

        static int IsIsolated(long n)
        {
            if (n > 2097151 || n < 1)
                return -1;
            int square = Convert.ToInt32(Math.Pow(n, 2));
            int cube = Convert.ToInt32(Math.Pow(n, 3));
            int squareno = 0;
            int Cubeno = 0;
            while (square > 0)
            {
                squareno = square % 10;
                square /= 10;
                while (cube > 0)
                {
                    Cubeno = cube % 10;
                    cube /= 10;
                    if (squareno == Cubeno)
                        return 0;
                }                
            }
            return 1;
        }
    }
}
