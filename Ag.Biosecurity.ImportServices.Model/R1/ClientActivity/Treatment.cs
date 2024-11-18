using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

public class Treatment : Task
{
    public List<Reference<TreatmentReport>> TreatmentReports { get; set; } // References to Operations::TreatmentReport Resources
    
    public Treatment() : base()
    {
        ResourceType = "Treatment";
        TreatmentReports = new List<Reference<TreatmentReport>>();
    }
}