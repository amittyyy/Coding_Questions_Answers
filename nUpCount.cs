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
    public partial class nUpCount : Form
    {
        public nUpCount()
        {
            InitializeComponent();
        }

        private void nUpCount_Load(object sender, EventArgs e)
        {
            label1.Text = (nUpCountnew(new int[] { 2, 3, 1, -6, 8, -3, -1, 2 }, 5).ToString());
            label2.Text = (nUpCountnew(new int[] { 1,2,-1,5,3,2,-3 }, 20).ToString());
        }

        static int nUpCountnew(int[] a, int n)
        {
            int count = 0;
            int number = 0;
            for (int i = 0; i < a.Length; i++)
            {
                number = a[i] + number;
                if (number > n)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
