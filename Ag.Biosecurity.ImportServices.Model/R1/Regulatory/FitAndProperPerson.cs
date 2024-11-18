using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Regulatory;

public class FitAndProperPerson : BaseResource
{
    public List<Reference<Service>> AssessedServices { get; set; } = new List<Reference<Service>>();
    public List<Reference<Policy>> RelatedPolicy { get; set; } = new List<Reference<Policy>>();
    public Reference<Person>? AssessedPerson { get; set; }
    public List<Reference<EntityRole>> AssessedRoles { get; set; } = new List<Reference<EntityRole>>();
}