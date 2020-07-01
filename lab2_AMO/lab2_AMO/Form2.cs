using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab2_AMO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<int> XPractical, List<double> YPratical, List<double> XTheoretical, List<double> YTheoretical)
        {
            InitializeComponent();
            this.XTheoretical = XTheoretical;
            this.YTheoretical = YTheoretical;
            this.XPractical = XPractical;
            this.YPractical = YPratical;
        }
     
        private List<double> XTheoretical = new List<double>();
        private List<double> YTheoretical = new List<double>();
        private List<int> XPractical = new List<int>();
        private List<double> YPractical = new List<double>();
        private void Form2_Load(object sender, EventArgs e)
        {
            var chart = chart1.ChartAreas[0];

            chart1.Series[0].IsVisibleInLegend = false;
            chart.AxisX.Interval = 10000;
            chart.AxisY.Interval = 10;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 100000;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 300;

            //chart.AxisY2.Enabled = AxisEnabled.True;
            //chart.AxisY2.Minimum = 0;

          //  chart.AxisY2.Maximum = ;

            //chart.AxisX2.Enabled = AxisEnabled.True;
            //chart.AxisX2.Minimum = 0;
            //chart.AxisX2.Maximum = 120;
            //chart.AxisX2.Interval = 30;


            // chart1.Series.Add("Theoretical");
            // chart1.Series["Theoretical"].ChartType = SeriesChartType.Spline;
            //chart1.Series["Theoretical"].Color = Color.Gray;
            //chart1.Series["Theoretical"].AxisLabel = "";
           // if(chart1.Series["Practical"].Points){
            //chart1.Series["Prectical"].Points.Clear();
            chart1.Series.Add("Практично");
            chart1.Series["Практично"].ChartType = SeriesChartType.Spline;
            chart1.Series["Практично"].Color = Color.Red;
            for (int i = 0; i < XPractical.Count - 1; i++)
            {
                chart1.Series["Практично"].Points.AddXY(XPractical[i], YPractical[i]);
                //chart1.Series["Theoretical"].Points.AddXY(XTheoretical[i], YTheoretical[i]);
             //   chart1.Series["Theoretical"].Points.AddXY(XTheoretical[i], 30);
            }
            //foreach(DataPoint point in chart1.Series["Theoretical"].Points)
            //{
            //   // point.AxisLabel = "AxisX2";
            //}
            double yt = chart1.Series["Теоретично"].Points[7].YValues[0];
            double yp = chart1.Series["Практично"].Points[7].YValues[0];
            double temp = yt / yp;
            chart.AxisY.Maximum = yp * chart.AxisY2.Maximum / yt;



        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            chart1.Series["Практично"].Points.Clear();
        }
    }
}
