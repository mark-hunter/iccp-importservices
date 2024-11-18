namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// EffectiveDateTime: Provides a temporal constraint to an attribute or class - bounded by the StartDate and EndDate.
/// The times are inclusive of the bounding instants.
/// </summary>
public class EffectiveDateTime
{
    /// <summary>
    /// The starting instant of the effective period. The instant is INCLUDED within the effective period.
    /// </summary>
    public DateTime? StartDate { get; set; }
    /// <summary>
    /// The ending instant of the effective period. The instant is INCLUDED within the effective period.
    /// </summary>
    public DateTime? EndDate { get; set; }
}