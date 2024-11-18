using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class CredentialType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/credential-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly CredentialType MyGovId = new CredentialType( "MyGovId", "MyGovId", "CredentialType.MyGovId", CodeSystemId, CodeSystemVersion, "Australian Government - My Gov Id", ""  );
    public static readonly CredentialType LocalAccount = new CredentialType( "LocalAccount","LocalAccount",  "CredentialType.LocalAccount", CodeSystemId, CodeSystemVersion, "Azure B2C Local Account", ""  );
    public static readonly CredentialType DaffAccount = new CredentialType( "DaffAccount","DaffAccount",  "CredentialType.DaffAccount", CodeSystemId, CodeSystemVersion, "Whole of Department Client Account", ""  );
    public static readonly CredentialType MyIdentity = new CredentialType( "MyIdentity","MyIdentity",  "CredentialType.MyIdentity", CodeSystemId, CodeSystemVersion, "Departmental Internal Account", ""  );
    public static readonly CredentialType OAuth2Certificate = new CredentialType( "OAuth2Certificate","OAuth2Certificate",  "CredentialType.OAuth2Certificate", CodeSystemId, CodeSystemVersion, "Open Authorization Certificate - v2", ""  );

    
    private CredentialType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<CredentialType> CredentialTypes
    {
        get
        {
            yield return MyGovId;
            yield return LocalAccount;
            yield return DaffAccount;
            yield return MyIdentity;
            yield return OAuth2Certificate;
        }
    }

    private static CredentialType FromCode(string code)
    {
        foreach(CredentialType directionType in CredentialTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedCredentialTypeException(code);
    }

    private static CredentialType FromGuid(string guid)
    {
        foreach(CredentialType directionType in CredentialTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedCredentialTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(CredentialType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator CredentialType(string code)
    {
        return FromCode(code);
    }
}