using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The EntityRelationship object captures the per-instance relationships between individual service providers 
/// (ServiceProvders) as well as clients (Clients). In this, it specifically captures relationships between 
/// Entities – be they Organisations or Persons. It captures the types of Relationships as well as temporal 
/// aspects and conditions.
/// </summary>
public class EntityRelationship : BaseResource
{
    public Reference<Entity>? RelationshipTarget { get; set; }
    public Reference<Entity>? RelationSource { get; set; }
    public EntityRelationshipType? RelationshipType { get; set; } = EntityRelationshipType.UndocumentedRelationship;
    public string? Text { get; set; }

    public EntityRelationship() : base()
    {
        ResourceType = GetType().Name;
    }
}