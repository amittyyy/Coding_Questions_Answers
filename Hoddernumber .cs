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
    public partial class Hoddernumber : Form
    {
        public Hoddernumber()
        {
            InitializeComponent();
        }

        private void Hoddernumber_Load(object sender, EventArgs e)
        {

        }

        int ishooder(int n)
        {
            int j = 0;
            if (isprime(n) == 1)
            {
                n = n + 1;
                while (n > 0)
                {
                    if (n % 2 != 0)
                    {
                        return 0;
                    }
                    else
                    {
                        n = n / 2;
                        j++;
                        return 1;
                    }
                }
            }
            return 1;
        }

        int isprime(int n)
        {
            if (n <= 1) return 0;
           for(int i=0; i<=n/2; i++)
            {
                if (i % 1 == 0)
                    return 0;
            }
           return 1;
        }
    }
}
