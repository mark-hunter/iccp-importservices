namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// TimeOfDay: A simple class to capture a time-of-day value. There may be an equivalent in the C# world that I am
/// not familiar with.
/// </summary>
public class TimeOfDay
{
    /// <summary>
    /// Hours: The hour of the day, in 24-hour time.
    /// </summary>
    public int Hours { get; set; }
    /// <summary>
    /// Minutes: The minute of the hour.
    /// </summary>
    public int Minutes { get; set; }
    /// <summary>
    /// Seconds: The second of the minute --> only really needed completeness and unlikely to be used as part of the
    /// permission's framework.
    /// </summary>
    public int Seconds { get; set; }
    
    public TimeOfDay()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }

    public TimeOfDay(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = 0;
    }
}