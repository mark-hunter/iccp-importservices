using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Artifacts;

public class Evidence : BaseResource
{
    public Reference<Certificate>? Certificates { get; set; }
    public Reference<Document>? Documentation { get; set; }
    public Evidence() : base()
    {
      ResourceType = GetType().Name;
    }
}