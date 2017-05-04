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
    public partial class isIntertial : Form
    {
        public isIntertial()
        {
            InitializeComponent();
        }

        private void isIntertial_Load(object sender, EventArgs e)
        {
           // label1.Text = isIntertialname(new int[] { 1 }).ToString();
           // label2.Text = isIntertialname(new int[] { 2 }).ToString();
            label3.Text = isIntertialname(new int[] { 1, 2, 3, 4 }).ToString();
            label8.Text = isIntertialname(new int[] { 1, 1, 1, 1, 1, 1, 2 }).ToString();
            label5.Text = isIntertialname(new int[] { 2, 12, 4, 6, 8, 11 }).ToString();
            label6.Text = isIntertialname(new int[] { 2, 12, 12, 4, 6, 8, 11 }).ToString();
            label7.Text = isIntertialname(new int[] { -2, -4, -6, -8, -11 }).ToString();
        }

        // accept array non-negative return the second largest integer in the array 
        //static int isIntertialname(int[] a)
        //{
        //    int max1 = -1, max2 = -1;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > max1)
        //        {
        //            max2 = max1;  
        //            max1 = a[i];
        //        }
        //        else if (a[i] != max1 && a[i] > max2)
        //            max2 = a[i];
        //    }
        //    return max2;
        //}
        //static int isIntertialname(int[] a)
        //{
        //    int oddnum = 0; int evennum = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {

        //        if (a[i] % 2 != 0)
        //        {
        //            oddnum = a[i];
        //        }
        //        if (a[i] % 2 == 0 && Maxvalue(a) == 1)
        //        {
        //            evennum = a[i];
        //            if (oddnum > evennum)
        //            {
        //                return 1;
        //            }
        //        }

        //    }
        //    return 0;
        //}

        //static int Maxvalue(int [] a)
        //{
            
        //    int max = 0;
        //    for (int i = 0; i < a.Length;i++ )
        //    {
        //        if (a[i] > max)
        //        {                   
        //            if (a[i] % 2 == 0)
        //            max = a[i];
        //        }
        //        else
        //        return 0;
        //    } return 1;
        //} 

        static int isIntertialname(int[] a)
        {
            int max = 0; int minodd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] % 2 != 0)
                {
                    if (minodd != 0 && a[i] < minodd)
                        minodd = a[i];
                    else if (minodd == 0)
                        minodd = a[i];
                }

            }
            if (minodd == 0)
                return 0;
            else if (max % 2 != 0)
                return 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] != max && minodd < a[i])
                    return 0;
            }
            return 1;
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
