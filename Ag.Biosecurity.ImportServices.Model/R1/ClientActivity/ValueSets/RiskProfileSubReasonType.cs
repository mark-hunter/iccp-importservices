using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

/// <summary>
/// This value-set was initially derived from the AIMS::ProfileSubReasonType reference table.
/// </summary>
public class RiskProfileSubReasonType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/risk-profile-sub-reason-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly RiskProfileSubReasonType FoodHighRisk = new RiskProfileSubReasonType( "HighRisk.Food", "FOOD-HRISK", "RiskProfileSubReasonType.HighRisk-Food", CodeSystemId, CodeSystemVersion, "Food High Risk Sub Reason Type", ""  );
    public static readonly RiskProfileSubReasonType HighRisk = new RiskProfileSubReasonType( "HighRisk", "HIGH", "RiskProfileSubReasonType.HighRisk", CodeSystemId, CodeSystemVersion, "High Risk Sub Reason Type (Based on ICS CPRISKSKSTYP)", ""  );
    public static readonly RiskProfileSubReasonType HighPerformanceRisk = new RiskProfileSubReasonType( "HighPerformanceRisk", "HIGH PERF", "RiskProfileSubReasonType.HighPerformanceRisk", CodeSystemId, CodeSystemVersion, "High Perf Sub Reason Type", ""  );
    public static readonly RiskProfileSubReasonType PotentialRisk = new RiskProfileSubReasonType( "PotentialRisk", "POTENTIAL", "RiskProfileSubReasonType.PotentialRisk", CodeSystemId, CodeSystemVersion, "Potential Risk Sub Reason Type (Based on ICS CPRISKSTYP)", ""  );

    
    private RiskProfileSubReasonType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        Name = name;
    }
        
    private static IEnumerable<RiskProfileSubReasonType> TaskTypes
    {
        get
        {
            yield return FoodHighRisk;
            yield return HighRisk;
            yield return HighPerformanceRisk;
            yield return PotentialRisk;
        }
    }

    private static RiskProfileSubReasonType FromCode(string code)
    {
        foreach(RiskProfileSubReasonType directionType in TaskTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedRiskProfileSubReasonTypeException(code);
    }

    private static RiskProfileSubReasonType FromGuid(string guid)
    {
        foreach(RiskProfileSubReasonType directionType in TaskTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedRiskProfileSubReasonTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(RiskProfileSubReasonType roleSubReasonType)
    {
        return roleSubReasonType.ToString();
    }

    public static explicit operator RiskProfileSubReasonType(string code)
    {
        return FromCode(code);
    }
}