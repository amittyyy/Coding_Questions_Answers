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
    public partial class SumSafe : Form
    {
        public SumSafe()
        {
            InitializeComponent();
        }

        private void SumSafe_Load(object sender, EventArgs e)
        {
            label1.Text = (IsSumSafe(new int[] { 5, -5, 0 })).ToString();
            label2.Text = (IsSumSafe(new int[] { 5, -2, 0 })).ToString();
        }

        static int IsSumSafe(int[] a)
        {
            int sum = a.Sum();
            if (a.Length == 0)
                return 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == sum)
                    return 0;
            }
            return 1;
        }
    }
}
