using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Financial;

public class Account : BaseResource
{
    public List<Reference<PaymentReconciliation>> PaymentReconciliations { get; set; }
    public List<Reference<Invoice>> Invoices { get; set; }
    public List<Reference<ChargeItem>> ChargeItems { get; set; }
    public CodeableConcept? BillingStatus { get; set; }
    public CodeableConcept? Status { get; set; }
    public CodeableConcept? Type { get; set; }
    public float Balance { get; set; }
    
    public Account()
    {
        ResourceType = "Account";
        Balance = 0.0F;
        PaymentReconciliations = new List<Reference<PaymentReconciliation>>();
        Invoices = new List<Reference<Invoice>>();
        ChargeItems = new List<Reference<ChargeItem>>();
    }
}