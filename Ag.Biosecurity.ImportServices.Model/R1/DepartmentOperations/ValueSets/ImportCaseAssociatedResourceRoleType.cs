using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class ImportCaseAssociatedResourceRoleType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-relationship-type";
    private const string CodeSystemVersion = "1.0.0";
    
    public static readonly ImportCaseAssociatedResourceRoleType CaseTriggerResource = new ImportCaseAssociatedResourceRoleType( "CaseTriggerResource", "IMPORT_CASE_ASSOCIATED_RESOURCE_ROLE_TYPE_TRIGGER_RESOURCE", "ImportCaseAssociatedResourceRoleType.TriggerResource", CodeSystemId, CodeSystemVersion, "The Referenced Resource is the Cause/Trigger of This Import Case", ""  );
    public static readonly ImportCaseAssociatedResourceRoleType CaseFocusResource = new ImportCaseAssociatedResourceRoleType( "CaseFocusResource", "IMPORT_CASE_ASSOCIATED_RESOURCE_ROLE_TYPE_FOCUS_RESOURCE", "ImportCaseAssociatedResourceRoleType.FocusResource", CodeSystemId, CodeSystemVersion, "The Referenced Resource is the Focus of this Import Case (i.e. it is the main resource being acted upon during this Import Case)", ""  );
    public static readonly ImportCaseAssociatedResourceRoleType CaseOutputResource = new ImportCaseAssociatedResourceRoleType( "CaseOutputResource", "IMPORT_CASE_ASSOCIATED_RESOURCE_ROLE_TYPE_OUTPUT_RESOURCE", "ImportCaseAssociatedResourceRoleType.OutputResource", CodeSystemId, CodeSystemVersion, "The Referenced Resource is an Output of This Import Case", ""  );

    
    private ImportCaseAssociatedResourceRoleType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        Name = name;
    }
        
    private static IEnumerable<ImportCaseAssociatedResourceRoleType> CaseRelationshipTypes
    {
        get
        {
            yield return CaseTriggerResource;
            yield return CaseFocusResource;
            yield return CaseOutputResource;
        }
    }

    private static ImportCaseAssociatedResourceRoleType FromCode(string code)
    {
        foreach(ImportCaseAssociatedResourceRoleType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseAssociatedResourceRoleTypeException(code);
    }

    private static ImportCaseAssociatedResourceRoleType FromGuid(string guid)
    {
        foreach(ImportCaseAssociatedResourceRoleType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseAssociatedResourceRoleTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseAssociatedResourceRoleType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseAssociatedResourceRoleType(string code)
    {
        return FromCode(code);
    }
}