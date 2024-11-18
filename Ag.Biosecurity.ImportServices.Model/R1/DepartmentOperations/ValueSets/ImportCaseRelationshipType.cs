using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class ImportCaseRelationshipType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-relationship-type";
    private const string CodeSystemVersion = "1.0.0";
    
    public static readonly ImportCaseRelationshipType SubCase = new ImportCaseRelationshipType( "SubCase", "IMPORT_CASE_RELATIONSHIP_TYPE_SUB_CASE", "ImportCaseRelationshipType.SubCase", CodeSystemId, CodeSystemVersion, "The Reference Case Is a Sub-Case (or forms a part-of) This Case", ""  );
    public static readonly ImportCaseRelationshipType DependentCase = new ImportCaseRelationshipType( "DependentCase", "IMPORT_CASE_RELATIONSHIP_TYPE_DEPENDENT_CASE", "ImportCaseRelationshipType.DependentCase", CodeSystemId, CodeSystemVersion, "The Referenced Case Is A Dependent of This Case (or requires completion of this case)", ""  );
    public static readonly ImportCaseRelationshipType PrerequisiteCase = new ImportCaseRelationshipType( "PrerequisiteCase", "IMPORT_CASE_RELATIONSHIP_TYPE_PREREQUISITE_CASE", "CaseRelationshipType.PreRequisiteCase", CodeSystemId, CodeSystemVersion, "The Referenced Case is a Pre-Requisite of This Case (or it is required to be completed prior to this case)", ""  );

    
    private ImportCaseRelationshipType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        Name = name;
    }
        
    private static IEnumerable<ImportCaseRelationshipType> CaseRelationshipTypes
    {
        get
        {
            yield return SubCase;
            yield return DependentCase;
            yield return PrerequisiteCase;
        }
    }

    private static ImportCaseRelationshipType FromCode(string code)
    {
        foreach(ImportCaseRelationshipType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseRelationshipTypeException(code);
    }

    private static ImportCaseRelationshipType FromGuid(string guid)
    {
        foreach(ImportCaseRelationshipType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseRelationshipTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseRelationshipType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseRelationshipType(string code)
    {
        return FromCode(code);
    }
}