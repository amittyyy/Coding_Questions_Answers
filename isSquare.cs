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
    public partial class isSquare : Form
    {
        public isSquare()
        {
            InitializeComponent();
        }

        private void isSquare_Load(object sender, EventArgs e)
        {
            label1.Text = (isSquarefun(4)).ToString();
            label2.Text = (isSquarefun(25)).ToString();
            label3.Text = (isSquarefun(-4)).ToString();
            label4.Text = (isSquarefun(8)).ToString();
            label5.Text = (isSquarefun(0)).ToString();
        }

        public static int isSquarefun(int n) 
        {            
            for (int i = 0; i < n; i++)
            {
                if (i * i == n)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
