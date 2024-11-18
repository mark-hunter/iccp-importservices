using Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// The SoureceMetadta datatype encapsulates core Resource meta information such as security details and source system
/// information.
/// </summmary>
public class ResourceMetadata : DataTypeMetadata
{
    /// <summary>
    /// 
    /// </summary>
    public List<SecurityMarker> SecurityMarkers { get; set; } = new List<SecurityMarker>();
    public Uri? sourceSystem { get; set; }
    
    public ResourceMetadata() : base()
    {

    }
}