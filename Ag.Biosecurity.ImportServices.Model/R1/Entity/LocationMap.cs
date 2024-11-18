using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

public class LocationMap : BaseResource
{

    public List<Reference<Location>> Locations { get; set; }
    public CodeableConcept? MapType { get; set; }
    public CodeableConcept? MapFunction { get; set; }
    public List<Name> MapNames { get; set; }
    
    public LocationMap() : base()
    {
        Locations = new List<Reference<Location>>();
        MapNames = new List<Name>();
    }
}