using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;


public class IdentityAssuranceType  : ValueDataType
{
       private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/data-classification-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly IdentityAssuranceType UnconfirmedNoEvidence = new IdentityAssuranceType( "UnconfirmedNoEvidence", "UNCONFIRMED_NO_EVIDENCE", "IdentityAssuranceType.Unconfirmed.NoEvidence", CodeSystemId, CodeSystemVersion, "Identity Assurance was not Established", ""  );
    public static readonly IdentityAssuranceType UnconfirmedSelfRegistration = new IdentityAssuranceType( "UnconfirmedSelfRegistration", "UNCONFIRMED_SELF_REGISTRATION", "IdentityAssuranceType.Unconfirmed.SelfRegistration", CodeSystemId, CodeSystemVersion, "Identity Assurance was not Established - Self Registration not Validated", ""  );
    public static readonly IdentityAssuranceType UnconfirmedDerivedFromDeclarations = new IdentityAssuranceType( "UnconfirmedDerivedFromDeclaration", "UNCONFIRMED_DERIVED_FROM_DECLARATIONS", "IdentityAssuranceType.Unconfirmed.DerivedFromDeclaration", CodeSystemId, CodeSystemVersion, "Identity Assurance was not Established - Identity Derived from Submitted Declarations Only", ""  );
    public static readonly IdentityAssuranceType ApprovedArrangement = new IdentityAssuranceType( "ApprovedArrangement", "APPROVED_ARRANGEMENT", "IdentityAssuranceType.DepartmentalProcess.ApprovedArrangement", CodeSystemId, CodeSystemVersion, "Identity Assurance was Established via the Approved Arrangement Review and Approval Process", ""  );
    public static readonly IdentityAssuranceType FitAndProperPerson = new IdentityAssuranceType( "FitAndProperPerson","FIT_AND_PROPER_PERSON",  "IdentityAssuranceType.DepartmentalProcess.FitAndProperPerson", CodeSystemId, CodeSystemVersion, "Identity Assurance was Established via the Fit and Proper Person Review and Approval Process", ""  );
    public static readonly IdentityAssuranceType OffshoreTreatmentProvider = new IdentityAssuranceType( "OffshoreTreatmentProvider","OFFSHORE_TREATMENT_PROVIDER",  "IdentityAssuranceType.DepartmentalProcess.OffshoreTreatmentProvider", CodeSystemId, CodeSystemVersion, "Identity Assurance was Established via the Offshore Treatment Provider Review and Approval Process", ""  );
    public static readonly IdentityAssuranceType RelationshipAuthorisationManager = new IdentityAssuranceType( "RelationshipAuthorisationManager","ATO_RAM",  "IdentityAssuranceType.AustralianTaxationOffice.RelationshipAuthorisationManager", CodeSystemId, CodeSystemVersion, "Identity Assurance was Established via the Relationship Authorisation Manager Service", ""  );
    public static readonly IdentityAssuranceType ClientDelegationAndAuthorisation = new IdentityAssuranceType( "ClientDelegationAndAuthorisation" ,"CLIENT_DELEGATION_AND_AUTHORISATION",  "IdentityAssuranceType.BusinessProcess.ClientDelegationAndAuthorisation", CodeSystemId, CodeSystemVersion, "Identity Assurance was Established via the Delegation, Vouching and Authorisation Business Process", ""  );
    
    private IdentityAssuranceType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid )
    {
        Code = code;
        LongCode = longCode;
        Text = text;
        CodeSystem = codeSystem;
        CodeVersion = codeSystemVersion;
    }
        
    private static IEnumerable<IdentityAssuranceType> IdentityAssuranceTypes
    {
        get
        {
            yield return UnconfirmedNoEvidence;
            yield return UnconfirmedSelfRegistration;
            yield return UnconfirmedDerivedFromDeclarations;
            yield return ApprovedArrangement;
            yield return FitAndProperPerson;
            yield return OffshoreTreatmentProvider;
            yield return RelationshipAuthorisationManager;
            yield return ClientDelegationAndAuthorisation;
        }
    }

    private static IdentityAssuranceType FromCode(string code)
    {
        foreach(IdentityAssuranceType directionType in IdentityAssuranceTypes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedIdentityAssuranceTypeException(code);
    }

    private static IdentityAssuranceType FromGuid(string guid)
    {
        foreach(IdentityAssuranceType directionType in IdentityAssuranceTypes )

            if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedIdentityAssuranceTypeException(guid);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(IdentityAssuranceType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator IdentityAssuranceType(string code)
    {
        return FromCode(code);
    } 
}