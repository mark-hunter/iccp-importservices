using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

public class Location : BaseResource
{
    public Location()
    {
        Addresses = new List<Address>();
        LocationNames = new List<Name>();
    }

    public List<Address> Addresses { get; set; }
    public List<Name> LocationNames { get; set; }
    public CodeableConcept? LocationType { get; set; }
    public GlobalPositionDetail? Position { get; set; }
    public Reference<LocationMap>? partOf { get; set; } // Reference to a LocationMap
}