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
    public partial class SequentiallyBounded : Form
    {
        public SequentiallyBounded()
        {
            InitializeComponent();
        }

        private void SequentiallyBounded_Load(object sender, EventArgs e)
        {

        }

        static int isSequentially(int[] a)
        {
            int val = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]< 0)
                {
                    return 0;
                }
                else if (a[i] >= val)
                {
                    val = a[i];
                }
            }
            return 1;
        }
    }
}
