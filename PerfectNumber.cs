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
    public partial class PerfectNumber : Form
    {
        public PerfectNumber()
        {
            InitializeComponent();
        }

        private void PerfectNumber_Load(object sender, EventArgs e)
        {
            label1.Text = henry(1, 3).ToString();
        }

        int henry(int i, int j)
        {
            int sum = 0, x = 0, count = 0, finalsum=0;
            for (int num = 1; num < 1000; num++)
            {
                for (int factor = 1; factor < num; factor++)
                {
                    x = num % factor;
                    if (x == 0  )
                        sum = sum + factor;
                }
                if (sum == num)
                {
                    count++;
                    if (count == i || count == j)
                        finalsum += sum;
                    if (count == j)
                        return finalsum;
                }
               sum = 0;
            }
            return finalsum;
        }
    }
}
