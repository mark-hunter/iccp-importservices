using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;

public class TransportationMode : BaseResource
{
    public CodeableConcept? Mode { get; set; }

    public TransportationMode() : base()
    {
        ResourceType = "TransportationMode";
    }
}