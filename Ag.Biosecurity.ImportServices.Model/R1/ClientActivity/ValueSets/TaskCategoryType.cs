using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

public class TaskCategoryType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-task-category-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly TaskCategoryType AssessmentActivity = new TaskCategoryType( "Assessment", "TaskCategoryType.Assessment", CodeSystemId, CodeSystemVersion, "Assessment Task", "414BBBEC-3F8C-474C-A42A-60648A58B298"  );
    public static readonly TaskCategoryType InspectionActivity = new TaskCategoryType( "Inspection", "TaskCategoryType.Inspection", CodeSystemId, CodeSystemVersion, "Inspection Task", "AC64443F-CC5F-4727-81C8-081F67AAABEE"  );

    
    private TaskCategoryType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<TaskCategoryType> TaskCategoryTypes
    {
        get
        {
            yield return AssessmentActivity;
            yield return InspectionActivity;
        }
    }

    private static TaskCategoryType FromCode(string code)
    {
        foreach(TaskCategoryType directionType in TaskCategoryTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedTaskCategoryTypeException(code);
    }

    private static TaskCategoryType FromGuid(string guid)
    {
        foreach(TaskCategoryType directionType in TaskCategoryTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedTaskCategoryTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(TaskCategoryType roleCategoryType)
    {
        return roleCategoryType.ToString();
    }

    public static explicit operator TaskCategoryType(string code)
    {
        return FromCode(code);
    }
}