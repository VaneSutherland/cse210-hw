using System;

public class Running : Activity
{
    public double Distance { get; set; } 
    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationInMinutes / Distance;
    }
}
