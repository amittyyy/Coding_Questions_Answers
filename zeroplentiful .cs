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
    public partial class zeroplentiful : Form
    {
        public zeroplentiful()
        {
            InitializeComponent();
        }

        private void zeroplentiful_Load(object sender, EventArgs e)
        {
            label1.Text = isZeroPlentiful(new int[] { 0, 0, 0, 0, 0 }).ToString();
            label2.Text = isZeroPlentiful(new int[] { 1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12 }).ToString();
            label3.Text = isZeroPlentiful(new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0 }).ToString();
            label4.Text = isZeroPlentiful(new int[] { 1, 2, 3, 4 }).ToString();
            label5.Text = isZeroPlentiful(new int[] { 1, 0, 0, 0, 2, 0, 0, 0, 0 }).ToString();
            label6.Text = isZeroPlentiful(new int[] { 0 }).ToString();
            label7.Text = isZeroPlentiful(new int[] { }).ToString();
        }

        int isZeroPlentiful(int[] a)
        {
            int countzero = 0;
            int value = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    countzero++;
            }

            if (countzero < 4) return 0;
            countzero = 0;
            for (int i = 0; i < a.Length; i++)
            {                
                while(a[i] == 0 & i!=a.Length-1)
                {
                    countzero++;
                   if(i<a.Length-1)
                    i++;
                }
                if (countzero >= 4)
                    value = value + 1;
                countzero = 0;
            }
            return value;
        }
    }
}

