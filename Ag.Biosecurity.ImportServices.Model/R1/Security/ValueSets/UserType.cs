using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class UserType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/user-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly UserType Person = new UserType( "Person", "Person", "UserType.Person", CodeSystemId, CodeSystemVersion, "A Person", ""  );
    public static readonly UserType Machine = new UserType( "Machine","Machine",  "UserType.Machine", CodeSystemId, CodeSystemVersion, "A Machine - For the Purposes of Machine-2-Machine (i.e. system-2-system, API-First, etc.) connectivity", ""  );
    
    private UserType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<UserType> UserTypes
    {
        get
        {
            yield return Person;
            yield return Machine;
        }
    }

    private static UserType FromCode(string code)
    {
        foreach(UserType directionType in UserTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedUserTypeException(code);
    }

    private static UserType FromGuid(string guid)
    {
        foreach(UserType directionType in UserTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedUserTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(UserType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator UserType(string code)
    {
        return FromCode(code);
    }
}