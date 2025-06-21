using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),   // 30 minutos de correr, 3 millas
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),   // 45 minutos de ciclismo, 12 mph
            new Swimming(new DateTime(2022, 11, 3), 60, 40)     // 60 minutos de natación, 40 vueltas
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
