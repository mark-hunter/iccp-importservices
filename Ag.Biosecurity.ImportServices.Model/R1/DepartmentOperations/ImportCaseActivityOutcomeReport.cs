using Ag.Biosecurity.ImportServices.Model.R1.Artifacts;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class ImportCaseActivityOutcomeReport : BaseResource
{
    public List<Reference<Report>> Artifacts { get; set; } // References to Utility::Report Resources
}