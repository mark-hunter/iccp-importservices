using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// ContextualPermission: A permission that contains instance level detail about objects (classes, resources) as
/// a mechanism of constraining what information is accessible by a given user.
/// </summary>
public class ContextualPermission : Permission
{
    /// <summary>
    /// DataOwner: A List of Entity's - where information pertaining to these Entity's - is used to scope the permissions
    /// set. The relationship between the Entity and the data in question needs to be derived by the policy-enforcement-point
    /// and policy-decision-point.
    /// </summary>
    public List<Reference<Entity.Entity>> DataOwner { get; set; } = new List<Reference<Entity.Entity>>();
    /// <summary>
    /// AreaOfAccess: A List of Locations/Sites - where information pertaining to those Sites/Locations - is used to scope the permissions
    /// set. The relationship between the Locations/Sites and the data in question needs to be derived by the policy-enforcement-point
    /// and policy-decision-point.
    /// </summary>
    public List<Reference<ServiceDeliveryArea>> AreaOfAccess { get; set; } = new List<Reference<ServiceDeliveryArea>>();
    /// <summary>
    /// EffectiveDate: A temporal qualification for the effectiveness of the permission.
    /// </summary>
    public EffectiveDateTime? EffectiveDate { get; set; } 
    
    public ContextualPermission() : base()
    {
        
    }
}