using Ag.Biosecurity.ImportServices.Model.R1.Coneyance.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Conveyance;

public class Aircraft : TransportationMode
{
    public Aircraft() : base()
    {
        ResourceType = "Aircraft";
        Mode = TransportationModeTypeFactory.TransportationModeToCondeableConcept(TransportationModeTyepEnum.Air);
    }
}