using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;
using Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

/// <summary>
/// The ImportDeclarationLineItem refers to the individual line items defined within an Import Declaration - each
/// describing an individual goods type that is contained within the Imported Container/Parcel.
/// </summary>
public class ImportDeclarationLineItem : BaseResource
{
    /// <summary>
    /// The ImportDeclarationEntry (i.e. the parent case associated with the processing of the ImportDeclaration).
    /// </summary>
    public Reference<ImportDeclarationEntry>? ParentImportDeclarationEntry { get; set; }
    /// <summary>
    /// The ImportDeclaration is the representation of the actual Import Declaration as submitted by a client.
    /// </summary>
    public Reference<ImportDeclaration>? ParentImportDeclaration { get; set; }
    /// <summary>
    /// A collection of definitions of the actual goods types associated with the Line Item.
    /// </summary>
    public List<ImportedItem> Items { get; set; } = new List<ImportedItem>(); 
    /// <summary>
    /// A collection of identified Concerns (as identified by either the Client or by Departmental Officers).
    /// </summary>
    public List<Concern> Concerns { get; set; } = new List<Concern>();

    /// <summary>
    /// The Findings attribute captures References to any Findings associated with the processing of the Import Declaration
    /// Line Item. 
    /// </summary>
    public List<Reference<Finding>> Findings { get; set; } = new List<Reference<Finding>>();
    /// <summary>
    /// The Directions attribute captures References to any Directions associated with the processing of the Import Declaration,
    /// Line Item.
    /// </summary>
    public List<Reference<Direction>> Directions { get; set; } = new List<Reference<Direction>>();
    /// <summary>
    /// The Country of Origin of the Goods as Declared in the ImportDeclaration.
    /// </summary>
    public CountryCode? DeclaredCountryOfOrigin { get; set; }
    /// <summary>
    /// The GoodsContainer in which the Goods are located/shipped.
    /// </summary>
    public Reference<GoodsContainer>? Container { get; set;}
    /// <summary>
    /// The ClientIdentifiedConcern captures the specific concern the client (importer, broker) has flagged on the
    /// goods (or container) within the ImportDeclaration.
    /// </summary>
    public ConcernType? ClientIdentifiedConcern { get; set; }
    
    public ImportDeclarationLineItem() : base()
    {
        ResourceType = GetType().Name;
    }

    public ImportDeclarationLineItem(Reference<ImportDeclaration> parentDeclaration, Reference<ImportDeclarationEntry> parentDeclarationEntry) : this()
    {
        ParentImportDeclarationEntry = parentDeclarationEntry;
        ParentImportDeclaration = parentDeclaration;
        ResourceType = GetType().Name;
    }

    //
    // Helper Methods
    //

    [JsonIgnore]
    public Identifier? AimsIdentifier
    {
        set => AddIdentifier(value);
        get => GetIdentifierWithCode(ImportDeclarationLineItemIdentifierType.AimsLineItemId);
    }
}