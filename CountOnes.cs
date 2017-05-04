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
    public partial class CountOnes : Form
    {
        public CountOnes()
        {
            InitializeComponent();
        }

        private void CountOnes_Load(object sender, EventArgs e)
        {
               countOnes(9);
               countOnes(5);
               countOnes(15);
        }

        int countOnes(int n)
        {
            int countone = 0;
            while (n > 0)
            {
                int reminder = n % 2;
                if (reminder == 1)
                    countone++;
                n /= 2;
            }
            return countone++;
        }

    }
}
