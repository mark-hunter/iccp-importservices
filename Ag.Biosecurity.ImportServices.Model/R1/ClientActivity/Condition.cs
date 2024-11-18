using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

public class Condition : ClientActivityBaseResource
{

    public CodeableConcept? ConditionType { get; set; }
    public CodeableConcept? ConditionSeverity { get; set; }
    public Reference<object>? Instructions { get; set; }
    public List<Reference<Entity.Entity>> RelatedEntities { get; set; }
    public List<Reference<Consignment>> RelatedConsignments { get; set; }
    public List<Reference<ImportedItem>> RelatedImportedItems { get; set; }
    public List<Reference<Risk>> RelatedRisks { get; set; }
    public List<Reference<Concern>> RelatedConcerns { get; set; }
    
    public Condition() : base()
    {
        ResourceType = GetType().Name;
        RelatedEntities = new List<Reference<Entity.Entity>>();
        RelatedConsignments = new List<Reference<Consignment>>();
        RelatedImportedItems = new List<Reference<ImportedItem>>();
        RelatedRisks = new List<Reference<Risk>>();
        RelatedConcerns = new List<Reference<Concern>>();
    }
}