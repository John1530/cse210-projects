using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetActivityName()
    {
        return this.GetType().Name;
    }

    public virtual string GetSummary()
    {
        return
        $"{_date:dd MMM yyyy} {GetActivityName()} ({_minutes} min)\n" +
        $"  Distance: {GetDistance():0.00} km\n" +
        $"  Speed:    {GetSpeed():0.00} kph\n" +
        $"  Pace:     {GetPace():0.00} min/km\n";
    }
}