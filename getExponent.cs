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
    public partial class getExponent : Form
    {
        public getExponent()
        {
            InitializeComponent();
        }

        private void getExponent_Load(object sender, EventArgs e)
        {
            label1.Text = isgetExponent(27, 3).ToString();
            label2.Text = isgetExponent(28, 3).ToString();
            label3.Text = isgetExponent(280, 7).ToString();
            label4.Text = isgetExponent(-250, 5).ToString();
            label5.Text = isgetExponent(18, 1).ToString();
            label6.Text = isgetExponent(128, 4).ToString();
        }

        int isgetExponent(int n, int p)
        {
            //Rong

            if (p <= 1) return -1;
            int numb = 0;
            while (n > 0)
            {
                int reminder = n / p;
                n = reminder;
                numb++;
            }
            return numb;
        }

    }
}
