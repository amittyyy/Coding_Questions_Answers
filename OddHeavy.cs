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
    public partial class OddHeavy : Form
    {
        public OddHeavy()
        {
            InitializeComponent();
        }

        private void OddHeavy_Load(object sender, EventArgs e)
        {
            label1.Text = (isOddHeavy(new int[] { 1})).ToString();
            label2.Text = (isOddHeavy(new int[] { 2 })).ToString();
            label3.Text = (isOddHeavy(new int[] { 1, 1, 1, 1 })).ToString();
            label4.Text = (isOddHeavy(new int[] { 2, 4, 6, 8, 11 })).ToString();
            label5.Text = (isOddHeavy(new int[] { -2, -4, -6, -8, -11 })).ToString();
        }

        int isOddHeavy(int[] a)
        {
            int minodd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    if (minodd != 0 && a[i] < minodd)
                        minodd = a[i];
                    else if (minodd == 0)
                        minodd = a[i];
                }               
            }
            if(minodd==0)
                return 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && minodd < a[i])
                    return 0;
            }
            return 1;
        }
    }
}
