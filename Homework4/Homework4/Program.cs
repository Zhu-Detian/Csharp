using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework4
{
    public delegate void AlarmHandler(object sender, ClockEventArgs args);
    public delegate void TickHandler(object sender, ClockEventArgs args);

    public class ClockEventArgs
    {
        public int currentTime { get; set; }
        public ClockEventArgs(int t)
        {
            currentTime = t;
        }
    }

    public class Clock
    {
        private int currentTime = 0;
        private int[] alarmTimes;
        public event TickHandler Tick;
        public event AlarmHandler Alarm;
        public void SetAlarmTime(params int[] times)
        {
            alarmTimes = times;
            Array.Sort(alarmTimes);
        }
        public void StartTime(int cycle)
        {
            currentTime = 0;
            int i = 0;
            for (; currentTime <= cycle; currentTime++)
            {
                ClockEventArgs args = new ClockEventArgs(currentTime);
                Tick(this, args);
                if (i < alarmTimes.Length)
                {
                    if (alarmTimes[i] == currentTime)
                    {
                        Alarm(this, args);
                    }
                    if (alarmTimes[i] < currentTime) i++;
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finished.");
        }
    }
    public class  Example
    {
        public Clock aclock = new Clock();
        public Example()
        {
            aclock.Tick += OnTick;
            aclock.Alarm += OnAlarm;
            void OnTick(object sender,ClockEventArgs args)
            {
                Console.WriteLine($"Tick {args.currentTime} times");
            }
            void OnAlarm(object sender,ClockEventArgs args)
            {
                Console.WriteLine($"Alarm!Current Time is : {args.currentTime} ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example1 = new Example();
            example1.aclock.SetAlarmTime(4,9,15);
            example1.aclock.StartTime(20);
        }
    }
}
