using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class DataClassificationType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/data-classification-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly DataClassificationType None = new DataClassificationType( "None", "NONE", "DataClassificationType.None", CodeSystemId, CodeSystemVersion, "No Data Classification", ""  );
    public static readonly DataClassificationType Private = new DataClassificationType( "Private","PRIVATE",  "DataClassificationType.Private", CodeSystemId, CodeSystemVersion, "Private Data Classification - Data Is Private to an Individual", ""  );
    public static readonly DataClassificationType Organisational = new DataClassificationType( "Organisational","ORGANISATIONAL",  "DataClassificationType.Organisational", CodeSystemId, CodeSystemVersion, "Organisational Data Classification - Data is Private to an Organisation", ""  );
    public static readonly DataClassificationType Departmental = new DataClassificationType( "Departmental","DEPARTMENTAL",  "DataClassificationType.Departmental", CodeSystemId, CodeSystemVersion, "Departmental Data Classification - Data is Private to the Department", ""  );
    public static readonly DataClassificationType Public = new DataClassificationType( "Public","PUBLIC",  "DataClassificationType.Public", CodeSystemId, CodeSystemVersion, "Public Data Classification", ""  );

    
    private DataClassificationType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<DataClassificationType> DataClassificationTypes
    {
        get
        {
            yield return None;
            yield return Private;
            yield return Organisational;
            yield return Departmental;
            yield return Public;
        }
    }

    private static DataClassificationType FromCode(string code)
    {
        foreach(DataClassificationType directionType in DataClassificationTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDataClassificationTypeException(code);
    }

    private static DataClassificationType FromGuid(string guid)
    {
        foreach(DataClassificationType directionType in DataClassificationTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedDataClassificationTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(DataClassificationType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator DataClassificationType(string code)
    {
        return FromCode(code);
    }
}