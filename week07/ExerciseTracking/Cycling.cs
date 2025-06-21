using System;

public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * (DurationInMinutes / 60);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
