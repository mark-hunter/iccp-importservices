using Ag.Biosecurity.ImportServices.Model.R1.Engagement.ValueTypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement.DataTypes;

public class ExplicitPermission
{
    public ExplicitPermission()
    {
        ResourceTypes = new List<string>();
        PermissableActions = new List<ActionTypeEnum>();
    }

    public List<string> ResourceTypes { get; set; }
    public List<ActionTypeEnum> PermissableActions { get; set; }
}