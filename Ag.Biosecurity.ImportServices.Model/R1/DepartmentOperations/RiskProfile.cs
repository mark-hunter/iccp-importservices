using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;
using Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class RiskProfile : BaseResource
{
    public Risk? IdentifiedRisk { get; set; }
    public RiskProfileReasonType? ReasonCode { get; set; }
    public RiskProfileSubReasonType? SubReasonCode { get; set; }
    public string? Description { get; set; }

    public RiskProfile() : base()
    {
        ResourceType = GetType().Name;
    }
}