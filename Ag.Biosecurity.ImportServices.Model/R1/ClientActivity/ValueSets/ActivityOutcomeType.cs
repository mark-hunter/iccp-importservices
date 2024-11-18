using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

public class ActivityOutcomeType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/activity-outcome-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly ActivityOutcomeType InitDocument = new ActivityOutcomeType( "IM-OUTCOME-TPE-INIT-DOCO", "OutcomeType.InitDocument", CodeSystemId, CodeSystemVersion, "Outcome Type - Init Document", ""  );
    public static readonly ActivityOutcomeType Administration= new ActivityOutcomeType( "IM-OUTCOME-TPE-ADMIN", "OutcomeType.Administration", CodeSystemId, CodeSystemVersion, "Outcome Type - Administration", ""  );
    public static readonly ActivityOutcomeType Released = new ActivityOutcomeType( "IM-OUTCOME-TPE-REL", "OutcomeType.Released", CodeSystemId, CodeSystemVersion, "Outcome Type - Released", ""  );
    public static readonly ActivityOutcomeType Disposal = new ActivityOutcomeType( "IM-OUTCOME-TPE-DISPOSAL", "OutcomeType.Disposal", CodeSystemId, CodeSystemVersion, "Outcome Type - Disposal", ""  );
    public static readonly ActivityOutcomeType Export= new ActivityOutcomeType( "IM-OUTCOME-TPE-EXPORT", "OutcomeType.Export", CodeSystemId, CodeSystemVersion, "Outcome Type - Export", ""  );
    public static readonly ActivityOutcomeType Destruction= new ActivityOutcomeType( "IM-OUTCOME-TPE-DSTRUCN", "OutcomeType.Destruction", CodeSystemId, CodeSystemVersion, "Outcome Type - Destruction", ""  );
    public static readonly ActivityOutcomeType FinalisedNotReleased = new ActivityOutcomeType( "IM-OUTCOME-TPE-FNLSD-NOT-RLSD", "OutcomeType.FinalisedNotReleased", CodeSystemId, CodeSystemVersion, "Outcome Type - Finalised Not Released", ""  );
    public static readonly ActivityOutcomeType Movement = new ActivityOutcomeType( "IM-OUTCOME-TPE-MVMNT", "OutcomeType.Movement", CodeSystemId, CodeSystemVersion, "Outcome Type - Movement", ""  );
    public static readonly ActivityOutcomeType Documentation = new ActivityOutcomeType( "IM-OUTCOME-TPE-DOCO", "OutcomeType.Documentation", CodeSystemId, CodeSystemVersion, "Outcome Type - Documentation", ""  );
    public static readonly ActivityOutcomeType Inspection = new ActivityOutcomeType( "IM-OUTCOME-TPE-INSP", "OutcomeType.Inspection", CodeSystemId, CodeSystemVersion, "Outcome Type - Inspection", ""  );
    public static readonly ActivityOutcomeType Biosecurity = new ActivityOutcomeType( "IM-OUTCOME-TPE-BIOSEC", "OutcomeType.Biosecurity", CodeSystemId, CodeSystemVersion, "Outcome Type - Biosecurity", ""  );
    public static readonly ActivityOutcomeType Withdrawn = new ActivityOutcomeType( "IM-OUTCOME-TPE-WITHDRAWN-REL", "OutcomeType.Withdrawn", CodeSystemId, CodeSystemVersion, "Outcome Type - Withdrawn", ""  );
    public static readonly ActivityOutcomeType SecureCode = new ActivityOutcomeType( "IM-OUTCOME-TPE-SECURE", "OutcomeType.Secure", CodeSystemId, CodeSystemVersion, "Outcome Type - Secure", ""  );
    public static readonly ActivityOutcomeType Fumigation = new ActivityOutcomeType( "IM-OUTCOME-TPE-TRT-FUMGTN", "OutcomeType.Fumigation", CodeSystemId, CodeSystemVersion, "Outcome Type - Fumigation", ""  );
    public static readonly ActivityOutcomeType Irradiation = new ActivityOutcomeType( "IM-OUTCOME-TPE-TRT-IRRDTN", "OutcomeType.Irradiation", CodeSystemId, CodeSystemVersion, "Outcome Type - Irradiation", ""  );
    public static readonly ActivityOutcomeType Heat = new ActivityOutcomeType( "IM-OUTCOME-TPE-TRT-HEAT", "OutcomeType.Heat", CodeSystemId, CodeSystemVersion, "Outcome Type - Heat", ""  );
    public static readonly ActivityOutcomeType OtherTreatment = new ActivityOutcomeType( "IM-OUTCOME-TPE-TRT-OTH", "OutcomeType.OtherTreatment", CodeSystemId, CodeSystemVersion, "Outcome Type - Other Treatment", ""  );
    public static readonly ActivityOutcomeType TreatmentPrefix = new ActivityOutcomeType( "IM-OUTCOME-TPE-TRT-", "OutcomeType.TreatmentPrefix", CodeSystemId, CodeSystemVersion, "Outcome Type - Treatment Prefix", ""  );
    public static readonly ActivityOutcomeType AimsWorkload = new ActivityOutcomeType( "IM-OUTCOME-TPE-AIMS-WORKLOAD", "OutcomeType.AimsWorkload", CodeSystemId, CodeSystemVersion, "Outcome Type - AIMS Workload", ""  );

    
    private ActivityOutcomeType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<ActivityOutcomeType> TaskTypes
    {
        get
        {
            yield return InitDocument;
            yield return Administration;
            yield return Released;
            yield return Disposal;          
            yield return Export;
            yield return Destruction;
            yield return FinalisedNotReleased;
            yield return Movement;
            yield return Documentation;
            yield return Inspection;
            yield return Biosecurity;
            yield return Withdrawn;
            yield return SecureCode;
            yield return Fumigation;
            yield return Irradiation;
            yield return Heat;
            yield return OtherTreatment;
            yield return TreatmentPrefix;
            yield return AimsWorkload;
        }
    }

    private static ActivityOutcomeType FromCode(string code)
    {
        foreach(ActivityOutcomeType directionType in TaskTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedOutcomeTypeException(code);
    }

    private static ActivityOutcomeType FromGuid(string guid)
    {
        foreach(ActivityOutcomeType directionType in TaskTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedOutcomeTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ActivityOutcomeType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ActivityOutcomeType(string code)
    {
        return FromCode(code);
    }
}