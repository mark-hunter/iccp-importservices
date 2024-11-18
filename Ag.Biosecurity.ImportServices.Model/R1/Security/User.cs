using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement;

/// <summary>
/// User: Encapsulates an "account" or "login" method for a given Client. A Client may have multiple User accounts associated
/// to them, each utilising a different CredentialType or 
/// </summary>
public class User : BaseResource
{
    public CredentialType? UserCredentialType { get; set; }
    public IdentityProofingLevelType? IdentityAssuranceLevel { get; set; }
    public UserType? UserType { get; set; }
    public Reference<UserRole>? UserRole { get; set; }
    public string? UserName { get; set; }

    public User() : base()
    {
        ResourceType = GetType().Name;
    }
}