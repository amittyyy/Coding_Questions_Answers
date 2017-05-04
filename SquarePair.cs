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
    public partial class SquarePair : Form
    {
        public SquarePair()
        {
            InitializeComponent();
        }

        private void SquarePair_Load(object sender, EventArgs e)
        {
            label1.Text = (countSquarePairs(new int[] { 9, 0, 2, -5, 7 })).ToString();
            label2.Text = (countSquarePairs(new int[] { 9 })).ToString();
            label3.Text = (countSquarePairs(new int[] { 11, 5, 4, 20 })).ToString();
            label4.Text = (countSquarePairs(new int[] { 9 })).ToString();
            
        }

        static int countSquarePairs(int[] a)
        {
            int n = 0;
            int count = 0;
            if (a.Length == 1)
                return 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            if (a[i] < a[j])
                            { 
                                n = a[i] + a[j];
                                if (isPerfectSquare(n) > 0)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }

        static int isPerfectSquare(int n)
        {
            if (n < 0) return 0;            
            var result = Math.Sqrt(n);
            var resultnumber = (int)result;
            if (resultnumber == result) return 1;            
            return 0;
        }
    }
}
