using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        Running running = new("03 Nov 2022", 30, 3);
        activities.Add(running);

        StationaryBicycles bike = new("05 Oct 2024", 30, 10);
        activities.Add(bike);

        Swimming swimming = new("15 Dec 2024", 20, 15);
        activities.Add(swimming);
        
        foreach(Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}