using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using ThreadState = System.Threading.ThreadState;

namespace Laba1;

public partial class SecondTask : Form
{
    private Object _lock = new Object();
    private int passwordMaxLength;
    Task[] tasks = new Task[5];
    public SecondTask()
    {
        InitializeComponent();
    }

    private void CountAverageForLength(int length)
    {
        List<TimeSpan> spanList = new List<TimeSpan>();
        PasswordTakingTimeHandler handler = new PasswordTakingTimeHandler(ref spanList, length);
        for(int index=0; index<tasks.Length; index++)
        {
            tasks[index] = Task.Factory.StartNew(() => CalculateTimeForHandler(handler));
            Thread.Sleep(10);
        }

        Task.Factory.ContinueWhenAll(tasks, AddPoint => AddPointToChart(AverageTime(spanList), length));
    }

    private void CalculateTimeForHandler(PasswordTakingTimeHandler handler)
    {
        PasswordController controller = new PasswordController();
        Random _rand = new Random();
        controller.GeneratePassword(handler.passwordLength, ref _rand);
        var timer = controller.AnalyseTimeToTakePasswordSync(ref _rand);
        lock (_lock)
        {
            handler.spanList.Add(timer.Elapsed);
        }
    }

    public static TimeSpan AverageTime(IEnumerable<TimeSpan> spans)
    {
        double doubleAverageTicks = spans.Average(timeSpan => timeSpan.Ticks);
        long longAverageTicks = Convert.ToInt64(doubleAverageTicks);
        return new TimeSpan(longAverageTicks);
    }
        


    public class PasswordTakingTimeHandler
    {
        public List<TimeSpan> spanList;
        public int passwordLength;

        public PasswordTakingTimeHandler(ref List<TimeSpan> spanList, int passLength)
        {
            this.spanList = spanList;
            passwordLength = passLength;
        }

    }

    private void GenerateChartButton_Click(object sender, EventArgs e)
    {
        var isCorrect = int.TryParse(PasswordLengthBox.Text, out int length);
        if (isCorrect)
        {
            passwordMaxLength = length;
            GenerateChartButton.Enabled = false;
            PasswordLengthBox.Enabled = false;
            AverageTimeChart.Series["Time to take password"].Points.Clear();
            for (int i = 1; i <= length; i++)
            {
                CountAverageForLength(i);
            }
        }
        
    }

    private void CheckPointsCount()
    {
        if (AverageTimeChart.Series["Time to take password"].Points.Count == passwordMaxLength)
        {
            GenerateChartButton.Enabled = true;
            PasswordLengthBox.Enabled = true;
        }
        
    }

    private void AddPointToChart(TimeSpan span, int length)
    {
        Console.WriteLine($"{span.ToString()} : {length}");
        AverageTimeChart.Series["Time to take password"].Points.AddY(span.Ticks);
        AverageTimeChart.Series["Time to take password"].Points[length - 1].Name = span.ToString();
        AverageTimeChart.Series["Time to take password"].Points[length-1].AxisLabel = length.ToString();
        CheckPointsCount();
    }
    
    private void FlashInputPasswordLengthBox(object sender, EventArgs e)
    {
        PasswordLengthBox.Text = "";
    }

    private void CheckForInput(object sender, EventArgs e)
    {
        var isNumber = int.TryParse(PasswordLengthBox.Text, out _);
        if (!isNumber)
        {
            PasswordLengthBox.Text = "Input password length";
        }
    }
}