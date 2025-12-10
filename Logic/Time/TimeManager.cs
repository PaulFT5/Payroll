using Timer = System.Windows.Forms.Timer;

namespace Payroll.Logic;

public static class TimeManager
{
    private static Timer _timer = new Timer();
    public static DateTime MockDate { get; private set; } = new DateTime(2000, 1, 1);
    public static bool IsRunning { get; private set; }

    // Event that pages can subscribe to (for UI updates)
    public static event Action<DateTime>? OnDateChanged;

    static TimeManager()
    {
        _timer.Interval = 1000; // 1 second = 1 simulated day
        _timer.Tick += Timer_Tick;
    }

    private static void Timer_Tick(object? sender, EventArgs e)
    {
        MockDate = MockDate.AddDays(1);
        OnDateChanged?.Invoke(MockDate);
    }

    private static void Start()
    {
        if (IsRunning) return;
        _timer.Start();
        IsRunning = true;
    }

    private static void Stop()
    {
        if (!IsRunning) return;
        _timer.Stop();
        IsRunning = false;
    }

    public static void Toggle()
    {
        if (IsRunning) Stop(); else Start();
    }

    public static bool IsWeekend()
    {
        return MockDate.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }
    
}