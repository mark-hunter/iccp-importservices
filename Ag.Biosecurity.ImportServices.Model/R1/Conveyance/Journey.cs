using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;
/// <summary>
/// The Journey details the individual segments of conveyance (transport) used to carry the goods from
/// their origin to the various key ports associated with the import activity.
/// </summary>
public class Journey : BaseResource
{
    /// <summary>
    /// A list of Journey Segments that capture the various trip segments undertaken by the goods as part of
    /// their trip from their origin to the identified endpoint within Australia.
    /// </summary>
    public List<Reference<JourneySegment>> JourneySegments { get; set; }
    /// <summary>
    /// The identified origin of the container/goods specified within the import declaration.
    /// </summary>
    public Reference<Location>? Origin {get; set;} 
    /// <summary>
    /// The identified port (or airport, etc.) where the goods were loaded into the conveyance method that
    /// eventually reaches the Australian import port/gateway.
    /// </summary>
    public Reference<Location>? PortOfLoading{ get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Reference<Location>? PortOfDischarge{ get; set; }
    /// <summary>
    /// The identified target port of the goods, where they will be removed from their internation conveyance
    /// method for distribution within the Australian continent.
    /// </summary>
    public Reference<Location>? DestinationPort{ get; set; }
    /// <summary>
    /// The identified target location (client residence, store, etc.) of the goods identified within the import
    /// declaration.
    /// </summary>
    public Reference<Location>? Destination {get; set;}
    /// <summary>
    /// The mechanism used (on the final import journey segment) to convey the goods into an Australian port.
    /// </summary>
    public TransportationMode? TransportMode{ get; set; } 

    public Journey() : base()
    {
        ResourceType = GetType().Name;
        JourneySegments = new List<Reference<JourneySegment>>();
    }
}