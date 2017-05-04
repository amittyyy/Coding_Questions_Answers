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
    public partial class RepsEqual : Form
    {
        public RepsEqual()
        {
            InitializeComponent();
        }

        private void RepsEqual_Load(object sender, EventArgs e)
        {
            label1.Text = (repsEqual(new int[] { 3, 2, 0, 5, 3 }, 32053)).ToString();
            label2.Text = (repsEqual(new int[] { 3, 2, 0, 5 }, 32053)).ToString();
            label3.Text = (repsEqual(new int[] { 3, 2, 0, 5, 3, 4 }, 32053)).ToString();
            label4.Text = (repsEqual(new int[] { 0, 3, 2, 0, 5, 3 }, 32053)).ToString();
        }

        static int repsEqual(int[] a, int n)
        {
            string ArrayValue = "";
            int IntArrayValue = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0 && i == 0)
                {
                    IntArrayValue = a[i];
                }
                else
                {
                    IntArrayValue = a[i];
                }
                ArrayValue = ArrayValue + IntArrayValue.ToString();
            }
            if (n == int.Parse(ArrayValue))
                return 1;
            else
                return 0;
        }
    }
}
