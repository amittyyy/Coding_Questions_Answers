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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void Factorial_Load(object sender, EventArgs e)
        {
            label1.Text = (Fact(5)).ToString();
            label2.Text = (calcFact(5)).ToString();
        }

        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }

        static int calcFact(int n)
        {
            if (n <= 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
