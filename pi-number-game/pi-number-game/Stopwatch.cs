using System;
using System.Diagnostics;
using System.Windows.Threading;


namespace pi_number_game
{
    internal class StopwatchEvent
    {
        private DispatcherTimer timer;
        private Stopwatch stopWatch;
        private string currentTime;

        public StopwatchEvent()
        {
            timer = new DispatcherTimer();
            stopWatch = new Stopwatch();
            currentTime = string.Empty;
        }
        public void Run()
        {
            stopWatch.Start();
            timer.Tick += new EventHandler(Tick);
            timer.Start();
        }
        public void Stop()
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }
        public void Reset()
        {
            stopWatch.Reset();
            //StopwatchBlock.Text = "00:00:00";
        }
        private void Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                currentTime = String.Format("{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
               // StopwatchBlock.Text = currentTime;

            }
        }

    }
}
