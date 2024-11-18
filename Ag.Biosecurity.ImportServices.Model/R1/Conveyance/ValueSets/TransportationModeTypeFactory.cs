using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Coneyance.ValueSets;

public static class TransportationModeTypeFactory
{
    public static string systemId = "https://aff.gov.au/imports/iccp/transportation-mode-type";
    public static string versionId = "R1";
    
    public static CodeableConcept TransportationModeToCondeableConcept(
        TransportationModeTyepEnum transportationModeType)
    {
        CodeableConcept codeableConcept = new CodeableConcept();
        Coding coding = new Coding();
        coding.CodeVersion = versionId;
        coding.CodeSystem = systemId;
        switch (transportationModeType)
        {
            case TransportationModeTyepEnum.Air:
            {
                coding.Code = "AIR";
                coding.Text = "Air";
                codeableConcept.Value = "TRANSPORTATION_MODE_TYPE_AIR";
                codeableConcept.DisplayText = "Transportation Mode = Air";
                break;
            }
            case TransportationModeTyepEnum.Sea:
            {
                coding.Code = "SEA";
                coding.Text = "Sea";
                codeableConcept.Value = "TRANSPORTATION_MODE_TYPE_SEA";
                codeableConcept.DisplayText = "Transportation Mode = Sea";
                break;
            }
            default:
            {
                coding.Code = "UNKNOWN";
                coding.Text = "Unknown";
                codeableConcept.Value = "TRANSPORTATION_MODE_TYPE_UNKNOWN";
                codeableConcept.DisplayText = "Transportation Mode = Unknown";
                break;
            }            
        }
        codeableConcept.Codings.Add(coding);
        return (codeableConcept);
    }

    public static TransportationModeTyepEnum CodeableConceptToTransportationMode(CodeableConcept codeableConcept)
    {
        if (codeableConcept == null)
        {
            return (TransportationModeTyepEnum.Unknown);
        }

        if (codeableConcept.Codings.Count < 1)
        {
            return (TransportationModeTyepEnum.Unknown);
        }

        foreach (Coding coding in codeableConcept.Codings)
        {
            if (coding.CodeSystem.Equals(systemId))
            {
                switch (coding.Code)
                {
                    case "AIR":
                    {
                        return (TransportationModeTyepEnum.Air);
                    }
                    case "SEA":
                    {
                        return (TransportationModeTyepEnum.Sea);
                    }
                    default:
                    {
                        return (TransportationModeTyepEnum.Unknown);
                    }
                }
            }
        }

        return (TransportationModeTyepEnum.Unknown);
    }
}