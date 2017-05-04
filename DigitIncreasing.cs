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
    public partial class DigitIncreasing : Form
    {
        public DigitIncreasing()
        {
            InitializeComponent();
        }

        private void DigitIncreasing_Load(object sender, EventArgs e)
        {
            label1.Text = isDigitIncreasing(24).ToString();
            label2.Text = isDigitIncreasing(7).ToString();
            label3.Text = isDigitIncreasing(36).ToString();
            label4.Text = isDigitIncreasing(984).ToString();
            label5.Text = isDigitIncreasing(7404).ToString();
        }

        int isDigitIncreasing(int n)
        {
            string num = "";
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                num += i.ToString();
                while (sum < n)
                {
                    sum += Convert.ToInt32(num);
                    num += i.ToString();
                    if (sum == n)
                        return 1;
                }
                num = "";
                sum = 0;
            }            
            return 0;
        }
    }
}
