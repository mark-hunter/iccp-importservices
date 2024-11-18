using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

public class SiteType  : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/site-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly SiteType Port = new SiteType( "Port", "SiteType.Port", "A recognised international sea port capable of supporting container management activities.");
    public static readonly SiteType Wharf = new SiteType( "Wharf", "SiteType.Wharf", "An individual wharf within a port.");
    public static readonly SiteType Warehouse = new SiteType( "Warehouse", "SiteType.Warehouse", "A warehouse supporting the importation of container and other consignment management activities.");
    public static readonly SiteType Airport = new SiteType( "Airport", "SiteType.Airport", "A recognised international or domestic airport capable of supporting the importation of goods.");
    public static readonly SiteType Campus = new SiteType( "Campus", "SiteType.Campus", "An identified collection of buildings all managed under a single entity.");
    public static readonly SiteType AirportGate = new SiteType( "AirportGate", "SiteType.AirportGate", "A single termination point for an airplane supporting the unloading and loading of people and goods.");
    public static readonly SiteType AirportTerminal = new SiteType( "AirportTerminal", "SiteType.AirportTerminal", "An identified collection of AirportGates all managed under a single entity.");
    public static readonly SiteType Building = new SiteType( "Building", "SiteType.Building", "A building...");
    public static readonly SiteType Floor = new SiteType( "Floor", "SiteType.Floor", "A singular floor within a building...");
    public static readonly SiteType Office = new SiteType( "Office", "SiteType.Office", "A singular room or group of rooms within a building...");
    private SiteType(string code, string longCode, string text)
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    
    private static IEnumerable<SiteType> SiteTypes
    {
        get
        {
            yield return Port;
            yield return Wharf;
            yield return Warehouse;
            yield return Airport;
            yield return Campus;
            yield return AirportGate;
            yield return AirportTerminal;            
            yield return Building;
            yield return Floor;
            yield return Office;
        }
    }
    
    private static SiteType From(string code)
    {
        foreach (SiteType siteType in SiteTypes)
        {
            if (string.Equals(siteType.Code, code))
            {
                return siteType;
            }
        }
        throw new UnsupportedOrganisationSiteRoleTypeException(code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(SiteType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator SiteType(string code)
    {
        return From(code);
    }
}