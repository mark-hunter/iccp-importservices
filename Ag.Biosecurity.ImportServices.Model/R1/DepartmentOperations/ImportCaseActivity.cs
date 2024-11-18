using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Financial;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class ImportCaseActivity : BaseResource
{


    public Reference<ImportCase>? Case { get; set; } // Reference to the Case to which this Activity belongs
    public List<Reference<ImportCaseActivityOutcome>> Outcomes { get; set; } // References to the ImportCaseActivityOutcome resources
    public List<Reference<ClientActivity.Task>> RelatedTasks { get; set; } // References to Activity::Task resources
    public Reference<ChargeItem>? Fee { get; set; }
    public ImportCaseActivityType? ActivityType { get; set; }
    public List<Comment> Comments { get; set; }
    
    public ImportCaseActivity() : base()
    {
        ResourceType = "ImportCaseActivity";
        Outcomes = new List<Reference<ImportCaseActivityOutcome>>();
        RelatedTasks = new List<Reference<ClientActivity.Task>>();
        Comments = new List<Comment>();
    }
}