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
    public partial class isDivisible : Form
    {
        public isDivisible()
        {
            InitializeComponent();
        }

        private void isDivisible_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(isDivisibleFun(new int[] { 3, 3, 6, 36 }, 3));
            label2.Text = Convert.ToString(isDivisibleFun(new int[] { 4 }, 2));
            label3.Text = Convert.ToString(isDivisibleFun(new int[] { 3, 4, 3, 6, 36 }, 3));
            label4.Text = Convert.ToString(isDivisibleFun(new int[] { 6, 12, 24, 36 }, 12));
            label5.Text = Convert.ToString(isDivisibleFun(new int[] { }, 3));
        }

        static int isDivisibleFun(int[] a, int divisor)
        {
            int val = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % divisor != 0)
                {
                    val = 0;
                }
            }
            return val;
        }
    }
}
