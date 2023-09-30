using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class FirstTask : Form
    {
        PasswordController controller = new PasswordController();
        private Stopwatch stopwatch = new Stopwatch();
        public FirstTask()
        {
            InitializeComponent();
        }

        private void FlashInputPasswordLengthBox(object sender, EventArgs e)
        {
            InputPasswordLengthBox.Text = "";
        }

        private void CheckForInput(object sender, EventArgs e)
        {
            var isNumber = int.TryParse(InputPasswordLengthBox.Text, out _);
            if (!isNumber)
            {
                InputPasswordLengthBox.Text = "Input password length";
            }
        }

        private void GenerateDistributionBar(Dictionary<char, int> distribution)
        {
            CharsDistributionChart.Series["Character"].Points.Clear();
            var pointer = distribution.GetEnumerator();
            for(int index = 0; index < distribution.Count+1; index++)
            {
                var pair = pointer.Current;
                CharsDistributionChart.Series["Character"].Points.AddY(pair.Value);
                CharsDistributionChart.Series["Character"].Points[index].AxisLabel = pair.Key.ToString();
                pointer.MoveNext();
            }
            pointer.Dispose();
        }
        
        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            var isCorrect = int.TryParse(InputPasswordLengthBox.Text, out int length);
            if (isCorrect)
            {
                Random _rand = new Random();
                controller.GeneratePassword(length, ref _rand);
                GeneratedPasswordBox.Text = controller.Password;
                GenerateDistributionBar(controller.AnalyzeCharsDistribution());
            }
        }

        private void UpdateTimeOfPasswordCrack(Stopwatch stopwatch)
        {
            GeneratePasswordButton.Enabled = false;
            while (stopwatch.IsRunning)
            {
                TimeToTakePasswordBox.Text = stopwatch.Elapsed +
                Environment.NewLine + controller.AttemptsToTakePassword + @" attempts";
            }
            GeneratePasswordButton.Enabled = true;
            AnalyzeTimeButton.Enabled = true;
        }


        private void AnalyzeTimeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(controller.Password))
            {
                AnalyzeTimeButton.Enabled = false;
                stopwatch.Restart();
                Task.Run(() => controller.AnalyseTimeToTakePasswordAsync(stopwatch));
                Task.Run(() => UpdateTimeOfPasswordCrack(stopwatch));
            }
        }

        private void CountAverageTimeButton_Click(object sender, EventArgs e)
        {
            var SecondForm = new SecondTask();
            SecondForm.Show();
        }
    }
}