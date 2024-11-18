using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Financial;

public class ChargeItem : BaseResource
{
    public Reference<ChargeItemDefinition>? ChargeItemDefinition { get; set; }
    public Reference<object>? ChargeActivity { get; set; }
    public float? Amount { get; set; }

    public ChargeItem() : base()
    {
        ResourceType = "ChargeItem";
        Amount = 0.0F;
    }
}