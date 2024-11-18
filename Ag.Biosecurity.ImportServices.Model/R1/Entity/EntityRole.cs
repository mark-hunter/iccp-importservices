using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Regulatory;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The EntityRole resource captures the function (or role) of an Entity with respect to an identified Import Services
/// activity. 
/// </summary>
public class EntityRole : BaseResource
{
    public EntityRoleType? RoleType { get; set; }
    public Reference<Entity>? FulfillingEntity{ get; set; }
    public List<Reference<Service>> SupportedServices { get; set; } 
    public List<Site> SupportedSites { get; set; }
    public List<Reference<ApprovedArrangement>> RegulatedApprovals{ get; set; } 
    public List<Reference<Accreditation>> SupportedAccreditations{ get; set; } 
    /// <summary>
    /// A list of contact points that may be used to (electronically) communicate with the entity fulfilling the role.
    /// Note that, in some cases, a contact point may also be specified for the Entity itself (i.e. a personal mobile
    /// phone) version a contact point used for business related (role) activities (e.g. a work mobile phone)
    /// </summary>
    public List<ContactPoint> ContactPoints { get; set; }

    public EntityRole() : base()
    {
        ResourceType = GetType().Name;
        SupportedServices = new List<Reference<Service>>();
        SupportedSites = new List<Site>();
        SupportedAccreditations = new List<Reference<Accreditation>>();
        RegulatedApprovals = new List<Reference<ApprovedArrangement>>();
        ContactPoints = new List<ContactPoint>();
    }
}