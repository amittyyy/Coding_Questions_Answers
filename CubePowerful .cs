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
    public partial class CubePowerful : Form
    {
        public CubePowerful()
        {
            InitializeComponent();
        }

        private void CubePowerful_Load(object sender, EventArgs e)
        {
            label1.Text = isCubePowerful(153).ToString();
            label2.Text = isCubePowerful(370).ToString();
            label3.Text = isCubePowerful(371).ToString();
            label4.Text = isCubePowerful(407).ToString();
            label5.Text = isCubePowerful(87).ToString();
            label6.Text = isCubePowerful(0).ToString();
            label7.Text = isCubePowerful(-81).ToString();
        }

        int isCubePowerful(int n)
        {
            int sum = 0;
            int digit = 0;
            int num = n;
            if (num <= 0) return 0;
            while (num != 0)
            {
                digit = num % 10;
                num = num / 10;
                sum = sum + (digit * digit * digit);
            }
            //if (n <= 0) return 0;
            //int cube = 3;
            //int number = n;
            //int cubesum =1;
            //int sum = 0;
            //while (number > 0)
            //{
            //   int digit = number % 10;
            //    for (int i = 1; i <= cube; i++)
            //    {
            //        cubesum *= digit;
            //    }
            //    sum += cubesum;
            //    number /= 10;
            //    cubesum = 1;
            //}
            if (n == sum)
                return 1;
            else return 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
