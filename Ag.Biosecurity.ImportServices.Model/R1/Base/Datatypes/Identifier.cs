namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// An Identifier is a business or application identifier for a resource. It is used to capture so-called keys
/// associated with a resource and allows for multiplicity (i.e. a resource may have multiple identifiers, each
/// with a different type) and temporal aspects (i.e. each Identifier instance may have an effective period defined.
/// </summary>
public class Identifier : DataTypeMetadata
{
    public const string DefaultIdentifierCodingSystem = "https://aff.gov.au/imports/iccp/codesets/default-identifier-type";
    public const string DefaultIdentifierCodingSystemVersion = "R1";
    public const string DefaultIdentifierCodingCode = "ICCP_Resource_Identifier";
    public const string DefaultIdentifierCodingDisplayName = "ICCP Resource Identifier";
    
    
    /// <summary>
    /// The IdentifierType is a CodeableConcept that allows for a well-defined definition of what the Identifier
    /// actually relates to or how it is defined. 
    /// </summary>
    public CodeableConcept? IdentifierType { get; set; }
    /// <summary>
    /// The Id is the actual identifier value which should uniquely identify a resource instance.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The DisplayText attribute contains a human-readable version of the Id.
    /// </summary>
    public string? DisplayText { get; set; }
    /// <summary>
    /// The EffectivePeriod attribute captures the period (in time) during which the Identifier can be considered
    /// "current" or "active". If no EffectivePeriod is defined/assigned, the Identifier is assumed to be always
    /// "current".
    /// </summary>
    public EffectiveDateTime? EffectivePeriod { get; set; }

    public Identifier() : base()
    {
        IdentifierType = DefaultIdentifierType();
    }

    public Identifier(CodeableConcept codeableConcept, string id, string displayText)
    {
        IdentifierType = codeableConcept;
        Id = id;
        DisplayText = displayText;
    }
    
    

    /// <summary>
    /// Determines if the Identifier is still current (active) and may be used. It does this by checking the
    /// EffectivePeriod attribute and ascertaining if the current time/date fits within the time-frame captured
    /// by the EffectivePeriod.StartDate and EffectivePeriod.EndDate values.
    /// Absence of the EffectivePeriod attribute implies that the Identifier is always current (active).
    /// </summary>
    /// <returns>
    /// A boolean identifying if the Identifier is current (true) or is no long value (false).
    /// </returns>
    public bool IsCurrent()
    {
        if (EffectivePeriod == null)
        {
            return true;
        }

        if (EffectivePeriod.StartDate != null && EffectivePeriod.StartDate > DateTime.Now)
        {
            return false;
        }

        if (EffectivePeriod.EndDate != null && EffectivePeriod.EndDate < DateTime.Now)
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// Determines if this Identifier includes a Coding system of codeSystem.
    /// </summary>
    /// <param name="codeSystem">
    /// A code system for the IdentifierType.
    /// </param>
    /// <returns>
    /// Returns (true) if the codeSystem is one of the Codings within the IdentifierType, (false) otherwise.
    /// </returns>
    public bool ContainsCodeSystem(string codeSystem)
    {
        if (string.IsNullOrEmpty(codeSystem))
        {
            return false;
        }

        if (IdentifierType == null)
        {
            return false;
        }

        foreach (Coding coding in IdentifierType.Codings)
        {
            if (string.Equals(coding.CodeSystem, codeSystem, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Determines if an Identifier includes a Coding System of codeSystem and Coding Code of code. 
    /// </summary>
    /// <param name="codeSystem">
    /// A code system for the IdentifierType.
    /// </param>
    /// <param name="code">
    /// A code for the IdentifierType.
    /// </param>
    /// <returns>
    /// Returns (true) if the codeSystem and Code are in one of the Codings within the IdentifierType, (false) otherwise.
    /// </returns>
    public bool ContainsCodeSystemAndCode(string codeSystem, string code)
    {
        if (string.IsNullOrEmpty(codeSystem) || string.IsNullOrEmpty(code))
        {
            return false;
        }

        if (IdentifierType == null)
        {
            return false;
        }

        foreach (Coding coding in IdentifierType.Codings)
        {
            if (string.Equals(coding.CodeSystem, codeSystem, StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(coding.Code, code, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Determine if the Identifier contains the code (as part of a IdentifierType) irrespective of
    /// what code system may be used.
    /// </summary>
    /// <param name="code">
    /// A code for the IdentifierType.
    /// </param>
    /// <returns>
    /// Returns (true) if the Code is in one of the Codings within the IdentifierType, (false) otherwise.
    /// </returns>
    public bool ContainsCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return false;
        }

        if (IdentifierType == null)
        {
            return false;
        }

        foreach (Coding coding in IdentifierType.Codings)
        {
            if (string.Equals(coding.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return (false);
    }


    public static CodeableConcept DefaultIdentifierType()
    {
        Coding coding = new Coding();
        coding.CodeSystem = DefaultIdentifierCodingSystem;
        coding.CodeVersion = DefaultIdentifierCodingSystemVersion;
        coding.Code = DefaultIdentifierCodingCode;
        coding.Text = DefaultIdentifierCodingDisplayName;
        coding.Name = DefaultIdentifierCodingCode;
        CodeableConcept codeableConcept = new CodeableConcept();
        codeableConcept.Codings = new List<Coding>();
        codeableConcept.Codings.Add(coding);
        codeableConcept.DisplayText = "ICCP Default Identifier Type";
        return(codeableConcept);
    }
}