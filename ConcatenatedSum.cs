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
    public partial class ConcatenatedSum : Form
    {
        public ConcatenatedSum()
        {
            InitializeComponent();
        }

        private void ConcatenatedSum_Load(object sender, EventArgs e)
        {
            label1.Text = checkConcatenatedSum(198, 2).ToString();
            label2.Text = checkConcatenatedSum(198, 3).ToString();
            label3.Text = checkConcatenatedSum(2997, 3).ToString();
            label4.Text = checkConcatenatedSum(2997, 2).ToString();
            label5.Text = checkConcatenatedSum(13332, 4).ToString();
            label6.Text = checkConcatenatedSum(9, 1).ToString();
        }

        int checkConcatenatedSum(int n, int catlen)
        {
            int digit = 0;
            int sum = 0;
            int num = n;
            while (num != 0)
            {
                digit = num % 10;
                num /= 10;                
                string newdigit = "";
                for (int i = 0; i < catlen; i++)
                {
                    newdigit = newdigit + digit.ToString();
                }
                sum += Convert.ToInt32(newdigit);
            }
            if (sum == n)
                return 1;
            else
                return 0;
        }
    }
}
