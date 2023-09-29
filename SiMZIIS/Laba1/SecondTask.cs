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
    List<Task<Stopwatch>> tasks = new List<Task<Stopwatch>>();
    public SecondTask()
    {
        InitializeComponent();
    }

    private void CountAverageForLength(int length)
    {
        tasks.Clear();
        Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
        List<TimeSpan> spanList = new List<TimeSpan>();
        PasswordTakingTimeHandler handler = new PasswordTakingTimeHandler(ref spanList, length);
        for(int index=0; index<5; index++)
        {
            tasks.Add(CalculateTimeForHandler(handler));
            tasks[index].RunSynchronously();
            tasks[index].ContinueWith(span =>
            {
                spanList.Add(span.Result.Elapsed);
            });
        }
        
        Console.WriteLine($"Average is :{AverageTime(spanList)}");

    }

    private Task<Stopwatch> CalculateTimeForHandler(PasswordTakingTimeHandler handler)
    {
        PasswordController controller = new PasswordController();
        controller.GeneratePassword(handler.passwordLength);
        return new Task<Stopwatch>(() =>controller.AnalyseTimeToTakePasswordSync());
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
        CountAverageForLength(3);
        Console.WriteLine("Some Info");
    }
}