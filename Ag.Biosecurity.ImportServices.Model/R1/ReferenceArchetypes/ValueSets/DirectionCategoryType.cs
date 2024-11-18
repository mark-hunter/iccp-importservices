using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

public class DirectionCategoryType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-category-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly DirectionCategoryType SACUserDirections = new DirectionCategoryType( "SACUserDirections", "CAT-SAC-USER", "IM-DIRECTION-CAT-SAC-USER", CodeSystemId, CodeSystemVersion, "Direction Category - SAC User", "E876A673-34EE-4BBA-B04D-2AC602F6FD62"  );
    public static readonly DirectionCategoryType SACAdminDirections = new DirectionCategoryType( "SACAdminDirections", "CAT-SAC-ADMIN", "IM-DIRECTION-CAT-SAC-ADMIN", CodeSystemId, CodeSystemVersion, "Direction Category - SAC Admin", "0AE05457-EA31-4C91-8823-3E1565CFEC95"  );
    public static readonly DirectionCategoryType Administration = new DirectionCategoryType( "Administration", "CAT-ADMIN", "IM-DIRECTION-CAT-ADMIN", CodeSystemId, CodeSystemVersion, "Direction Category - Administration", "E681A0B6-315F-44E6-886D-BE7AE589655C"  );

    private DirectionCategoryType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Name = name;
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        LegacyGuid = legacyGuid;
    }

    private static IEnumerable<DirectionCategoryType> DirectionCategoryTypes
    {
        get
        {
            yield return SACUserDirections;
            yield return SACAdminDirections;
            yield return Administration;

        }

    }
    private static DirectionCategoryType FromAimsCategoryId(string legacyGuid)
    {
        foreach(DirectionCategoryType directionType in DirectionCategoryTypes )

            if (string.Equals(directionType.LegacyGuid, legacyGuid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDirectionCategoryTypeException(legacyGuid);
    }
    
    private static DirectionCategoryType FromAimsCategoryCode(string longCode)
    {
        foreach(DirectionCategoryType directionType in DirectionCategoryTypes )

            if (string.Equals(directionType.LongCode, longCode, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDirectionCategoryTypeException(longCode);
    }
    
    private static DirectionCategoryType FromName(string name)
    {
        foreach(DirectionCategoryType directionType in DirectionCategoryTypes )

            if (string.Equals(directionType.Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDirectionCategoryTypeException(name);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(DirectionCategoryType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator DirectionCategoryType(string name)
    {
        return FromName(name);
    }
    
}