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
    public partial class StantonMeasure : Form
    {
        public StantonMeasure()
        {
            InitializeComponent();
        }

        private void StantonMeasure_Load(object sender, EventArgs e)
        {
            label1.Text = (stantonMeasure(new int[] {1})).ToString();
            label2.Text = (stantonMeasure(new int[] {0})).ToString();
            label3.Text = (stantonMeasure(new int[] { 3, 1, 1, 4 })).ToString();
            label4.Text = (stantonMeasure(new int[] { 1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4 })).ToString();
            label5.Text = (stantonMeasure(new int[] { })).ToString();
        }

        static int stantonMeasure(int[] a)
        {
            int count = 0;
            int finalcount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    count++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == count)
                {
                    finalcount++;
                }
            }            
            return finalcount;
        }
    }
}
