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
    public partial class factorTwoCount : Form
    {
        public factorTwoCount()
        {
            InitializeComponent();
        }

        private void factorTwoCount_Load(object sender, EventArgs e)
        {
            label1.Text = IsfactorTwoCount(48).ToString();
            label2.Text = IsfactorTwoCount(27).ToString();
        }

        static int IsfactorTwoCount(int n)
        {
            int count = 0;
            while (n % 2 == 0)
            {
                n = n / 2;
                count++;
            }
            return count;
        }
    }
}
