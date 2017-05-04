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
    public partial class Nontrivialfactors : Form
    {
        public Nontrivialfactors()
        {
            InitializeComponent();
        }

        private void Nontrivialfactors_Load(object sender, EventArgs e)
        {
            isMeera(6);
            isMeera(30);
            isMeera(21);
        }

        int isMeera(int n)
        {
            int totalfactor=0;
            int exist=0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    totalfactor++;
            }
            for (int i = 2; i < n; i++)
            {                
                if (n % i == 0)
                {
                    if (totalfactor == i)
                        exist++;
                }

            }
            if (exist > 0)
                return 1;
            else
                return 0;
        }
    }
}
