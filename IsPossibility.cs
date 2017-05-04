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
    public partial class IsPossibility : Form
    {
        public IsPossibility()
        {
            InitializeComponent();
        }

        private void IsPossibility_Load(object sender, EventArgs e)
        {
            isAllPossibilities(new int[] { 1, 2, 0, 3 });
            isAllPossibilities(new int[] { 1, 2, 4, 3 });
        }

        int isAllPossibilities(int[] a)
        {            
            int count=0;
            int len = a.Length - 1;
            int j = 0;             
            for (int i = 0; i <= len; i++)
            {
                if (a[i] == j)
                {
                    if (j != len)
                    {
                        j = j + 1;
                        i = -1;
                    }
                    count++;
                }
                if (count == 0 && i==len)
                    return 0;
                count = 0;
            }
            return 1;
        }
    }
}
