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
    public partial class Normalno : Form
    {
        public Normalno()
        {
            InitializeComponent();
        }

        private void Normalno_Load(object sender, EventArgs e)
        {
            isNormal(1);
            isNormal(2);
            isNormal(3);
            isNormal(5);
            isNormal(6);
            isNormal(10);
        }

        int isNormal(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (i > 1)
                    {
                        if (i % 2 != 0)
                            return 0;
                    }
                }
            }
            return 1;
        }
    }
}
