using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_AMO
{
    public partial class Form2 : Form
    {
        public Form2(double x1, double x2, double x3)
        {
            InitializeComponent();
            label1.Text = "X1 = " + x1.ToString();
            label1.Text = "X2 = " + x2.ToString();
            label1.Text = "X3 = " + x3.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
