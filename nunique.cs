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
    public partial class nunique : Form
    {
        public nunique()
        {
            InitializeComponent();
        }

        private void nunique_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(isNUnique(new int[] { 2, 7, 3, 4 }, 5));
            label2.Text = Convert.ToString(isNUnique(new int[] { 2, 3, 3, 7 }, 5));
            label3.Text = Convert.ToString(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 6));
            label4.Text = Convert.ToString(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 10));
            label5.Text = Convert.ToString(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 11));
            label6.Text = Convert.ToString(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 8));            
        }

        static int isNUnique(int[] a, int n)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i < j)
                    {
                        sum = a[i] + a[j];
                        if (sum == n)
                        {
                            count++;
                        }
                    }
                }
            }
            if (count == 1)
                return 1;
            else return 0;
        }
    }
}
