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
    public partial class StackedNumber : Form
    {
        public StackedNumber()
        {
            InitializeComponent();
        }

        private void StackedNumber_Load(object sender, EventArgs e)
        {
            label1.Text = isStacked(10).ToString();
            label2.Text = isStacked(7).ToString();
        }

        static int isStacked(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
                if (sum == n)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
