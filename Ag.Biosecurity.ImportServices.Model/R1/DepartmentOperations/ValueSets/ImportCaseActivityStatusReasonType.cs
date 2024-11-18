using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

/// <summary>
/// The ImportCaseActivityStatusReasonType captures the macro-level status of the an ImportCaseActivity.
/// This value-set was initially captured from the IMS ReasonType constants class.
/// </summary>
public class ImportCaseActivityStatusReasonType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-activity-status-reason-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly ImportCaseActivityStatusReasonType NewEntry = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-NEW-ENTRY", "ImportCaseActivityStatusReasonType.NewEntry", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - New Entry", ""  );
    public static readonly ImportCaseActivityStatusReasonType Duplicate = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-DUPLICATE-ENTRY", "ImportCaseActivityStatusReasonType.Duplicate", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Duplicate", ""  );
    public static readonly ImportCaseActivityStatusReasonType Revoke = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-REVOKE-RELEASE", "ImportCaseActivityStatusReasonType.Revoke", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Revoke", ""  );
    public static readonly ImportCaseActivityStatusReasonType SubjectPermitCond = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-SBJCT-PRMT-COND", "ImportCaseActivityStatusReasonType.SubjectPermitConditions", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Subject Permit Conditions", ""  );
    public static readonly ImportCaseActivityStatusReasonType ImportPermitRequirement = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-IMP-PRMT-REQMNT", "ImportCaseActivityStatusReasonType.ImportPermitRequirement", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Import Permit Requirement", ""  );
    public static readonly ImportCaseActivityStatusReasonType InternalAdviceRequired = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-INTERNAL-ADVIC-REQ", "ImportCaseActivityStatusReasonType.InternalAdviceRequired", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Internal Advice Required", ""  );
    public static readonly ImportCaseActivityStatusReasonType GoodsDestroyedOrDisposed = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-GOODS-DESTD-DISPSD", "ImportCaseActivityStatusReasonType.GoodsDestroyedOrDisposed", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Goods Destroyed Or Disposed", ""  );
    public static readonly ImportCaseActivityStatusReasonType GoodsExported = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-GOODS-EXPTD", "ImportCaseActivityStatusReasonType.GoodsExported", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Goods Exported", ""  );
    public static readonly ImportCaseActivityStatusReasonType Other_CommentsMandatory = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-OTHER-COMM-MANDATORY", "ImportCaseActivityStatusReasonType.Other_CommentsMandatory", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Other - Comments Mandatory", ""  );
    public static readonly ImportCaseActivityStatusReasonType VerifyAAResult = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-VRFY-AA-RSLT", "ImportCaseActivityStatusReasonType.VerifyAAResult", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Verify Approved Arrangement Result", ""  );
    public static readonly ImportCaseActivityStatusReasonType TargetedProfile = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-TARGET-PROFILE", "ImportCaseActivityStatusReasonType.TargetedProfile", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Target Profile", ""  );
    public static readonly ImportCaseActivityStatusReasonType AirCargoComplianceVerification = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-AIR-CRGO-COML-VRFCTN", "ImportCaseActivityStatusReasonType.AirCargoComplianceVerification", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Air Cargo Compliance Verification", ""  );
    public static readonly ImportCaseActivityStatusReasonType SeedsNotForSowing = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-SEEDS-NOT-FOR-SOWNG", "ImportCaseActivityStatusReasonType.SeedsNotForSowing", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Seeds Not For Sowing", ""  );
    public static readonly ImportCaseActivityStatusReasonType SeedsForSowing = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-SEEDS-FOR-SOWING", "ImportCaseActivityStatusReasonType.SeedsForSowing", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Seeds For Sowing", ""  );
    public static readonly ImportCaseActivityStatusReasonType BiosecurityHazard = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-BIO-HAZRD", "ImportCaseActivityStatusReasonType.BiosecurityHazard", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Biosecurity Hazard", ""  );
    public static readonly ImportCaseActivityStatusReasonType ClientAdviceRequired = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-CLIENT-ADVIC-REQ", "ImportCaseActivityStatusReasonType.ClientAdviceRequired", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Client Advice Required", ""  );
    public static readonly ImportCaseActivityStatusReasonType ClientAdviceRequiredInspection = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-CLIENT-ADVICE-REQD-INSP", "ImportCaseActivityStatusReasonType.ClientAdviceRequiredInspection", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Client Advice Required Inspection", ""  );
    public static readonly ImportCaseActivityStatusReasonType ClientAdviceRequiredDocumentation = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-CLIENT-ADVICE-REQD-DOCO", "ImportCaseActivityStatusReasonType.ClientAdviceRequiredDocumentation", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Client Advice Required Documentation", ""  );
    public static readonly ImportCaseActivityStatusReasonType ImporterDeclinedTreatment = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-IMPTER-DECLINE-TREAT", "ImportCaseActivityStatusReasonType.ImporterDeclinedTreatment", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Importer Declined Treatment", ""  );
    public static readonly ImportCaseActivityStatusReasonType ImporterFailedToProvideAtt = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-IMPTER-FAIL-PROV-ATT", "ImportCaseActivityStatusReasonType.ImporterFailedToProvideAttachments", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Importer Failed To Provide Attachments", ""  );
    public static readonly ImportCaseActivityStatusReasonType BiosecurityImportConditionsPermitCondition = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-BICON-PRMT-CONDTN", "ImportCaseActivityStatusReasonType.BiosecurityImportConditionsPermitCondition", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Biosecurity Import Conditions Permit Condition", ""  );
    public static readonly ImportCaseActivityStatusReasonType BiosecurityImportConditionsOnshoreRequirement = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-BICON-ONSH-REQMT", "ImportCaseActivityStatusReasonType.BiosecurityImportConditionsOnshoreRequirement", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Biosecurity Import Conditions Onshore Requirement", ""  );
    public static readonly ImportCaseActivityStatusReasonType OperationalScienceServicesAdvice = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-OSS-ADVICE", "ImportCaseActivityStatusReasonType.OperationalScienceServicesAdvice", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Operational Science Services Advice", ""  );
    public static readonly ImportCaseActivityStatusReasonType WorkloadNotSupported = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-WORKLOAD-NOT-SUPPORTED", "ImportCaseActivityStatusReasonType.WorkloadNotSupported", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Workload Not Supported", ""  );
    public static readonly ImportCaseActivityStatusReasonType DocumentationNotPresentedOrInsufficient = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-DOC-REQ-NOTMET-INSUF", "ImportCaseActivityStatusReasonType.DocumentationNotPresentedOrInsufficient", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Documentation Not Present or Insufficient", ""  );
    public static readonly ImportCaseActivityStatusReasonType DocumentationNotMet = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-DOC-REQ-NOTMET", "ImportCaseActivityStatusReasonType.DocumentationNotMet", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Documentation Not Met", ""  );
    public static readonly ImportCaseActivityStatusReasonType DocumentationNotPresented = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-DOC-NOT-PRES", "ImportCaseActivityStatusReasonType.DocumentationNotPresented", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Documentation Not Present", ""  );
    public static readonly ImportCaseActivityStatusReasonType NotOfBiosecurityConcern = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-NOT-BIO-CONCRN", "ImportCaseActivityStatusReasonType.Cancelled", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - Cancelled", ""  );
    public static readonly ImportCaseActivityStatusReasonType PeIndicatorY = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-PEIND-Y", "ImportCaseActivityStatusReasonType.PeIndicatorY", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - PE Indicator Y", ""  );
    public static readonly ImportCaseActivityStatusReasonType CALReasonType = new ImportCaseActivityStatusReasonType( "IM-REASON-TPE-CAL", "ImportCaseActivityStatusReasonType.CALReasonType", CodeSystemId, CodeSystemVersion, "Case Activity Status Reason - CAL Reason Type", ""  );

    
    private ImportCaseActivityStatusReasonType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<ImportCaseActivityStatusReasonType> ImportCaseActivityStatusReasonTypes
    {
        get
        {
            yield return NewEntry;
            yield return Duplicate;
            yield return Revoke;
            yield return SubjectPermitCond;
            yield return ImportPermitRequirement;
            yield return InternalAdviceRequired;
            yield return GoodsDestroyedOrDisposed;
            yield return GoodsExported;
            yield return Other_CommentsMandatory;
            yield return VerifyAAResult;
            yield return TargetedProfile;
            yield return AirCargoComplianceVerification;
            yield return SeedsNotForSowing;
            yield return SeedsForSowing;
            yield return BiosecurityHazard;
            yield return ClientAdviceRequired;
            yield return ClientAdviceRequiredInspection;
            yield return ClientAdviceRequiredDocumentation;
            yield return ImporterDeclinedTreatment;
            yield return ImporterFailedToProvideAtt;
            yield return BiosecurityImportConditionsPermitCondition;
            yield return BiosecurityImportConditionsOnshoreRequirement;
            yield return OperationalScienceServicesAdvice;
            yield return WorkloadNotSupported;
            yield return DocumentationNotPresentedOrInsufficient;
            yield return DocumentationNotMet;
            yield return DocumentationNotPresented;
            yield return NotOfBiosecurityConcern;
            yield return PeIndicatorY;
            yield return CALReasonType;

        }
    }

    private static ImportCaseActivityStatusReasonType FromCode(string code)
    {
        foreach(ImportCaseActivityStatusReasonType directionType in ImportCaseActivityStatusReasonTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityStatusReasonTypeException(code);
    }

    private static ImportCaseActivityStatusReasonType FromGuid(string guid)
    {
        foreach(ImportCaseActivityStatusReasonType directionType in ImportCaseActivityStatusReasonTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedImportCaseActivityStatusReasonTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(ImportCaseActivityStatusReasonType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator ImportCaseActivityStatusReasonType(string code)
    {
        return FromCode(code);
    }
}