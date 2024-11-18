using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

public static class DataPrivacyFactory
{
    public static string? DataPrivacySystem = "https://aff.gov.au/imports/iccp/data-privacy";
    public static string? DataPrivacyVersion = "R1";

    public static CodeableConcept ToCodeableConcept(DataPrivacyEnum dataPrivacy)
    {
        var codeableConcept = new CodeableConcept();
        var coding = new Coding();
        coding.CodeSystem = DataPrivacySystem;
        coding.CodeVersion = DataPrivacyVersion;
        switch (dataPrivacy)
        {
            case DataPrivacyEnum.Personal:
            {
                coding.Code = "PERSONAL";
                coding.Text = "Data Privacy Personal";
                codeableConcept.Value = "DATA_PRIVACY_PERSONAL";
                codeableConcept.DisplayText = "Data Privacy = Personal";
                break;
            }
            case DataPrivacyEnum.Sensitive:
            {
                coding.Code = "SENSITIVE";
                coding.Text = "Data Privacy Sensitive";
                codeableConcept.Value = "DATA_PRIVACY_SENSITIVE";
                codeableConcept.DisplayText = "Data Privacy = Sensitive";
                break;
            }
            case DataPrivacyEnum.Public:
            {
                coding.Code = "PUBLIC";
                coding.Text = "Data Privacy Public";
                codeableConcept.Value = "DATA_PRIVACY_PUBLIC";
                codeableConcept.DisplayText = "Data Privacy = Public";
                break;
            }
            default:
            {
                coding.Code = "None";
                coding.Text = "Data Privacy None";
                codeableConcept.Value = "DATA_PRIVACY_NONE";
                codeableConcept.DisplayText = "Data Privacy = None";
                break;
            }
        }

        codeableConcept.Codings.Add(coding);
        return codeableConcept;
    }

    public static DataPrivacyEnum ToDataClassificationEnum(CodeableConcept codeableConcept)
    {
        if (codeableConcept.Codings.Count < 1) return DataPrivacyEnum.None;

        foreach (var coding in codeableConcept.Codings)
        {
            if (coding.CodeSystem == DataPrivacySystem)
            {
                switch (coding.Code)
                {
                    case "SENSITIVE":
                    {
                        return DataPrivacyEnum.Sensitive;
                    }
                    case "PERSONAL":
                    {
                        return DataPrivacyEnum.Personal;
                    }
                    case "PUBLIC":
                    {
                        return DataPrivacyEnum.Public;
                    }
                    default:
                    {
                        return DataPrivacyEnum.None;
                    }
                }
            }
        }

        return DataPrivacyEnum.None;
    }
}