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
    public partial class FactorialPrime : Form
    {
        public FactorialPrime()
        {
            InitializeComponent();
        }

        private void FactorialPrime_Load(object sender, EventArgs e)
        {
            label1.Text = isFactorialPrime(2).ToString();
            label2.Text = isFactorialPrime(3).ToString();
            label3.Text = isFactorialPrime(7).ToString();
            label4.Text = isFactorialPrime(8).ToString();
            label5.Text = isFactorialPrime(11).ToString();
        }

        int isFactorialPrime(int n)
        {
            if (n <= 1) return 0;
            if (isprime(n) == 1)
            {
                int factorial = Fact(n - 1);
                if (factorial + 1 == n)
                    return 1;
            }
            return 0;
        }

        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }

        int isprime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                    if (n != i && n % i == 0)
                        return 0;
            }
            return 1;
        }
    }
}
