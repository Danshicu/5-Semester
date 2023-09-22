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
    
    public SecondTask()
    {
        InitializeComponent();
    }

    private void CountAverageForLength(int length)
    {
        Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
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

        public PasswordTakingTimeHandler(List<TimeSpan> spanList, int passLength)
        {
            this.spanList = spanList;
            this.passwordLength = passLength;
        }

    }

    private void GenerateChartButton_Click(object sender, EventArgs e)
    {
        CountAverageForLength(2);
        Console.WriteLine("Some Info");
    }
}