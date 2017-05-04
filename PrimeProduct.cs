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
    public partial class PrimeProduct : Form
    {
        public PrimeProduct()
        {
            InitializeComponent();
        }

        private void PrimeProduct_Load(object sender, EventArgs e)
        {
            isPrimeProduct(22);
        }

        int isPrimeProduct(int n)
        {
            int product = 1;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (isprime(i) == 1)
                    {
                        product *= i;
                    }
                    if (product == n)
                        return 1;
                }
            }
            return 0;
        }

        int isprime(int n)
        {
            if (n <= 1) return 0;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }
    }
}
