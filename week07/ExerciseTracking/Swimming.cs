using System;

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50 / 1000) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }
}
