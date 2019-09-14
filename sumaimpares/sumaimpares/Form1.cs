using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumaimpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int limitetxt2 = int.Parse(limitetxt.Text);
            int i = 1;
            int x = 0;            
            for (i=1;i==limitetxt2 ; i++)
            {
                do
                {
                    x = i + i;                    
                }
                while (i % 2 == 0);                
            }
            lbltotal.Text = x.ToString();
        }
    }
}
