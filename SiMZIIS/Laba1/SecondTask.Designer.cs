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
        this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.GenerateChartButton = new System.Windows.Forms.Button();
        this.PasswordLengthBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
        this.SuspendLayout();
        // 
        // chart1
        // 
        chartArea1.Name = "ChartArea1";
        this.chart1.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        this.chart1.Legends.Add(legend1);
        this.chart1.Location = new System.Drawing.Point(12, 12);
        this.chart1.Name = "chart1";
        series1.ChartArea = "ChartArea1";
        series1.Legend = "Legend1";
        series1.Name = "Time to take password";
        this.chart1.Series.Add(series1);
        this.chart1.Size = new System.Drawing.Size(1880, 662);
        this.chart1.TabIndex = 0;
        this.chart1.Text = "chart1";
        // 
        // GenerateChartButton
        // 
        this.GenerateChartButton.Location = new System.Drawing.Point(24, 712);
        this.GenerateChartButton.Name = "GenerateChartButton";
        this.GenerateChartButton.Size = new System.Drawing.Size(75, 23);
        this.GenerateChartButton.TabIndex = 1;
        this.GenerateChartButton.Text = "Generate chart";
        this.GenerateChartButton.UseVisualStyleBackColor = true;
        this.GenerateChartButton.Click += new System.EventHandler(this.GenerateChartButton_Click);
        // 
        // PasswordLengthBox
        // 
        this.PasswordLengthBox.Location = new System.Drawing.Point(131, 715);
        this.PasswordLengthBox.Name = "PasswordLengthBox";
        this.PasswordLengthBox.Size = new System.Drawing.Size(100, 20);
        this.PasswordLengthBox.TabIndex = 2;
        this.PasswordLengthBox.Text = "Input maximal length of password";
        // 
        // SecondTask
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1904, 1041);
        this.Controls.Add(this.PasswordLengthBox);
        this.Controls.Add(this.GenerateChartButton);
        this.Controls.Add(this.chart1);
        this.Name = "SecondTask";
        this.Text = "SecondTask";
        ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button GenerateChartButton;
    private System.Windows.Forms.TextBox PasswordLengthBox;

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    #endregion
}