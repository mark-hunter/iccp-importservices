using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

public class ConcernType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-category-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly ConcernType SACUserDirections = new ConcernType( "SACUserDirections", "CAT-SAC-USER", "IM-DIRECTION-CAT-SAC-USER", CodeSystemId, CodeSystemVersion, "Direction Category - SAC User", "E876A673-34EE-4BBA-B04D-2AC602F6FD62"  );
    public static readonly ConcernType SACAdminDirections = new ConcernType( "SACAdminDirections", "CAT-SAC-ADMIN", "IM-DIRECTION-CAT-SAC-ADMIN", CodeSystemId, CodeSystemVersion, "Direction Category - SAC Admin", "0AE05457-EA31-4C91-8823-3E1565CFEC95"  );
    public static readonly ConcernType Administration = new ConcernType( "Administration", "CAT-ADMIN", "IM-DIRECTION-CAT-ADMIN", CodeSystemId, CodeSystemVersion, "Direction Category - Administration", "E681A0B6-315F-44E6-886D-BE7AE589655C"  );

    private ConcernType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Name = name;
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        LegacyGuid = legacyGuid;
    }

    private static IEnumerable<ConcernType> ConcernTypes
    {
        get
        {
            yield return SACUserDirections;
            yield return SACAdminDirections;
            yield return Administration;

        }

    }
    private static ConcernType FromAimsCategoryId(string legacyGuid)
    {
        foreach(ConcernType directionType in ConcernTypes )

            if (string.Equals(directionType.LegacyGuid, legacyGuid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedConcernTypeException(legacyGuid);
    }
    
    private static ConcernType FromAimsCategoryCode(string longCode)
    {
        foreach(ConcernType directionType in ConcernTypes )

            if (string.Equals(directionType.LongCode, longCode, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedConcernTypeException(longCode);
    }
    
    private static ConcernType FromName(string name)
    {
        foreach(ConcernType directionType in ConcernTypes )

            if (string.Equals(directionType.Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedConcernTypeException(name);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ConcernType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ConcernType(string name)
    {
        return FromName(name);
    }
    
}