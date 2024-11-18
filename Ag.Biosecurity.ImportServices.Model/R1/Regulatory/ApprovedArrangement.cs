using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Regulatory;

/// <summary>
/// 
/// </summary>
public class ApprovedArrangement : BaseResource
{
    /// <summary>
    /// 
    /// </summary>
    public List<Reference<Service>> ApprovedServices { get; set; } = new List<Reference<Service>>();
    public List<Reference<Site>> ApprovedSites { get; set; } = new List<Reference<Site>>();
    public List<Reference<EntityRelationship>> RelatesTo { get; set; } = new List<Reference<EntityRelationship>>();
    public List<Reference<EntityRelationship>> RelatedRegulations { get; set; } = new List<Reference<EntityRelationship>>();
    
}