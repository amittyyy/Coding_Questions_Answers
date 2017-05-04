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
    public partial class PrimeNumberBetween : Form
    {
        public PrimeNumberBetween()
        {
            InitializeComponent();
        }

        private void PrimeNumberBetween_Load(object sender, EventArgs e)
        {
            label1.Text = (PrimeCount(10, 30)).ToString();
            label2.Text = (PrimeCount(11, 29)).ToString();
            label3.Text = (PrimeCount(20, 22)).ToString(); 
            label4.Text = (PrimeCount(1, 1)).ToString();
            label5.Text = (PrimeCount(5, 5)).ToString();
            label6.Text = (PrimeCount(6, 2)).ToString();
            label7.Text = (PrimeCount(-10, 6)).ToString();
        }

        public static void main()
        {
        }

        static int PrimeCount(int Start, int End)
        {
            int count=0;
            bool isPrime = true;
            
            for (int i = Start; i <= End; i++)
            {
                for (int j = 2; j <= End; j++)
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
                    count++; 
                }
                isPrime = true;
            }
            return count;
        }
    }
}
