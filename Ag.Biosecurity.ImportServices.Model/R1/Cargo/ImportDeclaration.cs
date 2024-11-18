using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;
using Ag.Biosecurity.ImportServices.Model.R1.Conveyance;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Financial;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

/// <summary>
/// The Import Declaration resource encapsulates the information, including links to the Consignment, 
/// Goods, Journey, key Locations, etc., pertaining to the actual import of Goods into Australia.
/// </summary>
public class ImportDeclaration : BaseResource
{
    /// <summary>
    /// The Concerns attribute captures the set of concerns identified within the ImportDeclaration.
    /// </summary>
    public List<Concern> DeclaredConcerns { get; set; } = new List<Concern>();

    /// <summary>
    /// The InvolvedParties attribute links the each involved EntityRole with the function (Coding) they are performing 
    /// as part of the ImportDeclaration. That is,
    /// InvolvedParties.Coding = Role/Function being performed
    /// InvolvedParties.EntityRole = Organisation/Person Role Fulfilling the Function.
    /// </summary>
    public Dictionary<EntityRoleType, Entity.Entity> InvolvedParties { get; set; } 

    /// <summary>
    /// The ImportJourney attribute contains a copy of the Journey resource detailing the pathway taken by the 
    /// imported goods as declared within this ImportDeclaration.
    /// </summary>
    public Journey? ImportJourney { get; set; }

    /// <summary>
    /// The Consignments attribute maintains a list of References to associated Consignment resources.
    /// </summary>
    public List<Reference<Consignment>> Consignments { get; set; }


    /// <summary>
    /// The Lines attribute is a List of References to ImportDeclarationLineItem resources.
    /// </summary>
    public List<Reference<ImportDeclarationLineItem>> LineItems { get; set; }

    /// <summary>
    /// The AssociatedEntry Reference is a reference to the ImportDeclarationEntry
    /// </summary>
    public Reference<ImportDeclarationEntry>? AssociatedEntry { get; set; }

    /// <summary>
    /// The set of key Locations associated with the ImportDeclaration. The Coding value use as the key
    /// provides context of the function and/or role of the Location (e.g. PortOfLoading, DischargePort, etc.)
    /// </summary>
    public Dictionary<ImportLocationRoleType, Location> Locations { get; set; }

    /// <summary>
    ///
    /// </summary>
    public Reference<Account>? FinancialAccount { get; set; }
    
    /// <summary>
    /// The Attachments list contains references to any documents (evidence, certificates, etc.) associated with
    /// the ImportDeclaration.
    /// </summary>
    public List<Attachment> Attachments { get; set; }

    /// <summary>
    /// The DateOfArrival attribute details the arrival date of the consignment (etc.) to which this declaraton relates.
    /// Note: This may be derivable from the reference Conveyance::Journey Resource
    /// </summary>
    public DateTime? DateOfArrival { get; set; }

    public string? GoodsDelivered { get; set; }
    public string? MarksAndNumbers { get; set; }
    public float? TotalCustomValue { get; set; }

    public ImportDeclaration() : base()
    {
        ResourceType = GetType().Name;
        InvolvedParties = new Dictionary<EntityRoleType, Entity.Entity>();
        Consignments = new List<Reference<Consignment>>();
        LineItems = new List<Reference<ImportDeclarationLineItem>>();
        Locations = new Dictionary<ImportLocationRoleType, Location>();
        Attachments = new List<Attachment>();
    }

    //
    // Helper Methods for Locations
    //

    [JsonIgnore]
    public Location? OriginLocation
    {
        set => Locations.Add(ImportLocationRoleType.Origin, value);
        get => Locations[ImportLocationRoleType.Origin];
    }

    [JsonIgnore]
    public Location? LoadingPortLocation
    {
        set => Locations.Add(ImportLocationRoleType.LoadingPort, value);
        get => Locations[ImportLocationRoleType.LoadingPort];
    }

    [JsonIgnore]
    public Location? DischargePortLocation
    {
        set => Locations.Add(ImportLocationRoleType.DischargePort, value);
        get => Locations[ImportLocationRoleType.DischargePort];
    }

    [JsonIgnore]
    public Location? DestinationPortLocation
    {
        set => Locations.Add(ImportLocationRoleType.DestinationPort, value);
        get => Locations[ImportLocationRoleType.DestinationPort];
    }

    [JsonIgnore]
    public Location? EntryPointLocation
    {
        set => Locations.Add(ImportLocationRoleType.Destination, value);
        get => Locations[ImportLocationRoleType.EntryPoint];
    }

    [JsonIgnore]
    public Location? DestinationLocation
    {
        set => Locations.Add(ImportLocationRoleType.Destination, value);
        get => Locations[ImportLocationRoleType.Destination];
    }

    [JsonIgnore]
    public Location? InspectionSiteLocation
    {
        set => Locations.Add(ImportLocationRoleType.InspectionSite, value);
        get => Locations[ImportLocationRoleType.InspectionSite];
    }

    [JsonIgnore]
    public Location? TreatmentSiteLocation
    {
        set => Locations.Add(ImportLocationRoleType.TreatmentSite, value);
        get => Locations[ImportLocationRoleType.TreatmentSite];
    }

    [JsonIgnore]
    public Location? DisposalSiteLocation
    {
        set => Locations.Add(ImportLocationRoleType.DisposalSite, value);
        get => Locations[ImportLocationRoleType.DisposalSite];
    }
    
    
    //
    // Helper Methods for Involved Parties
    //

    [JsonIgnore]
    public Entity.Entity? Broker
    {
        set => InvolvedParties.Add(EntityRoleType.Broker, value);
        get => InvolvedParties[EntityRoleType.Broker];
    }

    [JsonIgnore]
    public Entity.Entity? ConveyanceProvider
    {
        set => InvolvedParties.Add(EntityRoleType.ConveyanceProvider, value);
        get => InvolvedParties[EntityRoleType.ConveyanceProvider];
    }

    [JsonIgnore]
    public Entity.Entity? Exporter
    {
        set => InvolvedParties.Add(EntityRoleType.Exporter, value);
        get => InvolvedParties[EntityRoleType.Exporter];
    }

    [JsonIgnore]
    public Entity.Entity? Importer
    {
        set => InvolvedParties.Add(EntityRoleType.Importer, value);
        get => InvolvedParties[EntityRoleType.Importer];
    }

    [JsonIgnore]
    public Entity.Entity? Recipient
    {
        set => InvolvedParties.Add(EntityRoleType.Recipient, value);
        get => InvolvedParties[EntityRoleType.Recipient];
    }

    [JsonIgnore]
    public Entity.Entity? Sender
    {
        set => InvolvedParties.Add(EntityRoleType.Sender, value);
        get => InvolvedParties[EntityRoleType.Sender];
    }

    [JsonIgnore]
    public Entity.Entity? TreatmentProvider
    {
        set => InvolvedParties.Add(EntityRoleType.TreatmentProvider, value);
        get => InvolvedParties[EntityRoleType.TreatmentProvider];
    }

    
}