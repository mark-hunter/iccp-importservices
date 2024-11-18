using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security;

public class ServiceDeliveryArea : BaseResource
{
    public List<Site> Sites { get; set; } = new List<Site>();
    public String? Name { get; set; }

    public ServiceDeliveryArea() : base()
    {
        ResourceType = GetType().Name;
    }
    
}