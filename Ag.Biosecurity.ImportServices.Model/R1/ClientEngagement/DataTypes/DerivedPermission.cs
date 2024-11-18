using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Engagement.ValueTypes;
using Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement.DataTypes;

public class DerivedPermission
{
    public DerivedPermission()
    {
        Compartments = new List<DataCompartmentEnum>();
        Classifications = new List<DataClassificationType>();
        Privacies = new List<DataPrivacyEnum>();
        PermissibleActions = new List<ActionTypeEnum>();
    }

    public List<DataCompartmentEnum> Compartments { get; set; }
    public List<DataClassificationType> Classifications { get; set; }
    public List<DataPrivacyEnum> Privacies { get; set; }
    public List<ActionTypeEnum> PermissibleActions { get; set; }
}