using System;
using System.Diagnostics;
using System.Windows.Forms;

public class CountDownTimer : IDisposable
{
    public Stopwatch _stpWatch = new Stopwatch();

    public Action TimeChanged;
    public Action CountDownFinished;

    public bool IsRunning => timer.Enabled;

    public int StepMs
    {
        get => timer.Interval;
        set => timer.Interval = value;
    }

    private readonly Timer timer = new Timer();

    private TimeSpan _max = TimeSpan.FromMilliseconds(30000);

    public TimeSpan TimeLeft => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) > 0 ? TimeSpan.FromMilliseconds(_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) : TimeSpan.FromMilliseconds(0);

    private bool _mustStop => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) < 0;

    public string TimeLeftSStr => TimeLeft.ToString(@"%s");

    public string TimeLeftStr => TimeLeft.ToString(@"\mm\:ss");

    public string TimeLeftMsStr => TimeLeft.ToString(@"mm\:ss\.fff");

    private void TimerTick(object sender, EventArgs e)
    {
        TimeChanged?.Invoke();

        if (_mustStop)
        {
            _stpWatch.Stop();
            timer.Enabled = false;
            CountDownFinished?.Invoke();
        }
    }

    public CountDownTimer(int min, int sec)
    {
        SetTime(min, sec);
        Init();
    }

    public CountDownTimer(TimeSpan ts)
    {
        SetTime(ts);
        Init();
    }

    public CountDownTimer()
    {
        Init();
    }

    private void Init()
    {
        StepMs = 1000;
        timer.Tick += new EventHandler(TimerTick);
    }

    public void SetTime(TimeSpan ts)
    {
        _max = ts;
        TimeChanged?.Invoke();
    }

    public void SetTime(int min, int sec = 0)
    {
        SetTime(TimeSpan.FromSeconds((min * 60) + sec));
    }

    public void Start()
    {
        timer.Start();
        _stpWatch.Start();
    }

    public void Pause()
    {
        timer.Stop();
        _stpWatch.Stop();
    }

    public void Stop()
    {
        Reset();
        Pause();
    }

    public void Reset()
    {
        _stpWatch.Reset();
    }

    public void Restart()
    {
        _stpWatch.Reset();
        timer.Start();
    }

    public void Dispose()
    {
        timer.Dispose();
    }
}
