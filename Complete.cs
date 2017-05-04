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
    public partial class Complete : Form
    {
        public Complete()
        {
            InitializeComponent();
        }

        private void Complete_Load(object sender, EventArgs e)
        {
            isComplete(new int[] { 2, 3, 2, 4, 11, 6, 10, 9, 8 });
            isComplete(new int[] { 2, 3, 3, 6 });
        }
        int isComplete(int[] a)
        {
            int maxeven=0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (i == 0) maxeven = a[i];
                    else if (maxeven < a[i]) maxeven = a[i];
                }
            }
            for (int i = 2; i < maxeven; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == i)
                        {
                            count++;
                        }
                    }
                    if (count == 0) return 0;
                }
                count = 0;
            }
            return 1;

        }

        private void Complete_Load_1(object sender, EventArgs e)
        {

        }
    }
}

