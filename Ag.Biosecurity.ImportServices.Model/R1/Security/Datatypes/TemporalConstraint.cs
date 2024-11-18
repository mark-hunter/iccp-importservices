namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// TemporalConstrain: Identifies a duration in time (based on day-of-week + time-of-day) that is used to qualify
/// a Permission (or some other security aspect).
/// </summary>
public class TemporalConstraint
{
    /// <summary>
    /// AllowableDay: Identifies a day-of-the-week for which this temporal constraint is valid. If no day-of-the-week
    /// is specified, then it assumes that NO days are valid.
    /// </summary>
    public DayOfWeek? AllowableDay { get; set; }
    /// <summary>
    /// AllowableStartTime: Identifies a time-of-day at which this temporal constraint is valid from. If no time-of-day
    /// is specified, then it should be assumed that no times are valid.
    /// </summary>
    public TimeOfDay? AllowableStartTime { get; set; }
    /// <summary>
    /// AllowableEndTime: Identifies a time-of-day at which this temporal constraint is valid until. If no time-of-day
    /// is specified, then it should be assumed that no times are valid.
    /// </summary>
    public TimeOfDay? AllowableEndTime { get; set; }
}