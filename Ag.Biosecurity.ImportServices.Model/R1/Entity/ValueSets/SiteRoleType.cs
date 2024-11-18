using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

public class SiteRoleType  : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/site-role-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly SiteRoleType GlobalHeadOffice = new SiteRoleType( "HeadOffice", "SiteRoleType.HeadOffice", "Global head office site/location of an Organisation");
    public static readonly SiteRoleType CountryHeadOffice = new SiteRoleType( "CountryHeadOffice", "SiteRoleType.CountryHeadOffice", "Country head office site/location of an Organisation");
    public static readonly SiteRoleType CountryOperationsCentre = new SiteRoleType( "CountryOperationsCentre", "SiteRoleType.CountryOperationsCentre", "Country operations centre");
    public static readonly SiteRoleType LocalOperationsSite = new SiteRoleType( "LocalOperationsSite", "SiteRoleType.LocalOperationsSite", "Local operations site");
    

    private SiteRoleType(string code, string longCode, string text)
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    
    private static IEnumerable<SiteRoleType> OrganisationSiteRoleTypes
    {
        get
        {
            yield return GlobalHeadOffice;
            yield return CountryHeadOffice;
            yield return CountryOperationsCentre;
            yield return LocalOperationsSite;
        }
    }
    
    private static SiteRoleType From(string code)
    {
        foreach (SiteRoleType relationshipType in OrganisationSiteRoleTypes)
        {
            if (string.Equals(relationshipType.Code, code))
            {
                return relationshipType;
            }
        }
        throw new UnsupportedOrganisationSiteRoleTypeException(code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(SiteRoleType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator SiteRoleType(string code)
    {
        return From(code);
    }
}