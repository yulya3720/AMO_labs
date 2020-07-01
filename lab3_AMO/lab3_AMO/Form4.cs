using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_AMO
{
    public partial class mistakeForm : Form
    {
        public mistakeForm(List<double> xArray, List<double> yArray)
        {
            InitializeComponent();
            this.xArray = xArray;
            this.yArray = yArray;
        }
        List<double> xArray = new List<double>();
        List<double> yArray = new List<double>();

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < yArray.Count; i++)
            {
                mistakeChart.Series[0].Points.AddXY(xArray[i], yArray[i]);
            }
        }
    }
}
