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
    public partial class Dual : Form
    {
        public Dual()
        {
            InitializeComponent();
        }

        private void Dual_Load(object sender, EventArgs e)
        {
            label1.Text = (isdual(new int[]{ 1, 2, 3, 0})).ToString();
            label2.Text = (isdual(new int[] { 1, 2, 2, 1, 3, 0 })).ToString();
            label3.Text = (isdual(new int[] { 1, 1, 2, 2 })).ToString();
            label4.Text = (isdual(new int[] { 1, 2, 1 })).ToString();
        }

        static int isdual(int[] a)
        {
            int sumeven=0;
            int sumodd=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumeven += a[i];
                }
                else
                {
                    sumodd += a[i];
                }
            }
            if (sumeven == 0)
                return 0;
            else if (sumeven != sumodd)
                return 0;
                return 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
