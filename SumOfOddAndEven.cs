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
    public partial class SumOfOddAndEven : Form
    {
        public SumOfOddAndEven()
        {
            InitializeComponent();
        }

        private void SumOfOddAndEven_Load(object sender, EventArgs e)
        {
            label1.Text = (f(new int[] { 1 })).ToString();
            label2.Text = (f(new int[] { 1, 2 })).ToString();
            label3.Text = (f(new int[] { 1, 2, 3 })).ToString();
            label4.Text = (f(new int[] { 1, 2, 3, 4 })).ToString();
            label5.Text = (f(new int[] { 3, 2, 3, 4 })).ToString();
            label6.Text = (f(new int[] { })).ToString();
        }

        static int f(int[] a)
        {
            int x = 0; int y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    x += a[i];
                }
                else
                {
                    y += a[i];
                }
            }
            return x - y;
        }
    }
}
