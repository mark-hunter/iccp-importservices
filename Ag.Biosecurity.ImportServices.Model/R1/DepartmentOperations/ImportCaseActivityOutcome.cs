using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class ImportCaseActivityOutcome : BaseResource
{
    public ImportCaseActivityOutcome()
    {
        Directions = new List<Reference<Direction>>();
        OutcomeReports = new List<Reference<ImportCaseActivityOutcomeReport>>();
    }

    public List<Reference<Direction>> Directions { get; set; } // References to the resultant Activity::Directions Resources
    public List<Reference<ImportCaseActivityOutcomeReport>> OutcomeReports { get; set; } // References to the ImportActivityOutcomeReport Resources
}