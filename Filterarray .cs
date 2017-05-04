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
    public partial class Filterarray : Form
    {
        public Filterarray()
        {
            InitializeComponent();
        }

        private void Filterarray_Load(object sender, EventArgs e)
        {
            label1.Text = isFilter(new int[] { 1, 2, 3, 9, 6, 11 }).ToString();
            label2.Text = isFilter(new int[] { 3, 4, 6, 7, 14, 16 }).ToString();
            label3.Text = isFilter(new int[] { 1, 2, 3, 4, 10, 11, 13 }).ToString();
            label4.Text = isFilter(new int[] { 3, 6, 5, 5, 13, 6, 13 }).ToString();
            label5.Text = isFilter(new int[] { 9, 6, 18 }).ToString();
            label6.Text = isFilter(new int[] { 4, 7, 13 }).ToString();
        }

        int isFilter(int[] a)
        {
            int count9=0; 
            int count7=0;
            int count11=0;
            int count13=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 9)
                    count9++;
                if (a[i] == 7)
                    count7++;
                if (a[i] == 11)
                    count11++;
                if (a[i] == 13)
                    count13++;
            }
            if (count9 > 0 && count11 == 0) return 0;
            if (count7>0 && count13>0) return 0;
                return 1;
        }
    }
}

