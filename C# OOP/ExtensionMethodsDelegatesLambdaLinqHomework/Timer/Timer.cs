namespace Timer
{
    using System;
    using System.Threading;
    public delegate void TimerDlg();
    public class Timer
    {
        private readonly TimerDlg timerDlg;
        private bool count;
        private int interval;
        private Thread timerThread;

        public Timer(int interval, TimerDlg timerEvent)
        {
            
            this.Interval = interval;
            this.count = true;
            this.timerDlg = timerEvent;
            this.timerThread = new Thread(new ThreadStart(this.StartTimer));
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.interval = value;
            }
        }

        private void StartTimer()
        {
            while (this.count)
            {
                Thread.Sleep((int)interval);
                if (count)
                {
                    timerDlg();
                }
            }
        }

        public void Start()
        {
            timerThread.Start();
        }

        public void Stop()
        {
            this.count = false;
        }
    }
}