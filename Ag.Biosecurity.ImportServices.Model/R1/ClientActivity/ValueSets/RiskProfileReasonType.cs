using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

/// <summary>
/// This value-set was initially derived from the AIMS::ProfileReasonType reference table.
/// </summary>
public class RiskProfileReasonType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/risk-profile-reason-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly RiskProfileReasonType Unknown = new RiskProfileReasonType( "Unknown", "  ", "RiskProfileReasonType.Unknown", CodeSystemId, CodeSystemVersion, "Unknown Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType FirstTimeImporter = new RiskProfileReasonType( "FirstTimeImporter", "1STTIMEIMP", "RiskProfileReasonType.FirstTimeImporter", CodeSystemId, CodeSystemVersion, "First-Time Importer Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType DocumentDataInt = new RiskProfileReasonType( "DocumentDataInt", "DOCDATAINT", "RiskProfileReasonType.DocumentDataInt", CodeSystemId, CodeSystemVersion, "DOCDATAINT Risk Profile Reason", ""  );
    public static readonly RiskProfileReasonType GiantAfricanSnail = new RiskProfileReasonType( "GiantAfricanSnail", "GAS", "RiskProfileReasonType.GiantAfricanSnail", CodeSystemId, CodeSystemVersion, "Giant African Snail Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType Goods = new RiskProfileReasonType( "Goods", "GOODS","RiskProfileReasonType.Goods", CodeSystemId, CodeSystemVersion, "Goods Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType ICESurvey = new RiskProfileReasonType( "ICESurvey", "ICE", "RiskProfileReasonType.ICESurvey", CodeSystemId, CodeSystemVersion, "ICE Survey Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType ImportedGoods = new RiskProfileReasonType( "ImportedGoods", "IMP GOODS", "RiskProfileReasonType.ImportedGoods", CodeSystemId, CodeSystemVersion, "IMP GOODS Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType ImporterBreach = new RiskProfileReasonType( "ImporterBreach", "IMPBREACH", "RiskProfileReasonType.ImporterBreach", CodeSystemId, CodeSystemVersion, "IMPBREACH Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType NonConformance = new RiskProfileReasonType( "NonConformance", "NCONFORMCA", "RiskProfileReasonType.NonConformance", CodeSystemId, CodeSystemVersion, "Non-Conformance Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType NonCompliance = new RiskProfileReasonType( "NonCompliance", "NONCOMPLI", "RiskProfileReasonType.NonCompliance", CodeSystemId, CodeSystemVersion, "Non-Compliance Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType Other = new RiskProfileReasonType( "Other", "OTHER", "RiskProfileReasonType.Other", CodeSystemId, CodeSystemVersion, "Other Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType QuarantineBASFCLRandom = new RiskProfileReasonType( "QuarantineBASFCLRandom", "QBASFCL", "RiskProfileReasonType.QuarantineBASFCLRandom", CodeSystemId, CodeSystemVersion, "Quarantine BAS FCL Random Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType QuarantineBASLCLRandom = new RiskProfileReasonType( "QuarantineBASLCLRandom", "QBASLCL", "RiskProfileReasonType.QuarantineBASLCLRandom", CodeSystemId, CodeSystemVersion, "Quarantine BAS LCL Random Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType SupplierBreach = new RiskProfileReasonType( "SupplierBreach", "SUPBREACH", "RiskProfileReasonType.SupplierBreach", CodeSystemId, CodeSystemVersion, "Supplier Breach Risk Profile Reason Type", ""  );
    public static readonly RiskProfileReasonType UnpackForTile = new RiskProfileReasonType( "UnpackForTile", "UNPCK4TILE", "RiskProfileReasonType.UnpackForTile", CodeSystemId, CodeSystemVersion, "Unpack For Tile Risk Profile Reason Type", ""  );

    
    private RiskProfileReasonType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
        Name = name;
    }
        
    private static IEnumerable<RiskProfileReasonType> TaskTypes
    {
        get
        {
            yield return Unknown;
            yield return FirstTimeImporter;
            yield return DocumentDataInt;
            yield return GiantAfricanSnail;
            yield return Goods;
            yield return ICESurvey;
            yield return ImportedGoods;
            yield return ImporterBreach;
            yield return NonConformance;
            yield return NonCompliance;
            yield return Other;
            yield return QuarantineBASFCLRandom;
            yield return QuarantineBASLCLRandom;
            yield return SupplierBreach;
            yield return UnpackForTile;

        }
    }

    private static RiskProfileReasonType FromCode(string code)
    {
        foreach(RiskProfileReasonType directionType in TaskTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedRiskProfileReasonTypeException(code);
    }

    private static RiskProfileReasonType FromGuid(string guid)
    {
        foreach(RiskProfileReasonType directionType in TaskTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedRiskProfileReasonTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(RiskProfileReasonType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator RiskProfileReasonType(string code)
    {
        return FromCode(code);
    }
}