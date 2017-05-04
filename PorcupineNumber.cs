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
    public partial class PorcupineNumber : Form
    {
        public PorcupineNumber()
        {
            InitializeComponent();
        }

        private void PorcupineNumber_Load(object sender, EventArgs e)
        {
            //label1.Text = findPorcupineNumber1(0).ToString();
            //label2.Text = findPorcupineNumber1(139).ToString();
            findPorcupineNumber(0);
        }

        void findPorcupineNumber(int n)
        {
            n = n + 1;     
            if (isPrime(n) == 1)
            {
                if (n % 10 == 9)
                {
                    label1.Text = n.ToString();
                }
                else
                {
                    findPorcupineNumber(n);
                }
            }
            else
            {
                findPorcupineNumber(n);
            }
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
