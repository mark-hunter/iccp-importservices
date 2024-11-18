using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

public class TaskPriorityType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-task-priority-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly TaskPriorityType Routine = new TaskPriorityType( "Routine", "TaskPriorityType.Routing", CodeSystemId, CodeSystemVersion, "Routine Task Priority", ""  );
    public static readonly TaskPriorityType Urgent = new TaskPriorityType( "Urgent", "TaskPriorityType.Urgent", CodeSystemId, CodeSystemVersion, "Urgent Task Priority", ""  );
    public static readonly TaskPriorityType Critical = new TaskPriorityType( "Critical", "TaskPriorityType.Critical", CodeSystemId, CodeSystemVersion, "Critical Task Priority", ""  );

    
    private TaskPriorityType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<TaskPriorityType> TaskTypes
    {
        get
        {
            yield return Routine;
            yield return Urgent;
            yield return Critical;
        }
    }

    private static TaskPriorityType FromCode(string code)
    {
        foreach(TaskPriorityType directionType in TaskTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedTaskPriorityTypeException(code);
    }

    private static TaskPriorityType FromGuid(string guid)
    {
        foreach(TaskPriorityType directionType in TaskTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedTaskPriorityTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(TaskPriorityType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator TaskPriorityType(string code)
    {
        return FromCode(code);
    }
}