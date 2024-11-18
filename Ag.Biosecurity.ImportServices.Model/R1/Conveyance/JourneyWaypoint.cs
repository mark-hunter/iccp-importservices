using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;

/// <summary>
/// A JourneyWaypoint is used to link the JourneySegment to the Entity::Location or Entity::Site instances which are the
/// origin and destination points. 
/// </summary>
public class JourneyWaypoint : BaseResource
{
    /// <summary>
    /// A reference to the actual (physical) location, captured as either an Entity::Location or Entity::Site. 
    /// </summary>
    public Reference<Location>? WaypointLocation { get; set; } 
    /// <summary>
    /// A reference to the previous (physical) location, captured as either an Entity::Location or Entity::Site.
    /// Typically, this value should correlate to the JourneySegment::Origin field when this waypoint is set as the
    /// JourneySegment::Destination field.
    /// </summary>
    public JourneyWaypoint? PreviousWaypoint { get; set; }
    /// <summary>
    /// A reference to the previous (physical) location, captured as either an Entity::Location or Entity::Site.
    /// Typically, this value should correlate to the JourneySegment::Destination field when this waypoint is set as the
    /// JourneySegment::Origin field.
    /// </summary>
    public JourneyWaypoint? NextWaypoint { get; set; }
    /// <summary>
    /// The WaypointRole captures the nature or function of the waypoint with respect to the overall journey the
    /// (imported) goods have traversed - including "Port of Loading", "Destination Port", etc. See
    /// ValueSets/JourneyWaypointRoleTypeEnum and ValueSets/JourneyWaypointRoleTypeFactory for the values.
    /// </summary>
    public CodeableConcept? WaypointRole { get; set; }
    /// <summary>
    /// The WaypointName captures a user-friendly name associated Entity::Site or Entity::Location. Note that the Waypoint::Role
    /// attribute includes a user-friendly description of the Role of the waypoint.
    /// </summary>
    public string? WaypointName { get; set; }

    public JourneyWaypoint() : base()
    {
        ResourceType = GetType().Name;
    }
}