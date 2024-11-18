using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Financial;

public class PaymentReconciliation : BaseResource
{


    public List<Reference<Payment>> Payments { get; set; }
    public List<Reference<Invoice>> TargetInvoices { get; set; }
    
    public PaymentReconciliation() : base ()
    {
        ResourceId = "PaymentReconciliation";
        Payments = new List<Reference<Payment>>();
        TargetInvoices = new List<Reference<Invoice>>();
    }
}