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
    public partial class LegalNumber : Form
    {
        public LegalNumber()
        {
            InitializeComponent();
        }

        private void LegalNumber_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(isLegalNumber(new int[] { 3, 2, 1 }, 4));
            label2.Text = Convert.ToString(isLegalNumber(new int[] { 3, 7, 1 }, 6));
        }

        static int isLegalNumber(int[] a, int base1)
        {
            int islegal = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > base1)
                {
                    islegal = 0;
                }               
            }
            return islegal;
        }
    }
}
