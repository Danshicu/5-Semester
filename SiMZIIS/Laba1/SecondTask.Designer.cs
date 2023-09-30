using System.ComponentModel;

namespace Laba1;

partial class SecondTask
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.AverageTimeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.GenerateChartButton = new System.Windows.Forms.Button();
        this.PasswordLengthBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.AverageTimeChart)).BeginInit();
        this.SuspendLayout();
        chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
        chartArea1.Name = "ChartArea1";
        this.AverageTimeChart.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        this.AverageTimeChart.Legends.Add(legend1);
        this.AverageTimeChart.Location = new System.Drawing.Point(12, 12);
        this.AverageTimeChart.Name = "AverageTimeChart";
        series1.ChartArea = "ChartArea1";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series1.Legend = "Legend1";
        series1.Name = "Time to take password";
        this.AverageTimeChart.Series.Add(series1);
        this.AverageTimeChart.Size = new System.Drawing.Size(1880, 662);
        this.AverageTimeChart.TabIndex = 0;
        this.AverageTimeChart.Text = "chart1";
        this.GenerateChartButton.Location = new System.Drawing.Point(24, 712);
        this.GenerateChartButton.Name = "GenerateChartButton";
        this.GenerateChartButton.Size = new System.Drawing.Size(75, 23);
        this.GenerateChartButton.TabIndex = 1;
        this.GenerateChartButton.Text = "Generate chart";
        this.GenerateChartButton.UseVisualStyleBackColor = true;
        this.GenerateChartButton.Click += new System.EventHandler(this.GenerateChartButton_Click);
        this.PasswordLengthBox.Location = new System.Drawing.Point(131, 715);
        this.PasswordLengthBox.Name = "PasswordLengthBox";
        this.PasswordLengthBox.Size = new System.Drawing.Size(100, 20);
        this.PasswordLengthBox.TabIndex = 2;
        this.PasswordLengthBox.Text = "Input maximal length of password";
        this.PasswordLengthBox.Click += new System.EventHandler(this.FlashInputPasswordLengthBox);
        this.PasswordLengthBox.MouseLeave += new System.EventHandler(this.CheckForInput);
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1904, 1041);
        this.Controls.Add(this.PasswordLengthBox);
        this.Controls.Add(this.GenerateChartButton);
        this.Controls.Add(this.AverageTimeChart);
        this.Name = "SecondTask";
        this.Text = "SecondTask";
        ((System.ComponentModel.ISupportInitialize)(this.AverageTimeChart)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button GenerateChartButton;
    private System.Windows.Forms.TextBox PasswordLengthBox;

    private System.Windows.Forms.DataVisualization.Charting.Chart AverageTimeChart;

    #endregion
}