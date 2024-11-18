using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

public static class DataCompartmentFactory
{
    public static string? DataCompartmentSystem = "https://aff.gov.au/imports/iccp/data-compartment";
    public static string? DataCompartmentVersion = "R1";

    public static CodeableConcept ToCodeableConcept(DataCompartmentEnum dataCompartment)
    {
        var codeableConcept = new CodeableConcept();
        var coding = new Coding();
        coding.CodeSystem = DataCompartmentSystem;
        coding.CodeVersion = DataCompartmentVersion;
        switch (dataCompartment)
        {
            case DataCompartmentEnum.ClientEngagementResourceCompartment:
            {
                coding.Code = "CLIENT_ENGAGEMENT_RESOURCE";
                coding.Text = "Client Engagement Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_CLIENT_ENGAGEMENT_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Client Engagement Resource";
                break;
            }
            case DataCompartmentEnum.ConveyanceResourceCompartment:
            {
                coding.Code = "CONVEYANCE_RESOURCE";
                coding.Text = "Conveyance Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_CONVEYANCE_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Conveyance Resource";
                break;
            }
            case DataCompartmentEnum.FinancialResourceCompartment:
            {
                coding.Code = "FINANCIAL_RESOURCE";
                coding.Text = "Financial Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_FINANCIAL_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Financial Resource";
                break;
            }
            case DataCompartmentEnum.EntityManagementResourceCompartment:
            {
                coding.Code = "ENTITY_MANAGEMENT_RESOURCE";
                coding.Text = "Entity Management Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_ENTITY_MANAGEMENT_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Entity Management Resource";
                break;
            }
            case DataCompartmentEnum.PersonalInformationCompartment:
            {
                coding.Code = "PERSONAL_INFORMATION";
                coding.Text = "Personal Information Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_PERSONAL_INFORMATION";
                codeableConcept.DisplayText = "Data Compartment = Personal Information";
                break;
            }
            case DataCompartmentEnum.DepartmentalOperationsResourceCompartment:
            {
                coding.Code = "DEPARTMENTAL_OPERATIONS";
                coding.Text = "Departmental Operations Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_DEPARTMENTAL_OPERATIONS";
                codeableConcept.DisplayText = "Data Compartment = Departmental Operations";
                break;
            }
            case DataCompartmentEnum.ArtifactsResourceCompartment:
            {
                coding.Code = "ARTIFACT_RESOURCE";
                coding.Text = "Artifact Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_ARTIFACT_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Artifact Resource";
                break;
            }
            case DataCompartmentEnum.OrganisationalInformationCompartment:
            {
                coding.Code = "ORGANISATIONAL_INFORMATION";
                coding.Text = "Organisational Information Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_ORGANISATIONAL_INFORMATION";
                codeableConcept.DisplayText = "Data Compartment = Organisational Information";
                break;
            }
            case DataCompartmentEnum.ReferenceResourceCompartment:
            {
                coding.Code = "REFERENCE_RESOURCE";
                coding.Text = "Reference Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_REFERENCE_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Reference Resource";
                break;
            }
            case DataCompartmentEnum.SecurityResourceCompartment:
            {
                coding.Code = "SECURITY_RESOURCE";
                coding.Text = "Security Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_SECURITY_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Security Resource";
                break;
            }
            case DataCompartmentEnum.ClientActivityResourceCompartment:
            {
                coding.Code = "CLIENT_ACTIVITY_RESOURCE";
                coding.Text = "Client Activity Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_CLIENT_ACTIVITY_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Client Activity Resource";
                break;
            }
            case DataCompartmentEnum.RegulatoryResourceCompartment:
            {
                coding.Code = "REGULATORY_RESOURCE";
                coding.Text = "Regulatory Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_REGULATORY_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Regulatory Resource";
                break;
            }
            case DataCompartmentEnum.CargoResourceCompartment:
            {
                coding.Code = "CARGO_RESOURCE";
                coding.Text = "Cargo Resource Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_CARGO_RESOURCE";
                codeableConcept.DisplayText = "Data Compartment = Cargo Resource";
                break;
            }
            default:
            {
                coding.Code = "UNKNOWN";
                coding.Text = "No Known Data Compartment";
                codeableConcept.Value = "DATA_COMPARTMENT_UNKNOWN";
                codeableConcept.DisplayText = "Data Compartment = Not Known";
                break;
            }
        }

        codeableConcept.Codings.Add(coding);
        return codeableConcept;
    }

    public static DataCompartmentEnum ToDataCompartmentEnum(CodeableConcept codeableConcept)
    {
        if (codeableConcept.Codings.Count < 1) return DataCompartmentEnum.Unknown;

        foreach (var coding in codeableConcept.Codings)
        {
            if (coding.CodeSystem == DataCompartmentSystem)
            {
                switch (coding.Code)
                {
                    case "ARTIFACT_RESOURCE":
                        return DataCompartmentEnum.ArtifactsResourceCompartment;
                    case "CARGO_RESOURCE":
                        return DataCompartmentEnum.CargoResourceCompartment;
                    case "CLIENT_ACTIVITY_RESOURCE":
                        return DataCompartmentEnum.ClientActivityResourceCompartment;
                    case "CLIENT_ENGAGEMENT_RESOURCE":
                        return DataCompartmentEnum.ClientEngagementResourceCompartment;
                    case "CONVEYANCE_RESOURCE":
                        return DataCompartmentEnum.ConveyanceResourceCompartment;
                    case "DEPARTMENTAL_OPERATIONS":
                        return DataCompartmentEnum.DepartmentalOperationsResourceCompartment;
                    case "ENTITY_MANAGEMENT_RESOURCE":
                        return DataCompartmentEnum.EntityManagementResourceCompartment;
                    case "FINANCIAL_RESOURCE":
                        return DataCompartmentEnum.FinancialResourceCompartment;
                    case "ORGANISATIONAL_INFORMATION":
                        return DataCompartmentEnum.OrganisationalInformationCompartment;
                    case "PERSONAL_INFORMATION":
                        return DataCompartmentEnum.PersonalInformationCompartment;
                    case "REGULATORY_RESOURCE":
                        return DataCompartmentEnum.RegulatoryResourceCompartment;
                    case "SECURITY_RESOURCE":
                        return DataCompartmentEnum.SecurityResourceCompartment;
                    default:
                        return DataCompartmentEnum.Unknown;
                }
            }
        }
        return DataCompartmentEnum.Unknown;
    }
}