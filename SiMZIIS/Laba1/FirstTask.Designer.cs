namespace Laba1
{
    partial class FirstTask
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CharsDistributionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputPasswordLengthBox = new System.Windows.Forms.TextBox();
            this.GeneratedPasswordBox = new System.Windows.Forms.TextBox();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.TimeToTakePasswordBox = new System.Windows.Forms.TextBox();
            this.AnalyzeTimeButton = new System.Windows.Forms.Button();
            this.CountAverageTimeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharsDistributionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CharsDistributionChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 11;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea1.AxisX.LabelStyle.Angle = -90;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.MaximumAutoSize = 90F;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.CharsDistributionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CharsDistributionChart.Legends.Add(legend1);
            this.CharsDistributionChart.Location = new System.Drawing.Point(12, -3);
            this.CharsDistributionChart.Name = "CharsDistributionChart";
            this.CharsDistributionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Character";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.CharsDistributionChart.Series.Add(series1);
            this.CharsDistributionChart.Size = new System.Drawing.Size(1880, 727);
            this.CharsDistributionChart.TabIndex = 0;
            this.CharsDistributionChart.Text = "Distribution";
            title1.BackColor = System.Drawing.Color.Aquamarine;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Characters distribution";
            title1.Text = "Characters distribution";
            this.CharsDistributionChart.Titles.Add(title1);
            // 
            // InputPasswordLengthBox
            // 
            this.InputPasswordLengthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputPasswordLengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPasswordLengthBox.Location = new System.Drawing.Point(12, 765);
            this.InputPasswordLengthBox.Multiline = true;
            this.InputPasswordLengthBox.Name = "InputPasswordLengthBox";
            this.InputPasswordLengthBox.Size = new System.Drawing.Size(280, 40);
            this.InputPasswordLengthBox.TabIndex = 1;
            this.InputPasswordLengthBox.Text = "Input password length";
            this.InputPasswordLengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputPasswordLengthBox.WordWrap = false;
            this.InputPasswordLengthBox.Click += new System.EventHandler(this.FlashInputPasswordLengthBox);
            this.InputPasswordLengthBox.MouseLeave += new System.EventHandler(this.CheckForInput);
            // 
            // GeneratedPasswordBox
            // 
            this.GeneratedPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GeneratedPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratedPasswordBox.Location = new System.Drawing.Point(324, 765);
            this.GeneratedPasswordBox.Multiline = true;
            this.GeneratedPasswordBox.Name = "GeneratedPasswordBox";
            this.GeneratedPasswordBox.Size = new System.Drawing.Size(1568, 40);
            this.GeneratedPasswordBox.TabIndex = 2;
            this.GeneratedPasswordBox.Text = "Generated password";
            this.GeneratedPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GeneratedPasswordBox.WordWrap = false;
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePasswordButton.Location = new System.Drawing.Point(12, 833);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(1880, 52);
            this.GeneratePasswordButton.TabIndex = 3;
            this.GeneratePasswordButton.Text = "Generate password";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // TimeToTakePasswordBox
            // 
            this.TimeToTakePasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeToTakePasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeToTakePasswordBox.Location = new System.Drawing.Point(12, 972);
            this.TimeToTakePasswordBox.Multiline = true;
            this.TimeToTakePasswordBox.Name = "TimeToTakePasswordBox";
            this.TimeToTakePasswordBox.Size = new System.Drawing.Size(1715, 40);
            this.TimeToTakePasswordBox.TabIndex = 4;
            this.TimeToTakePasswordBox.Text = "TimeToTakePassword";
            this.TimeToTakePasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeToTakePasswordBox.WordWrap = false;
            // 
            // AnalyzeTimeButton
            // 
            this.AnalyzeTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyzeTimeButton.Location = new System.Drawing.Point(12, 911);
            this.AnalyzeTimeButton.Name = "AnalyzeTimeButton";
            this.AnalyzeTimeButton.Size = new System.Drawing.Size(1715, 37);
            this.AnalyzeTimeButton.TabIndex = 5;
            this.AnalyzeTimeButton.Text = "Analyze time to take password";
            this.AnalyzeTimeButton.UseVisualStyleBackColor = true;
            this.AnalyzeTimeButton.Click += new System.EventHandler(this.AnalyzeTimeButton_Click);
            // 
            // CountAverageTimeButton
            // 
            this.CountAverageTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountAverageTimeButton.Location = new System.Drawing.Point(1748, 911);
            this.CountAverageTimeButton.Name = "CountAverageTimeButton";
            this.CountAverageTimeButton.Size = new System.Drawing.Size(144, 101);
            this.CountAverageTimeButton.TabIndex = 6;
            this.CountAverageTimeButton.Text = "Count average time";
            this.CountAverageTimeButton.UseVisualStyleBackColor = true;
            this.CountAverageTimeButton.Click += new System.EventHandler(this.CountAverageTimeButton_Click);
            // 
            // FirstTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.CountAverageTimeButton);
            this.Controls.Add(this.AnalyzeTimeButton);
            this.Controls.Add(this.TimeToTakePasswordBox);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.GeneratedPasswordBox);
            this.Controls.Add(this.InputPasswordLengthBox);
            this.Controls.Add(this.CharsDistributionChart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FirstTask";
            this.Text = "CharactersDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.CharsDistributionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CountAverageTimeButton;

        private System.Windows.Forms.Button AnalyzeTimeButton;

        private System.Windows.Forms.TextBox TimeToTakePasswordBox;

        private System.Windows.Forms.Button GeneratePasswordButton;

        private System.Windows.Forms.TextBox GeneratedPasswordBox;

        private System.Windows.Forms.TextBox InputPasswordLengthBox;

        private System.Windows.Forms.DataVisualization.Charting.Chart CharsDistributionChart;

        #endregion
    }
}