using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchitypes.ValueSets;

public class DirectionLevelType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-level-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly DirectionLevelType LineMode = new DirectionLevelType( "Line Mode", "Line", "DirectionLevel.Line", CodeSystemId, CodeSystemVersion, "Direction Level - Line Base Direction", "0"  );
    public static readonly DirectionLevelType ContainerMode = new DirectionLevelType( "Container Mode", "Container", "DirectionLevel.Container", CodeSystemId, CodeSystemVersion, "Direction Level - Container Based Direction", "1"  );

    private DirectionLevelType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Name = name;
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        LegacyGuid = legacyGuid;
    }

    private static IEnumerable<DirectionLevelType> DirectionLevelTypes
    {
        get
        {
            yield return LineMode;
            yield return ContainerMode;
        }

    }
    private static DirectionLevelType FromAimsCode(string legacyGuid)
    {
        foreach(DirectionLevelType directionLevelType in DirectionLevelTypes )

            if (string.Equals(directionLevelType.LegacyGuid, legacyGuid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionLevelType);
            }

        throw new UnsupportedDirectionLevelTypeException(legacyGuid);
    }
    
    private static DirectionLevelType FromCode(string code)
    {
        foreach(DirectionLevelType directionLevelType in DirectionLevelTypes )

            if (string.Equals(directionLevelType.LongCode, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionLevelType);
            }

        throw new UnsupportedDirectionLevelTypeException(code);
    }
    
    private static DirectionLevelType FromName(string name)
    {
        foreach(DirectionLevelType directionLevelType in DirectionLevelTypes )

            if (string.Equals(directionLevelType.Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return (directionLevelType);
            }

        throw new UnsupportedDirectionLevelTypeException(name);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(DirectionLevelType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator DirectionLevelType(string name)
    {
        return FromName(name);
    }
    
}