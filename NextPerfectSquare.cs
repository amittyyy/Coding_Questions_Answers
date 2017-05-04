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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = (isPerfectSquare(49)).ToString();
            label2.Text = (isPerfectSquare(6)).ToString();
            label3.Text = (isPerfectSquare(36)).ToString();
            label4.Text = (isPerfectSquare(0)).ToString();
            label5.Text = (isPerfectSquare(-5)).ToString();
        }

        public static void main()
        {
        }

        static int isPerfectSquare(int n)
        {
            if (n < 0) return 0;
            n++;
            var result = Math.Sqrt(n);
            var resultnumber = (int)result;
            if (resultnumber == result) return n;
            resultnumber++;
            return resultnumber * resultnumber;
        }
    }
}
