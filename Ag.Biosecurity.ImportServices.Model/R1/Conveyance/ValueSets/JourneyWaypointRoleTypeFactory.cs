using System.Diagnostics;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Coneyance.ValueSets;

public static class JourneyWaypointRoleTypeFactory
{
    public static string systemId = "https://aff.gov.au/imports/iccp/journey-waypoint-type";
    public static string versionId = "R1";

    public static CodeableConcept WaypointRoleToCodeableConcept(JourneyWaypointRoleTypeEnum journeyWaypointRoleType)
    {
        CodeableConcept codeableConcept = new CodeableConcept();
        Coding coding = new Coding();
        coding.CodeVersion = versionId;
        coding.CodeSystem = systemId;
        switch (journeyWaypointRoleType)
        {
            case JourneyWaypointRoleTypeEnum.Origin:
            {
                coding.Code = "ORIGIN";
                coding.Text = "Origin";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_ORIGIN";
                codeableConcept.DisplayText = "Journey Waypoint Type = Origin";
                break;
            }
            case JourneyWaypointRoleTypeEnum.Destination:
            {
                coding.Code = "DESTINATION";
                coding.Text = "Destination";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_DESTINATION";
                codeableConcept.DisplayText = "Journey Waypoint Type = Destination";
                break;
            }
            case JourneyWaypointRoleTypeEnum.DestinationPort:
            {
                coding.Code = "DESTINATION_PORT";
                coding.Text = "DestinationPort";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_DESTINATION_PORT";
                codeableConcept.DisplayText = "Journey Waypoint Type = Destination Port";
                break;
            }
            case JourneyWaypointRoleTypeEnum.DischargePort:
            {
                coding.Code = "DISCHARGE_PORT";
                coding.Text = "DischargePort";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_DISCHARGE_PORT";
                codeableConcept.DisplayText = "Journey Waypoint Type = Discharge Port";
                break;
            }
            case JourneyWaypointRoleTypeEnum.RoutingPort:
            {
                coding.Code = "ROUTING_PORT";
                coding.Text = "RoutingPort";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_ROUTING_PORT";
                codeableConcept.DisplayText = "Journey Waypoint Type = Routing Port";
                break;
            }
            case JourneyWaypointRoleTypeEnum.LoadingPort:
            {
                coding.Code = "LOADING_PORT";
                coding.Text = "LoadingPort";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_LOADING_PORT";
                codeableConcept.DisplayText = "Journey Waypoint Type = Loading Port";
                break;
            }
            case JourneyWaypointRoleTypeEnum.DisposalSite:
            {
                coding.Code = "DISPOSAL_SITE";
                coding.Text = "DisposalSite";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_DISPOSAL_SITE";
                codeableConcept.DisplayText = "Journey Waypoint Type = Disposal Site";
                break;
            }
            case JourneyWaypointRoleTypeEnum.InspectionSite:
            {
                coding.Code = "INSPECTION_SITE";
                coding.Text = "InspectionSite";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_INSPECTION_SITE";
                codeableConcept.DisplayText = "Journey Waypoint Type = Inspection Site";
                break;
            }
            case JourneyWaypointRoleTypeEnum.TreatmentSite:
            {
                coding.Code = "TREATMENT_SITE";
                coding.Text = "TreatmentSite";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_TREATMENT_SITE";
                codeableConcept.DisplayText = "Journey Waypoint Type = Treatment Site";
                break;
            }
            default:
            {
                coding.Code = "UNKNOWN";
                coding.Text = "Unknown";
                codeableConcept.Value = "JOURNEY_WAYPOINT_TYPE_Unknown";
                codeableConcept.DisplayText = "Journey Waypoint Type = Unknown";
                break;
            }
        }
        codeableConcept.Codings.Add(coding);
        return (codeableConcept);
    }

    public static JourneyWaypointRoleTypeEnum CodeableConceptToJourneyWaypointRoleType(CodeableConcept codeableConcept)
    {
        if (codeableConcept == null)
        {
            return (JourneyWaypointRoleTypeEnum.Unknown);
        }

        if (codeableConcept.Codings.Count < 1)
        {
            return (JourneyWaypointRoleTypeEnum.Unknown);
        }

        foreach (Coding coding in codeableConcept.Codings)
        {
            if (coding.CodeSystem.Equals(systemId))
            {
                switch (coding.Code)
                {
                    case "ORIGIN":
                    {
                        return (JourneyWaypointRoleTypeEnum.Origin);
                    }
                    case "DESTINATION":
                    {
                        return (JourneyWaypointRoleTypeEnum.Destination);
                    }
                    case "DESTINATION_PORT":
                    {
                        return (JourneyWaypointRoleTypeEnum.DestinationPort);
                    }
                    case "DISCHARGE_PORT":
                    {
                        return (JourneyWaypointRoleTypeEnum.DischargePort);
                    }
                    case "ROUTING_PORT":
                    {
                        return (JourneyWaypointRoleTypeEnum.RoutingPort);
                    }
                    case "LOADING_PORT":
                    {
                        return (JourneyWaypointRoleTypeEnum.LoadingPort);
                    }
                    case "DISPOSAL_SITE":
                    {
                        return (JourneyWaypointRoleTypeEnum.DisposalSite);
                    }
                    case "INSPECTION_SITE":
                    {
                        return (JourneyWaypointRoleTypeEnum.InspectionSite);
                    }
                    case "TREATMENT_SITE":
                    {
                        return (JourneyWaypointRoleTypeEnum.TreatmentSite);
                    }
                    case "UNKNOWN":
                    default:
                    {
                        return (JourneyWaypointRoleTypeEnum.Unknown);
                    }
                }
            }
        }

        return (JourneyWaypointRoleTypeEnum.Unknown);
    }
}