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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            label1.Text = fibonacci(13).ToString();
            label2.Text = fibonacci(33).ToString();
            label3.Text = fibonacci(34).ToString();
           // label4.Text = fibonacci(13).ToString();
        }

        int fibonacci(int n)
        {
            if (n < 1) return 0;
            int a = 0; int b = 1;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                if (max == 0)
                    max = a;
                if (max < a && a<=n)
                    max = a;                
            }
            if (max <= n)
                return max;
            else
                return 0;
        }
    }
}
