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
    public partial class funcForm : Form
    {
        public funcForm(List<double> xArray, List<double> yArray, List<double> yArrayInterpolated)
        {
            InitializeComponent();
            this.xArray = xArray;
            this.yArray = yArray;
            this.yArrayInterpolated = yArrayInterpolated;

        }
        List<double> xArray = new List<double>();
        List<double> yArray = new List<double>();
        List<double> yArrayInterpolated = new List<double>();
        private void funcForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < xArray.Count; i++)
            {
                funcChart.Series[0].Points.AddXY(xArray[i], yArray[i]);
                funcChart.Series[1].Points.AddXY(xArray[i], yArrayInterpolated[i]);
            }
        }
    }
}
