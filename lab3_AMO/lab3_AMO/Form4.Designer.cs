namespace lab3_AMO
{
    partial class mistakeForm
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
            this.mistakeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mistakeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mistakeChart
            // 
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.Title = "R(x)";
            chartArea1.Name = "ChartArea1";
            this.mistakeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mistakeChart.Legends.Add(legend1);
            this.mistakeChart.Location = new System.Drawing.Point(0, 0);
            this.mistakeChart.Name = "mistakeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Похибка інтерполяції";
            this.mistakeChart.Series.Add(series1);
            this.mistakeChart.Size = new System.Drawing.Size(1040, 441);
            this.mistakeChart.TabIndex = 0;
            this.mistakeChart.Text = "chart1";
            // 
            // mistakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 453);
            this.Controls.Add(this.mistakeChart);
            this.Name = "mistakeForm";
            this.Text = "Похибка";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mistakeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mistakeChart;
    }
}