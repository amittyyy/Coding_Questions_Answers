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
    public partial class FactorEqual : Form
    {
        public FactorEqual()
        {
            InitializeComponent();
        }

        private void FactorEqual_Load(object sender, EventArgs e)
        {
            isFactorEqual(10, 33);
            isFactorEqual(9, 10);
        }

        int isFactorEqual(int n, int m)
        {
            int factorn=0;
            int factorm=0;
            if (n < 1 || m < 1) return 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    factorn++;
            }
            for (int i = 1; i <= m; i++)
            {
                if (m % i == 0)
                    factorm++;
            }
            if (factorn == factorm)
                return 1;
            else return 0;
        } 
    }
}

