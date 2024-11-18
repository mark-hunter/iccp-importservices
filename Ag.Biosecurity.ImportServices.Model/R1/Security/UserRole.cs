using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;
using Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement;

public class UserRole : BaseResource
{
    public List<AuthorisationRole> ContainedRoles { get; set; } = new List<AuthorisationRole>();
    public List<Reference<EntityRole>> RoleContext { get; set; } = new List<Reference<EntityRole>>();
    
    public string? RoleName { get; set; }
    
    public UserRole() : base()
    {
        ResourceType = GetType().Name;
        ContainedRoles = new List<AuthorisationRole>();
        RoleContext = new List<Reference<EntityRole>>();
    }

}