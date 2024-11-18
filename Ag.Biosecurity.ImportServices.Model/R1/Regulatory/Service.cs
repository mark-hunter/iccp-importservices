using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Regulatory;

public class Service : BaseResource
{
    List<Reference<Site>> SupportedSites { get; set; } = new List<Reference<Site>>();
}