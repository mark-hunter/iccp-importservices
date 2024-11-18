using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchitypes.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

/// <summary>
/// The Direction class encapsulates the Business Details associated with a generated Direction - including tracking
/// its state. The actual "document" delivered to the client is encapsulated within the IssuedDirection.
/// </summary>
public class Direction : DirectionDefinition
{
    /// <summary>
    /// The IssueDirections attributes maintains a set of references to the actual "generated document" that is communicated
    /// to the client or departmental officer.
    /// </summary>
    public List<Reference<IssuedDirection>> IssuedDirections { get; set; }
    public List<Reference<Condition>> IdentifiedConditions { get; set; }
    public Reference<ImportCase>? AssociatedCase { get; set; }
    
    /// <summary>
    /// The DirectionLevel attribute signifies whether the direction is relevant to a single ImportDeclarationLineItem or
    /// to the whole GoodsContainer.
    /// </summary>
    public DirectionLevelType? DirectionLevel { get; set; }
    
    /// <summary>
    /// The ResponsibleParty identifies who is responsible for the fulfillment of the Direction.
    /// </summary>
    public Reference<EntityRole>? ResponsibleParty { get; set; }
    
    /// <summary>
    /// The DirectionSite details the Location of the activity to be performed or the Location of the goods. 
    /// </summary>
    public Site? DirectionSite { get; set; }
    
    /// <summary>
    /// The DirectionStatus details the current state of the Direction (fulfillment) process.
    /// </summary>
    public DirectionStatusType? DirectionStatus {get; set;}
    
    /// <summary>
    /// The DirectionTargets list links the intended target of the direction (i.e. a GoodsContainer or ImportDelcarationLineItem)
    /// to this Direction. It incorporates a status / completion value for the activity on the given target.
    /// </summary>
    public List<DirectionTargetDetail> DirectionTargets { get; set; }

    public List<Comment> DirectionComments { get; set; }
    
    // Direction Temporal Details
    public DirectionDateSet? DirectionDates { get; set; } = new DirectionDateSet();
    
    public string? Description { get; set; }
    
    
    public bool IsActive { get; set; }
    public bool IsBBE { get; set; }
    public bool isBiosecurityFlag { get; set; }
    public bool isFinalDirection { get; set; }
    public bool isFoodFlag { get; set; }
    public bool isMovementAllowed { get; set; }
    public bool PromptATT { get; set; }
    public bool PromptQIQ { get; set; }

    public Direction() : base()
    {
        ResourceType = GetType().Name;
        IssuedDirections = new List<Reference<IssuedDirection>>();
        IdentifiedConditions = new List<Reference<Condition>>();
        DirectionTargets = new List<DirectionTargetDetail>();
        DirectionComments = new List<Comment>();
        
    }
    
    [JsonIgnore]
    public Identifier? AimsId
    {
        set
        {
            if (!string.IsNullOrWhiteSpace(value.Id))
            {
                string displayText = value.DisplayText;
                if (string.IsNullOrWhiteSpace(displayText))
                {
                    displayText = string.Empty;
                }

                CodeableConcept identifierType = DirectionIdentifierType.AimsId.AsCodeableConcept;
                Identifier aimsIdentifier = new Identifier(DirectionIdentifierType.AimsId.AsCodeableConcept, value.Id, displayText);
                AddIdentifier(aimsIdentifier);
            }
        }
        get => GetIdentifierWithCode(DirectionIdentifierType.AimsId);
    }
}