using Ag.Biosecurity.ImportServices.Model.R1.Coneyance;
using Ag.Biosecurity.ImportServices.Model.R1.Coneyance.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;

public class Vessel : TransportationMode
{
    public Vessel() : base()
    {
        ResourceType = "Vessel";
        Mode = TransportationModeTypeFactory.TransportationModeToCondeableConcept(TransportationModeTyepEnum.Sea);
    }
}