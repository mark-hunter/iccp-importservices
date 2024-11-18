using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// AuthorisationRole: The building block of the Roles management system -> it is used to build the role-map for a
/// given UserRole with respect to the authorisation services. It may directly contain permissions as well as other
/// AuthorisationRole instances.
/// </summary>
public class AuthorisationRole : DataTypeMetadata
{
    /// <summary>
    /// ContainedRoles: The list of other AuthorisationRole instances that this instance encapsulates (yielding, for
    /// all intents and purposes, a "union" of all the associated permissions contained within those roles. 
    /// </summary>
    public List<AuthorisationRole> ContainedRoles { get; set; } = new List<AuthorisationRole>();
    /// <summary>
    /// ContextualPermissions: A list of all the ContextualPermissions associated with this AuthorisationRole. Note that
    /// Permissions are, by definition, cumulative (additive in nature). 
    /// </summary>
    public List<ContextualPermission> ContextualPermissions { get; set; } = new List<ContextualPermission>();
    /// <summary>
    /// Permissions: A list of all the Permissions associated with this AuthorisationRole. Note that
    /// Permissions are, by definition, cumulative (additive in nature). 
    /// </summary>
    public List<Permission> Permissions { get; set; } = new List<Permission>();
    
    public AuthorisationRole() : base()
    {
        
    }
}