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
    public partial class Vesuvian : Form
    {
        public Vesuvian()
        {
            InitializeComponent();
        }

        private void Vesuvian_Load(object sender, EventArgs e)
        {
            label1.Text = isVesuvian(50).ToString();
            label2.Text = isVesuvian(65).ToString();
            label3.Text = isVesuvian(85).ToString();
            label4.Text = isVesuvian(789).ToString();
        }

        int isVesuvian(int a)
        {
            for (int i = 1; i <= a / 2; i++)
            {
                int square1 = i * i;
                for (int j = 1; j <= a / 2; j++)
                {
                    int square2 = j * j;
                    if (square1 + square2 == a)
                        return 1;
                }
            }
            return 0;
        }
    }
}
