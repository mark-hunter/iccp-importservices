using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

/// <summary>
/// The ImportCaseActivityStatusType captures the macro-level status of the an ImportCaseActivity.
/// This value-set was initially captured from the IMS ActivityStatusID constants class.
/// </summary>
public class ImportCaseActivityStatusType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-activity-status-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly ImportCaseActivityStatusType Pending = new ImportCaseActivityStatusType( "Pending", "ImportCaseActivityStatusType.Pending", CodeSystemId, CodeSystemVersion, "Case Activity Status - Panding", "E5952D62-1794-4802-90E3-029623594A2A"  );
    public static readonly ImportCaseActivityStatusType Completed = new ImportCaseActivityStatusType( "Completed", "ImportCaseActivityStatusType.Completed", CodeSystemId, CodeSystemVersion, "Case Activity Status - Completed", "CB65E90B-FE5D-4C2C-9F5C-FF786A6040EE"  );
    public static readonly ImportCaseActivityStatusType Cancelled = new ImportCaseActivityStatusType( "Cancelled", "ImportCaseActivityStatusType.Cancelled", CodeSystemId, CodeSystemVersion, "Case Activity Status - Cancelled", "CC445A86-C09C-416A-9A9F-13E4AE63A978"  );

    
    private ImportCaseActivityStatusType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<ImportCaseActivityStatusType> ImportCaseActivityStatusTypes
    {
        get
        {
            yield return Pending;
            yield return Completed;
            yield return Cancelled;
        }
    }

    private static ImportCaseActivityStatusType FromCode(string code)
    {
        foreach(ImportCaseActivityStatusType directionType in ImportCaseActivityStatusTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityStatusTypeException(code);
    }

    private static ImportCaseActivityStatusType FromGuid(string guid)
    {
        foreach(ImportCaseActivityStatusType directionType in ImportCaseActivityStatusTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityStatusTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseActivityStatusType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseActivityStatusType(string code)
    {
        return FromCode(code);
    }
}