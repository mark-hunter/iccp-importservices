using Ag.Biosecurity.ImportServices.Model.R1.Base;

namespace Ag.Biosecurity.ImportServices.Model.R1.Financial;

public class Payment : BaseResource
{
    public float Amount { get; set; }

    public Payment() : base()
    {
        ResourceId = "Payment";
        Amount = 0.0F;
    }
}