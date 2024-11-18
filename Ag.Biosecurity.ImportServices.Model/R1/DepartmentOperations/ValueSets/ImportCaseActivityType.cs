using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class ImportCaseActivityType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-activity-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly ImportCaseActivityType AssessmentActivity = new ImportCaseActivityType( "IM-ACTIVITY-TPE-ASSMNT", "ImportCaseActivityType.AssessmentActivity", CodeSystemId, CodeSystemVersion, "Assessment Case Activity", "D9B32D54-542E-4CD6-AF67-4C634F1F2EEE"  );
    public static readonly ImportCaseActivityType InspectionActivity = new ImportCaseActivityType( "IM-ACTIVITY-TPE-INSPECTION", "ImportCaseActivityType.InspectionActivity", CodeSystemId, CodeSystemVersion, "Inspection Case Activity", "48F283F8-C8B7-4C88-B2B7-AACFEA186EC2"  );

    
    private ImportCaseActivityType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<ImportCaseActivityType> ImportCaseActivityTypes
    {
        get
        {
            yield return AssessmentActivity;
            yield return InspectionActivity;
        }
    }

    private static ImportCaseActivityType FromCode(string code)
    {
        foreach(ImportCaseActivityType directionType in ImportCaseActivityTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityTypeException(code);
    }

    private static ImportCaseActivityType FromGuid(string guid)
    {
        foreach(ImportCaseActivityType directionType in ImportCaseActivityTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseActivityType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseActivityType(string code)
    {
        return FromCode(code);
    }
}