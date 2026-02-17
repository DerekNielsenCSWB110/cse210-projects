using System;
using System.Collections.Generic;

// -------------------- Base Class --------------------
abstract class Activity
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

    public abstract double GetDistance();  // miles or km
    public abstract double GetSpeed();     // mph or kph
    public abstract double GetPace();      // min per mile or km

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}

// -------------------- Running --------------------
class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / _distance;
}

// -------------------- Cycling --------------------
class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * GetMinutes()) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}

// -------------------- Swimming --------------------
class Swimming : Activity
{
    private int _laps;  // number of laps
    private const double LapLengthMeters = 50;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert meters to miles
        return _laps * LapLengthMeters / 1000 * 0.62;
    }

    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / GetDistance();
}

// -------------------- Main Program --------------------
class Program
{
    static void Main()
    {
        // Create sample activities
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2026, 2, 17), 30, 3.0),
            new Cycling(new DateTime(2026, 2, 17), 45, 12.0),
            new Swimming(new DateTime(2026, 2, 17), 60, 40)
        };

        // Iterate and display summaries using polymorphism
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
