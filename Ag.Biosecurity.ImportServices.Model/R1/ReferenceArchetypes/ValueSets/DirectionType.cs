using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

public class DirectionType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly DirectionType AirFreightInspectionCode = new DirectionType( "PE-AIRFREIGHT-INSP", "IM-DIRECTION-TPE-AIRFREIGHT-INSP", "AirFreightInspectionCode" );
    public static readonly DirectionType DestructionAutoClave = new DirectionType( "DEST-AUTCLAVE", "IM-DIRECTION-TPE-DEST-AUTCLAVE", "DestructionAutoClave");
    public static readonly DirectionType DestructionDeepBurial = new DirectionType(  "DEST-DEEP-BURL", "IM-DIRECTION-TPE-DEST-DEEP-BURL", "DestructionDeepBurial");
    public static readonly DirectionType DestructionIncineration = new DirectionType(  "DEST-INCNTION", "IM-DIRECTION-TPE-DEST-INCNTION", "DestructionIncineration");
    public static readonly DirectionType DestructionNonCommodity = new DirectionType( "DEST-NON-CMMMDTY", "IM-DIRECTION-TPE-DEST-NON-CMMMDTY", "DestructionNonCommodity");
    public static readonly DirectionType DestructionOtherApprovedMethod = new DirectionType( "DEST-OTH_APRVD_MTHD", "IM-DIRECTION-TPE-DEST-OTH_APRVD_MTHD", "DestructionOtherApprovedMethod");
    public static readonly DirectionType DestructionPartialCommodity = new DirectionType( "DEST-PARTIAL-COMMD", "IM-DIRECTION-TPE-DEST-PARTIAL_COMMD", "DestructionPartialCommodity");
    public static readonly DirectionType DestructionPrefix = new DirectionType( "DEST-PREFIX", "IM-DIRECTION-TPE-DEST-PREFIX", "DestructionPrefix");
    public static readonly DirectionType DisposalPermissionAaWasteBin = new DirectionType(  "DSPSL-PRMSN-AA-WSTE-BIN",  "IM-DIRECTION-TPE-DSPSL-PRMSN-AA-WSTE-BIN", "DisposalPermissionAaWasteBin");
    public static readonly DirectionType DisposalPermissionAAWasteBin = new DirectionType(  "DSPSL-PRMSN-A-A-WSTE-BIN", "IM-DIRECTION-TPE-DSPSL-PRMSN-A-A-WSTE-BIN", "DisposalPermissionAAWasteBin");
    public static readonly DirectionType DisposalPermissionAutoClave = new DirectionType(  "DSPSL-PRMSN-AUTCLAVE", "IM-DIRECTION-TPE-DSPSL-PRMSN-AUTCLAVE", "DisposalPermissionAutoClave");
    public static readonly DirectionType PlacedBackUnderBioSecurityControlCode = new DirectionType( "RETURN-BSC", "IM-DIRECTION-TPE-RETURN-BSC", "PlacedBackUnderBioSecurityControlCode");
    public static readonly DirectionType FinalizedAndReleasedCode = new DirectionType( "RELEASED", "IM-DIRECTION-TPE-RELEASED", "FinalizedAndReleasedCode");
    public static readonly DirectionType WithdrawalCode = new DirectionType(  "SAC-WITHDRAWAL",  "IM-DIRECTION-TPE-WITHDRAWAL", "WithdrawalCode");
    public static readonly DirectionType FinalDirectiveWithdrawn = new DirectionType( "FD-WITHDRAWN", "IM-DIRECTION-TPE-FD-WITHDRAWN", "FinalDirectiveWithdrawn");
    public static readonly DirectionType FormalEntryRequiredCode = new DirectionType( "FORMAL-ENTRY", "IM-DIRECTION-TYPE-FORMAL_ENTRY", "FormalEntryRequiredCode");
    public static readonly DirectionType MovementWithheldPendingInfo = new DirectionType( "MVMNT-WHELD-PEND-INFO", "IM-DIRECTION-TPE-MVMNT-WHELD-PEND-INFO", "MovementWithheldPendingInfo");
    public static readonly DirectionType MovementWithheldPendingInfoInsp = new DirectionType( "MVMNT-WHELD-PEND-INFO-INSP",  "IM-DIRECTION-TPE-MVMNT-WHELD-PEND-INFO-INSP", "MovementWithheldPendingInfoInsp");
    public static readonly DirectionType MovementWithheldPendingInfoDoco = new DirectionType( "MVMNT-WHELD-PEND-INFO-DOCO", "IM-DIRECTION-TPE-MVMNT-WHELD-PEND-INFO-DOCO", "MovementWithheldPendingInfoDoco");
    public static readonly DirectionType MovementWithheldPrefix = new DirectionType( "MVMNT-WHELD", "IM-DIRECTION-TPE-MVMNT-WHELD", "MovementWithheldPrefix");
    public static readonly DirectionType MovementAllowedToSpecificLocation = new DirectionType( "MVMNT-ALLWD-SPCFC-LOC", "IM-DIRECTION-TPE-MVMNT-ALLWD-SPCFC-LOC", "MovementAllowedToSpecificLocation");
    public static readonly DirectionType MovementAllowedPrefix = new DirectionType(  "MVMNT-ALLWD", "IM-DIRECTION-TPE-MVMNT-ALLWD", "MovementAllowedPrefix");
    public static readonly DirectionType FinalDirectiveSubjectToPermitConditionsCode = new DirectionType(  "FD-SBJT-PRMT-COND", "IM-DIRECTION-TPE-FD-SBJT-PRMT-COND", "FinalDirectiveSubjectToPermitConditionsCode");
    public static readonly DirectionType FinalDirectivePrefix = new DirectionType( "FD", "IM-DIRECTION-TPE-MVMNT-WHELD", "FinalDirectivePrefix");
    public static readonly DirectionType FinalDirectiveDuplicateEntryCode = new DirectionType( "DUPLICATE",  "IM-DIRECTION-TPE-DUPLICATE", "FinalDirectiveDuplicateEntryCode");
    public static readonly DirectionType PresentAllDocumentation = new DirectionType( "PRESENT-DOC", "IM-DIRECTION-TPE-PRESENT-DOC", "PresentAllDocumentation");
    public static readonly DirectionType ExportUnsupervised = new DirectionType("EXPT-UNSPRVSD", "IM-DIRECTION-TPE-EXPT-UNSPRVSD", "ExportUnsupervised");
    public static readonly DirectionType ExportSupervisedByBiosecurity = new DirectionType("EXPT-SPRVSD-BIO", "IM-DIRECTION-TPE-EXPT-SPRVSD-BIO", "ExportSupervisedByBiosecurity");
    public static readonly DirectionType ExportPartialCommodity = new DirectionType("EXPT-PARTL-CMMMDTY", "IM-DIRECTION-TPE-EXPT-PARTL-CMMMDTY", "ExportPartialCommodity");
    public static readonly DirectionType ExportPrefix = new DirectionType("EXPT", "IM-DIRECTION-TPE-EXPT", "ExportPrefix");
    public static readonly DirectionType PartialCommoditySuffix = new DirectionType("PARTL-CMMMDTY", "IM-DIRECTION-TPE-PARTL-CMMMDTY", "PartialCommoditySuffix");
    public static readonly DirectionType NonCommoditySuffix = new DirectionType("NON-CMMMDTY",  "IM-DIRECTION-TPE-NON-CMMMDTY", "NonCommoditySuffix");
    public static readonly DirectionType Heat74CVariable = new DirectionType("TRT-HT-74C-VARI",  "IM-DIRECTION-TPE-TRT-HT-74C-VARI", "Heat74CVariable");
    public static readonly DirectionType HeatRatePrescribed = new DirectionType("TRT-HT-RATE-PRESC", "IM-DIRECTION-TPE-TRT-HT-RATE-PRES", "HeatRatePrescribed");
    public static readonly DirectionType SecurePrefix = new DirectionType("SECURE", "IM-DIRECTION-TPE-SECURE", "SecurePrefix");
    public static readonly DirectionType InspectionPrefix = new DirectionType("INSP", "IM-DIRECTION-TPE-INSP", "InspectionPrefix");
    public static readonly DirectionType TreatmentPrefix = new DirectionType("TRT", "IM-DIRECTION-TPE-TRT", "TreatmentPrefix");
    public static readonly DirectionType FumigationPrefix = new DirectionType("TRT-FMG", "IM-DIRECTION-TPE-TRT-FMG", "FumigationPrefix");
    public static readonly DirectionType IrradiationPrefix = new DirectionType("TRT-IRR", "IM-DIRECTION-TPE-TRT-IRR", "IrradiationPrefix");
    public static readonly DirectionType HeatTreatPrefix = new DirectionType("TRT-HT", "IM-DIRECTION-TPE-TRT-HT", "HeatTreatPrefix");
    public static readonly DirectionType OtherTreatPrefix = new DirectionType("TRT-OTH", "IM-DIRECTION-TPE-TRT-OTH", "OtherTreatPrefix");
    public static readonly DirectionType FinalDirectiveExported = new DirectionType( "FD-EXPRTD", "IM-DIRECTION-TPE-FD-EXPRTD", "FinalDirectiveExported");
    public static readonly DirectionType FinalDirectiveDestroyed = new DirectionType( "FD-DSTRYD", "IM-DIRECTION-TPE-FD-DSTRYD", "FinalDirectiveDestroyed");
    public static readonly DirectionType InspectionSeedsInspect = new DirectionType( "INSP-SEEDS-INSPECT", "IM-DIRECTION-TPE-INSP-SEEDS-INSPECT", "InspectionSeedsInspect");
    public static readonly DirectionType SecurePendingInsect = new DirectionType( "SECURE-PEND-INSECT-ID", "IM-DIRECTION-TPE-SECURE-PEND-INSECT-ID", "SecurePendingInsect");
    public static readonly DirectionType SecurePendingTest = new DirectionType( "SECURE-PEND-TEST-RESLT", "IM-DIRECTION-TPE-SECURE-PEND-TEST-RESLT", "SecurePendingTest");
    public static readonly DirectionType SecureContactBio = new DirectionType(  "SECURE-CONTCT-BIOSEC", "IM-DIRECTION-TPE-SECURE-CONTCT-BIOSEC", "SecureContactBio");
    public static readonly DirectionType SecureAsDirected = new DirectionType(   "SECURE-AS-DIRECTD", "IM-DIRECTION-TPE-SECURE-AS-DIRECTD", "SecureAsDirected");
    public static readonly DirectionType OtherTreatCold = new DirectionType(   "TRT-OTH-COLD", "IM-DIRECTION-TPE-TRT-OTH-COLD", "OtherTreatCold");
    public static readonly DirectionType OtherTreatAutoclave = new DirectionType(   "TRT-OTH-AUTOCLAVE", "IM-DIRECTION-TPE-TRT-OTH-AUTOCLAVE", "OtherTreatAutoclave");
    public static readonly DirectionType OtherTreatDisinfection = new DirectionType(   "TRT-OTH-DISINFECTION", "IM-DIRECTION-TPE-TRT-OTH-DISINFECTION", "OtherTreatDisinfection");
    public static readonly DirectionType OtherTreatCleaning = new DirectionType(   "TRT-OTH-CLEANING", "IM-DIRECTION-TPE-TRT-OTH-CLEANING", "OtherTreatCleaning");
    public static readonly DirectionType OtherTreatDipping = new DirectionType(   "TRT-OTH-DIPPING", "IM-DIRECTION-TPE-TRT-OTH-DIPPING", "OtherTreatDipping");
    public static readonly DirectionType OtherTreatAsPerComments = new DirectionType(   "TRT-OTH-COMM", "IM-DIRECTION-TPE-TRT-OTH-COMM", "OtherTreatAsPerComments");
    public static readonly DirectionType OtherTreatWithPermitConditions = new DirectionType(   "TRT-OTH-PRMT-COND", "IM-DIRECTION-TPE-TRT-OTH-PRMT-COND", "OtherTreatWithPermitConditions");
    public static readonly DirectionType OtherTreatOnePercentageNaOClSeedTreatment = new DirectionType(   "TRT-OTH-NAOCL-DIP", "IM-DIRECTION-TPE-TRT-OTH-NAOCL-DIP", "OtherTreatOnePercentageNaOClSeedTreatment");
    public static readonly DirectionType ExternalContainerInspectionNoMovement = new DirectionType(   "INSP-EXT-CONTAINER-NO-MVMNT", "IM-DIRECTION-TPE-INSP-EXT-CONTAINER-NO-MVMNT", "ExternalContainerInspectionNoMovement");
    public static readonly DirectionType InternalError = new DirectionType(   "INTERNAL_ERROR", "IM-DIRECTION-TPE-INTERNAL_ERROR", "InternalError");

    private DirectionType(string code, string longCode, string text)
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    private static IEnumerable<DirectionType> DirectionTypes
    {
        get
        {
            yield return AirFreightInspectionCode;
            yield return DestructionAutoClave;
            yield return DestructionDeepBurial;
            yield return DestructionIncineration;
            yield return DestructionNonCommodity;
            yield return DestructionOtherApprovedMethod;
            yield return DestructionPartialCommodity;
            yield return DestructionPrefix;
            yield return DisposalPermissionAaWasteBin;
            yield return DisposalPermissionAAWasteBin;
            yield return DisposalPermissionAutoClave;
            yield return PlacedBackUnderBioSecurityControlCode;
            yield return FinalizedAndReleasedCode;
            yield return WithdrawalCode;
            yield return FinalDirectiveWithdrawn;
            yield return FormalEntryRequiredCode;
            yield return MovementWithheldPendingInfo;
            yield return MovementWithheldPendingInfoInsp;
            yield return MovementWithheldPendingInfoDoco;
            yield return MovementWithheldPrefix;
            yield return MovementAllowedToSpecificLocation;
            yield return MovementAllowedPrefix;
            yield return FinalDirectiveSubjectToPermitConditionsCode;
            yield return FinalDirectivePrefix;
            yield return FinalDirectiveDuplicateEntryCode;
            yield return PresentAllDocumentation;
            yield return ExportUnsupervised;
            yield return ExportSupervisedByBiosecurity;
            yield return ExportPartialCommodity;
            yield return ExportPrefix;
            yield return PartialCommoditySuffix;
            yield return NonCommoditySuffix;
            yield return Heat74CVariable;
            yield return HeatRatePrescribed;
            yield return SecurePrefix;
            yield return InspectionPrefix;
            yield return TreatmentPrefix;
            yield return FumigationPrefix;
            yield return IrradiationPrefix;
            yield return HeatTreatPrefix;
            yield return OtherTreatPrefix;
            yield return FinalDirectiveExported;
            yield return FinalDirectiveDestroyed;
            yield return InspectionSeedsInspect;
            yield return SecurePendingInsect;
            yield return SecurePendingTest;
            yield return SecureContactBio;
            yield return SecureAsDirected;
            yield return OtherTreatCold;
            yield return OtherTreatAutoclave;
            yield return OtherTreatDisinfection;
            yield return OtherTreatCleaning;
            yield return OtherTreatDipping;
            yield return OtherTreatAsPerComments;
            yield return OtherTreatWithPermitConditions;
            yield return OtherTreatOnePercentageNaOClSeedTreatment;
            yield return ExternalContainerInspectionNoMovement;
            yield return InternalError;
        }
    }
    
    private static DirectionType From(string code)
    {
        foreach(DirectionType directionType in DirectionTypes )

        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
        {
            return (directionType);
        }

        throw new UnsupportedDirectionTypeException(code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(DirectionType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator DirectionType(string code)
    {
        return From(code);
    }
}