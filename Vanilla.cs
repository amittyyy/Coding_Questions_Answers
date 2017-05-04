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
    public partial class Vanilla : Form
    {
        public Vanilla()
        {
            InitializeComponent();
        }

        private void Vanilla_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(isVanilla(new int[] { 1 }));
            label2.Text = Convert.ToString(isVanilla(new int[] { 11, 22, 13, 34, 125 }));
            label3.Text = Convert.ToString(isVanilla(new int[] { 9, 999, 99999, -9999 }));
            label4.Text = Convert.ToString(isVanilla(new int[] { }));
        }

        static int isVanilla(int[] a)
        {
            int val = 1;
            int value1 = 0;
            int arrval, arrval2;
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                arrval = a[i];
                
                while (arrval != 0)
                {
                    if (cnt == 0)
                    {
                        value1 = arrval % 10;
                        if (value1 < 0)
                            value1 *= -1;
                        cnt++;
                    }
                    arrval2 = arrval % 10;
                    arrval /= 10;
                    if (arrval2 < 0)
                        arrval2 *= -1;
                    if (value1 != arrval2)
                        return 0;
                }
            }
            return val;
        }
    }
}
