using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class ImportCase : BaseResource
{
    public List<ImportCaseRelationshipType> RelatedCases { get; set; } 
    public List<Reference<ImportCaseActivity>> Activities { get; set; } // References to ImportCaseActivity instances
    public List<Comment> Comments { get; set; }
    public List<Reference<ImportCaseActivity>> BlockingActivity { get; set; }
    
    public ImportCase() : base()
    {
        Activities = new List<Reference<ImportCaseActivity>>();
        RelatedCases = new List<ImportCaseRelationshipType>();
        Comments = new List<Comment>();
    }
}