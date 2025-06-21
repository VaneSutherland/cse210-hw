using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public double DurationInMinutes { get; set; }

    public Activity(DateTime date, double duration)
    {
        Date = date;
        DurationInMinutes = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({DurationInMinutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0} min per unit";
    }
}
