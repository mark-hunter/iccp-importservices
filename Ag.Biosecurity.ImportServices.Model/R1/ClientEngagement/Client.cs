using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement;

public class Client : EntityRole
{
    public Reference<User>? PrimaryPersona { get; set; }
    public List<Reference<User>> SecondaryPersonas { get; set; } = new List<Reference<User>>();

    public Client() : base()
    {
        ResourceType = GetType().Name;
    }
}