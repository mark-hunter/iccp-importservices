using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

public class Incident : BaseResource
{
    public Incident()
    {
        InspectionReports = new List<Reference<InspectionReport>>();
        HazardReports = new List<Reference<HazardReport>>();
        Assessments = new List<Reference<Assessment>>();
    }

    public List<Reference<InspectionReport>> InspectionReports { get; set; }
    public List<Reference<HazardReport>> HazardReports { get; set; }
    public List<Reference<Assessment>> Assessments { get; set; }
}