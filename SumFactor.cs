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
    public partial class SumFactor : Form
    {
        public SumFactor()
        {
            InitializeComponent();
        }

        private void SumFactor_Load(object sender, EventArgs e)
        {
            label1.Text = (sumFactor(new int[] { 3, 0, 2, -5, 0 })).ToString();
            label2.Text = (sumFactor(new int[] { 9, -3, -3, -1, -1 })).ToString();
            label3.Text = (sumFactor(new int[] {1})).ToString();
            label4.Text = (sumFactor(new int[] { 0, 0, 0 })).ToString();
        }

        static int sumFactor(int[] a)
        {
            int sum = 0;
            int sumfactor = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == sum)
                {
                    sumfactor++;
                }
            }
            return sumfactor;
        }
    }
}
