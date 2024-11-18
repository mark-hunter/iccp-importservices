using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The Organisation resource is a specialisation of the Entity.Entity resource and represents either an Organisation
/// (within the context of, say, the ASIC or ATO) or a Business Unit of an Organisation. 
/// </summary>
public class Organisation : Entity
{
    public List<Site> Sites { get; set; }
    public List<Name> BusinessNames { get; set; }
    public Organisation()
    {
        ResourceType = GetType().Name;
        TypeOfEntity = EntityType.Organisation;
        Sites = new List<Site>();
        BusinessNames = new List<Name>();
    }


}