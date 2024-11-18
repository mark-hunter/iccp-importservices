using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.ValueSets;

public class DirectionStatusType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-status-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly DirectionStatusType InProgress = new DirectionStatusType( "In Progress", "InProgress", "DirectionStatusType.InProgress", CodeSystemId, CodeSystemVersion, "Direction Status - In Progress", "0"  );
    public static readonly DirectionStatusType Completed = new DirectionStatusType( "Completed", "Completed", "DirectionStatusType.Completed", CodeSystemId, CodeSystemVersion, "Direction Status - Activity", "1"  );

    private DirectionStatusType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Name = name;
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        LegacyGuid = legacyGuid;
    }

    private static IEnumerable<DirectionStatusType> DirectionStatusTypes
    {
        get
        {
            yield return InProgress;
            yield return Completed;

        }

    }
    private static DirectionStatusType From(string code)
    {
        foreach(DirectionStatusType directionType in DirectionStatusTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDirectionStatusTypeException(code);
    }
    
    private static DirectionStatusType FromAimsCode(string legacyGuid)
    {
        foreach(DirectionStatusType directionType in DirectionStatusTypes )

            if (string.Equals(directionType.LegacyGuid, legacyGuid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDirectionStatusTypeException(legacyGuid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(DirectionStatusType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator DirectionStatusType(string code)
    {
        return From(code);
    }   
}