using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

public class IdentityProofingLevelType  : ValueDataType
{
       private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/data-classification-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly IdentityProofingLevelType Basic = new IdentityProofingLevelType( "Basic", "LEVEL_1", "IdentityProofingLevelType.Level1", CodeSystemId, CodeSystemVersion, "Identity Proofing Level 1 and Identity Proofing Level 1+", ""  );
    public static readonly IdentityProofingLevelType Standard = new IdentityProofingLevelType( "Standard","LEVEL_2",  "IdentityProofingLevelType.Level2", CodeSystemId, CodeSystemVersion, "Identity Proofing Level 2 and Identity Proofing Level 2+", ""  );
    public static readonly IdentityProofingLevelType Strong = new IdentityProofingLevelType( "Strong","LEVEL_3",  "IdentityProofingLevelType.Level3", CodeSystemId, CodeSystemVersion, "Identity Proofing Level 3", ""  );

    
    private IdentityProofingLevelType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<IdentityProofingLevelType> IdentityProofingLevelTypes
    {
        get
        {
            yield return Basic;
            yield return Standard;
            yield return Strong;
        }
    }

    private static IdentityProofingLevelType FromCode(string code)
    {
        foreach(IdentityProofingLevelType directionType in IdentityProofingLevelTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedIdentityProofingLevelTypeException(code);
    }

    private static IdentityProofingLevelType FromGuid(string guid)
    {
        foreach(IdentityProofingLevelType directionType in IdentityProofingLevelTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedIdentityProofingLevelTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(IdentityProofingLevelType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator IdentityProofingLevelType(string code)
    {
        return FromCode(code);
    } 
}