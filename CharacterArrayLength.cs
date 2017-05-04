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
    public partial class CharacterArrayLength : Form
    {
        public CharacterArrayLength()
        {
            InitializeComponent();
        }

        private void CharacterArrayLength_Load(object sender, EventArgs e)
        {
            //label1.Text = (f(new char[] { 'a', 'b', 'c' }, 0, 4)).ToString();
            label2.Text = (f(new char[] { 'a', 'b', 'c' }, 0, 3)).ToString();
            //label3.Text = (f(new char[] { 'a', 'b', 'c' }, 0, 2)).ToString();
            //label4.Text = (f(new char[] { 'a', 'b', 'c' }, 1, 0)).ToString();
            //label5.Text = (f(new char[] { 'a', 'b', 'c' }, -1, 2)).ToString();
            //label6.Text = (f(new char[] { }, 0, 1)).ToString();
        }

        static char[] f(char[] a, int start, int len)
        {
            if (len < 0 || start < 0 || start + len - 1 >= a.Length)
            {
                return null;
            }

            char[] sub = new char[len];
            for (int i = start, j = 0; j < len; i++, j++)
            {
                sub[j] = a[i];
            }

            return sub;
        }
    }
}
