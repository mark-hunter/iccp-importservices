// Copyright (c) 2024 Australian Department of Agriculture, Fisheries and Forestry 

using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

public class ImportLocationRoleType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/location-role-type";
    private const string CodeSystemVersion = "1.0.0";
        
    public static readonly ImportLocationRoleType Origin = new ImportLocationRoleType( "Origin", "ImportLocationRoleType.Origin", "The origin of the Imported Item - within the context of the Importation activity.");
    public static readonly ImportLocationRoleType EntryPoint = new ImportLocationRoleType( "EntryPoint", "ImportLocationRoleType.EntryPoint", "The entry point of the Imported Item - within the context of the Importation activity.");
    public static readonly ImportLocationRoleType LoadingPort = new ImportLocationRoleType( "LoadingPort", "ImportLocationRoleType.LoadingPort", "The port/location at which the imported item was loaded onto the conveyance method for delivery to an australian port.");
    public static readonly ImportLocationRoleType DischargePort = new ImportLocationRoleType( "DischargePort", "ImportLocationRoleType.DischargePort", "To Be Documented");
    public static readonly ImportLocationRoleType RoutingPort = new ImportLocationRoleType( "RoutingPort", "ImportLocationRoleType.RoutingPort", "To Be Documented");
    public static readonly ImportLocationRoleType DestinationPort = new ImportLocationRoleType( "DestinationPort", "ImportLocationRoleType.DestinationPort", "To Be Documented");
    public static readonly ImportLocationRoleType Destination = new ImportLocationRoleType( "Destination", "ImportLocationRoleType.Destination", "To Be Documented");
    public static readonly ImportLocationRoleType InspectionSite = new ImportLocationRoleType( "InspectionSite", "ImportLocationRoleType.InspectionSite", "To Be Documented");
    public static readonly ImportLocationRoleType TreatmentSite = new ImportLocationRoleType( "TreatmentSite", "ImportLocationRoleType.TreatmentSite", "To Be Documented");
    public static readonly ImportLocationRoleType DisposalSite = new ImportLocationRoleType( "DisposalSite", "ImportLocationRoleType.DisposalSite", "To Be Documented");
    public static readonly ImportLocationRoleType Unknown = new ImportLocationRoleType( "Unknown", "ImportLocationRoleType.Unknown", "Unknown");

    private ImportLocationRoleType(string code, string longCode, string text)
    {
        Code = code;
        LongCode = longCode;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
        Text = text;
    }
    
    private static IEnumerable<ImportLocationRoleType> LocationRoleTypes
    {
        get
        {
            yield return Origin;
            yield return EntryPoint;
            yield return LoadingPort;
            yield return DischargePort;
            yield return RoutingPort;
            yield return DestinationPort;
            yield return Destination;
            yield return InspectionSite;
            yield return TreatmentSite;
            yield return DisposalSite;
            yield return Unknown;
        }
    }
    
    private static ImportLocationRoleType From(string code)
    {
        foreach (ImportLocationRoleType roleType in LocationRoleTypes)
        {
            if (string.Equals(roleType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (roleType);
            }
        }
        throw new UnsupportedEntityRoleTypeException(code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportLocationRoleType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportLocationRoleType(string code)
    {
        return From(code);
    }
}