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
    public partial class NoZero : Form
    {
        public NoZero()
        {
            InitializeComponent();
        }

        private void NoZero_Load(object sender, EventArgs e)
        {
            label1.Text = (arrayHasNoZero(new int[] { 1, 2, 3 })).ToString();
            label2.Text = (arrayHasNoZero(new int[] { 1, 0, 4, 0 })).ToString();
            label3.Text = (arrayHasNoZero(new int[] { 1, 2, 3, 0 })).ToString();
            label4.Text = (arrayHasNoZero(new int[] { 0, 0, 0 })).ToString();
            label5.Text = (arrayHasNoZero(new int[] {})).ToString();
        }

        static int arrayHasNoZero(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
