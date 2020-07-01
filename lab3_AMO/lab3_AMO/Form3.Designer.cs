namespace lab3_AMO
{
    partial class funcForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.funcChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.funcChart)).BeginInit();
            this.SuspendLayout();
            // 
            // funcChart
            // 
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 0.2D;
            chartArea1.AxisX.Maximum = 2D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.Maximum = 3D;
            chartArea1.AxisY.Minimum = -1D;
            chartArea1.Name = "ChartArea1";
            this.funcChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.funcChart.Legends.Add(legend1);
            this.funcChart.Location = new System.Drawing.Point(12, 12);
            this.funcChart.Name = "funcChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Функція";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.Name = "Інтерполяція функції";
            this.funcChart.Series.Add(series1);
            this.funcChart.Series.Add(series2);
            this.funcChart.Size = new System.Drawing.Size(1028, 432);
            this.funcChart.TabIndex = 0;
            this.funcChart.Text = "chart1";
            // 
            // funcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 453);
            this.Controls.Add(this.funcChart);
            this.Name = "funcForm";
            this.Text = "Функція";
            this.Load += new System.EventHandler(this.funcForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart funcChart;
    }
}