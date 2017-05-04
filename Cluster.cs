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
    public partial class Cluster : Form
    {
        public Cluster()
        {
            InitializeComponent();
        }

        private void Cluster_Load(object sender, EventArgs e)
        {
            label1.Text = (clusterCompression(new int[] {0, 0, 0, 2, 0, 2, 0, 2, 0, 0 })).ToString();
            label2.Text = (clusterCompression(new int[] { 18 })).ToString();
            label3.Text = (clusterCompression(new int[] {  })).ToString();
            label4.Text = (clusterCompression(new int[] { -5, -5, -5, -5, -5 })).ToString();
            label5.Text = (clusterCompression(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 })).ToString();
            label6.Text = (clusterCompression(new int[] { 8, 8, 6, 6, -2, -2, -2 })).ToString();
        }

        static int[] clusterCompression(int[] a)
        {
            int numClusters = 0;
            int number=0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    number = a[i];
                    numClusters++;
                }
                if (number != a[i])
                    numClusters++;
                number = a[i];
            }
            int[] result = new int[numClusters];            
            for(int i = 0, j=0; i<a.Length ; i++, j++)
            {
                if (i == 0)
                {
                    number = a[i];
                    result[j] = a[i];                    
                }
                if (number != a[i])                 
                result[j] = a[i];                    
                number = a[i];
            }
            return result;
        }
    }
}
