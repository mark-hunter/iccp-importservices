using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

public class ImportCaseDependencyType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-dependency-type";
    private const string CodeSystemVersion = "1.0.0";
    
    public static readonly ImportCaseDependencyType StartDependency = new ImportCaseDependencyType( "StartDependency", "START_DEPENDENCY", "ImportCaseDependencyType.StartDependency", CodeSystemId, CodeSystemVersion, "The Dependency is required to be finished BEFORE this case STARTS.", ""  );
    public static readonly ImportCaseDependencyType FinishDependency = new ImportCaseDependencyType( "FinishDependency", "FINISH_DEPENDENCY", "ImportCaseDependencyType.FinishDependency", CodeSystemId, CodeSystemVersion, "The Dependency is required to be finished BEFORE this case FINISHES.", ""  );
    
    private ImportCaseDependencyType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        Name = name;
    }
        
    private static IEnumerable<ImportCaseDependencyType> CaseRelationshipTypes
    {
        get
        {
            yield return StartDependency;
            yield return FinishDependency;
        }
    }

    private static ImportCaseDependencyType FromCode(string code)
    {
        foreach(ImportCaseDependencyType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseDependencyTypeException(code);
    }

    private static ImportCaseDependencyType FromGuid(string guid)
    {
        foreach(ImportCaseDependencyType directionType in CaseRelationshipTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseDependencyTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseDependencyType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseDependencyType(string code)
    {
        return FromCode(code);
    }
}