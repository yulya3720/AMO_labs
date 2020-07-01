namespace lab3_AMO
{
    partial class sinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sinChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sinChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sinChart
            // 
            chartArea2.AxisX.Interval = 0.2D;
            chartArea2.AxisX.Maximum = 2D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.sinChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.sinChart.Legends.Add(legend2);
            this.sinChart.Location = new System.Drawing.Point(12, 12);
            this.sinChart.Name = "sinChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "sin(x)";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.Legend = "Legend1";
            series4.Name = "Інтерполяція sin(x)";
            this.sinChart.Series.Add(series3);
            this.sinChart.Series.Add(series4);
            this.sinChart.Size = new System.Drawing.Size(1027, 432);
            this.sinChart.TabIndex = 0;
            this.sinChart.Text = "chart1";
            // 
            // sinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 453);
            this.Controls.Add(this.sinChart);
            this.Name = "sinForm";
            this.Text = "sin(x)";
            this.Load += new System.EventHandler(this.sinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sinChart;
    }
}