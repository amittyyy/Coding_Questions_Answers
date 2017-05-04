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
    public partial class Balanced : Form
    {
        public Balanced()
        {
            InitializeComponent();
        }

        private void Balanced_Load(object sender, EventArgs e)
        {
           label1.Text =  isBalanced(new int[] { 1,2,3,9,6,13 }).ToString(); // 0
           label2.Text =  isBalanced(new int[] { 3,4,6,7,13,15 }).ToString(); //0
           label3.Text =  isBalanced(new int[] { 1,2,3,4,10,11,12 }).ToString(); //0
           label4.Text = isBalanced(new int[] { 6, 7, 2, 3, 12 }).ToString(); //1
           label5.Text =  isBalanced(new int[] { 2,3,6,7 }).ToString(); //1
           label6.Text =  isBalanced(new int[] { 4,7,16 }).ToString(); //1
        }

        int isBalanced(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (a[i] % 2 != 0)
                        return 0;
                }
                if (i%2 != 0 )
                {
                    if (a[i] % 2 == 0)
                        return 0;
                }
            }
            return 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
