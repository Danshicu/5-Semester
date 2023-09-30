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
    Task[] tasks = new Task[5];
    public SecondTask()
    {
        InitializeComponent();
    }

    private void CountAverageForLength(int length)
    {
        //tasks.Clear();
        Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
        List<TimeSpan> spanList = new List<TimeSpan>();
        PasswordTakingTimeHandler handler = new PasswordTakingTimeHandler(ref spanList, length);
        for(int index=0; index<5; index++)
        {
            tasks[index] = Task.Factory.StartNew(() => CalculateTimeForHandler(handler));
            Thread.Sleep(10);
        }

        Task.Factory.ContinueWhenAll(tasks, consoleLog => Console.WriteLine($"Average is :{AverageTime(spanList)}"));
        
    }

    private void CalculateTimeForHandler(PasswordTakingTimeHandler handler)
    {
        Console.WriteLine("Created controller");
        PasswordController controller = new PasswordController();
        Random _rand = new Random();
        controller.GeneratePassword(handler.passwordLength, ref _rand);
        Console.WriteLine(controller.Password);
        Console.WriteLine("Want to get controller");
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
        CountAverageForLength(4);
        Console.WriteLine("Some Info");
    }
}