using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;

public class JourneySegment : BaseResource
{
    public Reference<JourneyWaypoint>? Origin { get; set; } // JourneyWaypoint
    public Reference<JourneyWaypoint>? Destination { get; set; } // JourneyWaypoint
    public Reference<Journey>? PartOf { get; set; } // Journey
    public Reference<TransportationMode>? JourneySegmentMode { get; set; } // TransportationMode (Flight, Vessel)
    public int? SequenceNumber { get; set; }
    public CodeableConcept? JourneySegmentRole { get; set; }

    public JourneySegment() : base()
    {
        ResourceType = "JourneySegment";
    }
}