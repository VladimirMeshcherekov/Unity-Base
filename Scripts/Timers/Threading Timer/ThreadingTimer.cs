using System;
using System.Timers;

public class ThreadingTimer
{
    private readonly Action _action;
    private readonly int _tickDelayInMilliseconds;
    private bool _isTimerWorking;
    private System.Timers.Timer _timer;

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        _action?.Invoke();
    }

    public ThreadingTimer(Action action, int tickDelayInMilliseconds, bool autoReset)
    {
        _action = action;
        _timer = new System.Timers.Timer(tickDelayInMilliseconds);
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = autoReset;
    }

    public void StartTimer()
    {
        _timer.Enabled = true;
    }

    public void StopTimer()
    {
        _timer.Enabled = false;
    }
}