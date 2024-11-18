using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity;

/// <summary>
/// The Entity object represents any person, organisation or group that interacts with the department and/or is 
/// involved in an import (or export) activity. The Entity object has a strict set of types (e.g. Organisation, 
/// Person, Consortia, Business Unit, Interest Group, etc.) that is used to qualify its role and function. 
/// </summary>
public class Entity : BaseResource
{
    /// <summary>
    /// The EntityRelationships attribute captures the per-instance relationships between individual service providers 
    /// (ServiceProvders) as well as clients (Clients). In this, it specifically captures relationships between 
    /// Entities – be they Organisations or Persons. It captures the types of Relationships as well as temporal 
    /// aspects and conditions.
    /// </summary>
    public List<EntityRelationship> EntityRelationships { get; set; }
    /// <summary>
    /// The TypeOfEntity identifies what the type of entity it is (e.g. Organisation, Person, etc.).
    /// </summary>
    public EntityType? TypeOfEntity { get; set; }
    /// <summary>
    /// The EntityRoles attribute captures the various roles of the entity, within the scope of the bio-security domain.
    /// </summary>
    public List<EntityRole> EntityRoles { get; set; }
    /// <summary>
    /// The EntityIdentityAssuranceType details the mechanism used to confirm the identity of the Entity (if confirmation
    /// was obtained in any way).
    /// </summary>
    public IdentityAssuranceType EntityIdentityAssuranceType { get; set; } = IdentityAssuranceType.UnconfirmedNoEvidence;
    /// <summary>
    /// A singular common name that can be used to refer to the entity instance. It is not guaranteed to be unique.
    /// </summary>
    public string CommonName { get; set; }
    /// <summary>
    /// A list of Contact Points that can be used to communicate (electronically) with the Entity. Note that there
    /// is also Contact Points associated with the EntityRoles being fulfilled, and so judgement should be used when
    /// specifying a Contact Point for the Entity as opposed to the Role they are fulfilling. 
    /// </summary>
    public List<ContactPoint> ContactPoints { get; set; }

    public Entity() : base ()
    {
        ResourceType = GetType().Name;
        EntityRelationships = new List<EntityRelationship>();
        EntityRoles = new List<EntityRole>();
        ContactPoints = new List<ContactPoint>();
        CommonName = string.Empty;
    }

    [JsonIgnore]
    public Reference<Entity>? ParentEntity
    {
        set
        {
            bool found = false;
            foreach(EntityRelationship currentRelationship in EntityRelationships)
            {
                if(currentRelationship.RelationshipType == EntityRelationshipType.ParentOrganisation){
                    currentRelationship.RelationshipTarget = value;
                }
            }
            if(!found)
            {
                EntityRelationship parentEntityRelationship = new EntityRelationship();
                parentEntityRelationship.RelationshipTarget = value;
                parentEntityRelationship.RelationshipType = EntityRelationshipType.ParentOrganisation;
                parentEntityRelationship.Text = "Parent Organisation";
                EntityRelationships.Add(parentEntityRelationship);
            }
        }
        get
        {
            foreach(EntityRelationship currentRelationship in EntityRelationships)
            {
                if(currentRelationship.RelationshipType == EntityRelationshipType.ParentOrganisation){
                    return currentRelationship.RelationshipTarget;
                }
            }
            return null;
        }
    }
}