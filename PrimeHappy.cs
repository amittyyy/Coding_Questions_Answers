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
    public partial class PrimeHappy : Form
    {
        public PrimeHappy()
        {
            InitializeComponent();
        }

        private void PrimeHappy_Load(object sender, EventArgs e)
        {
            label1.Text = isPrimeHappy(5).ToString();
            label2.Text = isPrimeHappy(25).ToString();
            label3.Text = isPrimeHappy(32).ToString();
            label4.Text = isPrimeHappy(8).ToString();
            label5.Text = isPrimeHappy(2).ToString();            
        }

        int isPrimeHappy(int n)
        {
            bool isPrime = true;
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (i <= 1)
                {
                    isPrime = false;
                }
                if (isPrime)
                {
                    if (i < n)
                        sum += i;
                    else
                        return 0;
                }
                isPrime = true;
            }
            if (n == 2) return 0;
            if (sum % n == 0)
                return 1;
            else return 0;
        }
    }
}
