using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// The Permission class captures the set of DerivedPermissions and/or ExplicitPermissions, and the allowable times
/// that those permissions are valid. 
/// </summary>
public class Permission : DataTypeMetadata
{
    /// <summary>
    /// PermissionId: Encapsulates a system-wide unique value that can be used to reference and/or access the Permission.
    /// </summary>
    public string? PermissionId { get; set; }
    /// <summary>
    /// PermissionName: A human-friendly name for the Permission. It should be unique though this is not enforced.
    /// </summary>
    public string? PermissionName{ get; set; }
    /// <summary>
    /// DerivedPermissions: The set of permissions that utilise the "Data Compartment" concept to identity (group) resources
    /// (or classes) that are applicable to the specific permission actions contained therein.
    /// </summary>
    public List<DerivedPermission> DerivedPermissions { get; set; }
    /// <summary>
    /// ExplicitPermissions: The set of permissions that explicitly identify resources (or classes) and/or attributes
    /// that are applicable to the specific permission actions contained therein.
    /// </summary>
    public List<ExplicitPermission> ExplicitPermissions { get; set; }
    /// <summary>
    /// AllowableTimes: The temporal constraints associated with the Permission. If none are specified, then the Permission
    /// is valid at all times. If at least one temporal constraint is identified, then for ALL OTHER TIMES the Permissions
    /// should be considered invalid. 
    /// </summary>
    public List<TemporalConstraint> AllowableTimes { get; set; }
    
    public Permission() : base()
    {
        DerivedPermissions = new List<DerivedPermission>();
        ExplicitPermissions = new List<ExplicitPermission>();
        AllowableTimes = new List<TemporalConstraint>();
    }
}