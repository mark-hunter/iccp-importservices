using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Financial;

public class Invoice : BaseResource
{
    public List<Reference<ChargeItem>> ChargeItems { get; set; }
    public float Amount { get; set; }   
    
    public Invoice() : base()
    {
        ResourceId = "Invoice";
        Amount = 0.0F;
        ChargeItems = new List<Reference<ChargeItem>>();
    }
}