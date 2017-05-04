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
    public partial class SecondLargestNumber : Form
    {
        public SecondLargestNumber()
        {
            InitializeComponent();
        }

        private void SecondLargestNumber_Load(object sender, EventArgs e)
        {
            label1.Text = (f(new int[] { 1, 2, 3, 4 })).ToString();
            label2.Text = (f(new int[] { 4, 1, 2, 3 })).ToString();
            label3.Text = (f(new int[] { 1, 1, 2, 2 })).ToString();
            label4.Text = (f(new int[] { 1, 1 })).ToString();
            label5.Text = (f(new int[] { 1 })).ToString();
            label6.Text = (f(new int[] { })).ToString();
        }

        static int f(int[] a)
        {
            int max1 = -1;
            int max2 = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if(a[i]!=max1 && a[i]>max2)
                {
                    max2 = a[i];
                }
            }
            return max2;
        }
    }
}
