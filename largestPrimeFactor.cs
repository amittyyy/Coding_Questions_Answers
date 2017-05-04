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
    public partial class largestPrimeFactor : Form
    {
        public largestPrimeFactor()
        {
            InitializeComponent();
        }

        private void largestPrimeFactor_Load(object sender, EventArgs e)
        {
            label1.Text = islargestPrimeFactor(10).ToString();
            label2.Text = islargestPrimeFactor(6936).ToString();
            label3.Text = islargestPrimeFactor(1).ToString();

        }

        int islargestPrimeFactor(int n) 
        {
            int maxnumber = 0;
            int number = 0;
            if (n <= 1)
                return 0;
            for (int i = 1; i < n; i++)
            {
                number = n % i;
                if (number == 0)
                {
                    if (isPrime(i) == 1)
                    {
                        if (maxnumber == 0) maxnumber = i;
                        else if (maxnumber < i) maxnumber = i;
                    }
                }
            }
            return maxnumber;
        }

        static int isPrime(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                return 0;
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        return 0;
                    }

                }
                return 1;
            }
        }

    }
}

