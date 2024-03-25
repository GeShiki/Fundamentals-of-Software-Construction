namespace assignment4._2
{
    public delegate void TimeHandler(object sender, int i);
    public class Clock
    {
        public event TimeHandler OnTime;
        public void Time(int i)
        {
            Console.WriteLine($"开始计时{i}秒。");
            OnTime(this, i);
        }
    }
    public class Timer
    {
        public Clock clock = new Clock();
        public Timer()
        {
            clock.OnTime += Tick;
            clock.OnTime += Alarm;
        }
        public void Tick(object sender, int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("嘀嗒");
            }
        }
        public void Alarm(object sender, int i)
        {
            for (int j = 0; j < i; j++)
            {
                if (j == i - 1)
                {
                    Console.WriteLine("响铃");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.clock.Time(5);
        }
    }
}