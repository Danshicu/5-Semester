﻿using System;
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
        Task[] tasks = new Task[2];
        List<TimeSpan> times = new List<TimeSpan>();
        PasswordTakingTimeHandler handler = new PasswordTakingTimeHandler(times, length);
        for (int numberOfTask = 0; numberOfTask < tasks.Length; numberOfTask++)
        {
            tasks[numberOfTask] = Create(numberOfTask, handler);
            tasks[numberOfTask].Start();
        }

        Console.WriteLine("Start Waiting");
        while (times.Count != tasks.Length)
        {
            Thread.Sleep(100);
        }
        
        Console.WriteLine($"Average Time : {AverageTime(times).ToString()}");
        
        Console.WriteLine("Counted Tasks");
    }

    private void CountAndAddTimeOfTakingPassword(PasswordTakingTimeHandler handler, string name)
    {
        Console.WriteLine($"{name} started at {DateTime.Now.TimeOfDay.ToString()}");
        PasswordController controller = new PasswordController();
        controller.GeneratePassword(handler.passwordLength);
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        TimeSpan timeSpan = controller.AnalyseTimeToTakePasswordSync(stopwatch).Elapsed;
        handler.spanList.Add(timeSpan);
        
        Console.WriteLine($"Counted {name} with time {timeSpan.ToString()} At : {DateTime.Now.TimeOfDay.ToString()}");
    }

    private Task Create(int numberOfTask, PasswordTakingTimeHandler handler)
    {
        Console.WriteLine($"Task number {numberOfTask + 1} started from start method");
        Task newTask = new Task(() =>
                 CountAndAddTimeOfTakingPassword(handler, $"Task number {numberOfTask + 1}"));
        return newTask;
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
        Console.WriteLine("Some Shit");
    }
}