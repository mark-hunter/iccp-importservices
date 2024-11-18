using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The Person class is a specialisation of the Entity.Entity resource, and represents an actual human being. 
/// </summary>
public class Person : Entity
{
    public List<HumanName> Names { get; set; }
    public List<Address> Addresses { get; set; }

    public Person()
    {
        ResourceType = GetType().Name;
        TypeOfEntity = EntityType.Person;
        Names = new List<HumanName>();
        Addresses = new List<Address>();
    }


}