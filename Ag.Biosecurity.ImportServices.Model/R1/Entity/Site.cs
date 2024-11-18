using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The Site links an EntityRole (a role being performed by an organisation or person) and the Location at which
/// the role/function is being performed. 
/// </summary>
public class Site : BaseResource
{
    /// <summary>
    /// The Roles (business context) being performed at the Site (location).
    /// </summary>
    public List<SiteRoleType> SiteRoles { get; set; } = new List<SiteRoleType>();
    /// <summary>
    /// The site (location) type – from a functional perspective 
    /// </summary>
    public List<SiteType> SiteTypes { get; set; } = new List<SiteType>();
    /// <summary>
    /// A list of names by which the Site is known, in no particular order (and with uniqueness not guaranteed).
    /// </summary>
    public List<string> SiteNames { get; set; } = new List<string>();
    /// <summary>
    /// A reference to that actual location where the site is located.
    /// </summary>
    public Reference<Location>? SiteLocation { get; set; }
    /// <summary>
    /// A list of ContactPoints that may be used to communicate (electronically) with personnel (or systems) at that site.
    /// </summary>
    public List<ContactPoint> ContactPoints { get; set; } = new List<ContactPoint>();
    
    public Site() : base()
    {
        ResourceType = GetType().Name;
    }
}