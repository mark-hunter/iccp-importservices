using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;
using Ag.Biosecurity.ImportServices.Model.R1.Financial;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

/// <summary>
/// The ImportDeclarationEntry is the wrapper for the processing of a Bio-security Relevant Import activity --> where
/// the import activity is instigated by the "submission" of an ImportDeclaration.
/// </summary>
public class ImportDeclarationEntry : ImportCase
{
    /// <summary>
    /// The SubmittedDeclaration attribute contains a Reference to the actual ImportDeclaration. Note that the Reference
    /// incorporates versioning of the linked object - supporting re-submissions or updates to the ImportDeclaration.
    /// </summary>
    public Reference<ImportDeclaration>? SubmittedDeclaration { get; set; } 
    /// <summary>
    /// 
    /// </summary>
    public RiskProfile? IdentifiedRiskProfile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<Concern> IdentifiedConcerns { get; set; } = new List<Concern>();
    public List<Reference<ImportDeclarationLineItem>> LineItems { get; set; } = new List<Reference<ImportDeclarationLineItem>>(); // ImportDeclarationLineItem
    public ImportDeclarationEntryStatusType? EntryProcessingStatus { get; set; }
    public CodeableConcept? EntryProcessingMode { get; set; }
    
    public Reference<Account>? FinancialAccount { get; set; }
    
    /// <summary>
    /// The Findings attribute captures References to any Findings associated with the processing of the Import Declaration,
    /// including any sub-activity associated with processing of the given Import Declaration, including processing of the
    /// individual "line items" articulated within the Import Declaration.
    /// </summary>
    public List<Reference<Finding>> Findings { get; set; } = new List<Reference<Finding>>();
    /// <summary>
    /// The Directions attribute captures References to any Directions associated with the processing of the Import Declaration,
    /// including any sub-activity associated with processing of the given Import Declaration, including processing of the
    /// individual "line items" articulated within the Import Declaration.
    /// </summary>
    public List<Reference<Direction>> Directions { get; set; } = new List<Reference<Direction>>();

    public ImportDeclarationEntry() : base()
    {
        ResourceType = GetType().Name;
    }
    
    [JsonIgnore]
    public Identifier? QuarantineEntryId
    {
        set
        {
            Identifier qeiIdentifier = new Identifier(ImportDeclarationEntryIdentifierType.QuarantineEntryId.AsCodeableConcept, value.Id, value.DisplayText);
            AddIdentifier(qeiIdentifier);
        }
        get => GetIdentifierWithCode(ImportDeclarationEntryIdentifierType.QuarantineEntryId);
    }
}