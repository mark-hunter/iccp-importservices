using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

public class Concern : ClientActivityBaseResource
{
    public List<Reference<ImportDeclarationEntry>> ImportDeclarationEntries { get; set; }
    public List<Reference<Consignment>> Consignments { get; set; }
    public List<Reference<ImportedItem>> ImportItems { get; set; }
    
    public ConcernDefinition? ConcernDefinition { get; set; }

    public Concern() : base()
    {
        ResourceId = "Concern";
        ImportDeclarationEntries = new List<Reference<ImportDeclarationEntry>>();
        Consignments = new List<Reference<Consignment>>();
        ImportItems = new List<Reference<ImportedItem>>();
    }
}