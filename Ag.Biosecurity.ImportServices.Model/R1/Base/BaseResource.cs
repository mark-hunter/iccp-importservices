using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base;

/// <summary>
/// The BaseResource encapsulates a core set of attributes and functions common to all Resources of the
/// Import Services Model / API. It also acts as the primary Reference endpoint where the target may be, in fact,
/// be an instance of one of many resource types (e.g. a Reference may point to an Organisation or Person).
/// </summary>
public class BaseResource
{
    /// <summary>
    /// The ResourceId is a (localised) identifier for the resource, having context only within the scope of
    /// the application within which the resource is instantiated. In most cases, and for most business functions, the Identifier
    /// within the Identifiers attribute should be used to refer to a resource rather than the Id. 
    /// </summary>
    public string ResourceId { get; set; }
    /// <summary>
    /// The ResourceType details the Resource Type name.
    /// </summary>
    /// <summary>
    /// The ResourceType details the Resource Type name.
    /// </summary>
    public string ResourceType { get; set; }
    /// <summary>
    /// The Identifiers list provides a business identifiers, qualified by a code-system for each identifier,
    /// that is (temporally) unique within the context of the resource.
    /// </summary>
    /// <summary>
    /// The Identifiers list provides a business identifiers, qualified by a code-system for each identifier,
    /// that is (temporally) unique within the context of the resource.
    /// </summary>
    public List<Identifier> Identifiers { get; set; } 
    /// <summary>
    /// The DefaultIdentifierCodeSystem captures the default code-system for identifiers used within the resource,
    /// streamlining the access and extraction of individual identifiers.
    /// </summary>
    public string? DefaultIdentifierCodeSystem { get; set; }
    /// <summary>
    /// The Meta attribute captures the core metadata associated with the resource data - including security and
    /// creation/update timestamps etc.
    /// </summary>
    public ResourceMetadata Meta { get; set; }
    
    public BaseResource()
    {
        ResourceId = Guid.NewGuid().ToString();
        ResourceType = GetType().Name;
        Identifiers = new List<Identifier>();
        Meta = new ResourceMetadata();
    }

    /// <summary>
    /// Checks to see if there is a (current) Identifier within the Identifiers list with the given code.
    /// </summary>
    /// <param name="code">
    /// The code value to check against each Identifier.IdentifierType.Codings[] instances to see if an Identifier
    /// includes an IdentifierType of that code value.
    /// </param>
    /// <returns>
    /// Returns (true) if the Resource contains an Identifier (that is current, i.e. within the EffectivePeriod defined
    /// for the IdentifierType) with the given IdentifierType.Codings[].Code value.
    /// </returns>
    public bool HasIdentifierWithCode(string code)
    {
        Identifier identifier = GetIdentifierWithCode(code);
        if (identifier == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// Checks to see if there is a (current) Identifier within the Identifiers list with the given code and, if one
    /// exists, returns that Identifier.
    /// </summary>
    /// <param name="code">
    /// The code value to check against each Identifier.IdentifierType.Codings[] instances to see if an Identifier
    /// includes an IdentifierType of that code value.
    /// </param>
    /// <returns>
    /// Returns the Identifier where the Resource's Identifiers contains the given code value within the
    /// Identifier.IdentityType.Coding[].Code and is current (i.e. within the EffectivePeriod defined for the
    /// IdentifierType)
    /// </returns>
    public Identifier GetIdentifierWithCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return null;
        }

        if (string.IsNullOrEmpty(DefaultIdentifierCodeSystem))
        {
            foreach(Identifier currentIdentifier in Identifiers)
            {
                if (currentIdentifier.ContainsCode(code))
                {
                    if (currentIdentifier.IsCurrent())
                    {
                        return currentIdentifier;
                    }
                }
            }
        }
        else
        {
            foreach (Identifier currentIdentifier in Identifiers)
            {
                if (currentIdentifier.ContainsCodeSystemAndCode(DefaultIdentifierCodeSystem, code))
                {
                    if (currentIdentifier.IsCurrent())
                    {
                        return currentIdentifier;
                    }
                }
            }
        }

        return null;
    }
    
    /// <summary>
    /// Checks to see if there is a (current) Identifier within the Identifiers list with the given code and, if one
    /// exists, invalidates it.
    /// </summary>
    /// <param name="code">
    /// The code value to check against each Identifier.IdentifierType.Codings[] instances to see if an Identifier
    /// includes an IdentifierType of that code value.
    /// </param>
    /// <returns>
    ///
    /// </returns>
    public void InvalidateIdentifierWithCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return;
        }

        if (string.IsNullOrEmpty(DefaultIdentifierCodeSystem))
        {
            foreach(Identifier currentIdentifier in Identifiers)
            {
                if (currentIdentifier.ContainsCode(code))
                {
                    if (currentIdentifier.IsCurrent())
                    {
                        currentIdentifier.EffectivePeriod.EndDate = DateTime.Now;
                    }
                }
            }
        }
        else
        {
            foreach (Identifier currentIdentifier in Identifiers)
            {
                if (currentIdentifier.ContainsCodeSystemAndCode(DefaultIdentifierCodeSystem, code))
                {
                    if (currentIdentifier.IsCurrent())
                    {
                        currentIdentifier.EffectivePeriod.EndDate = DateTime.Now;
                    }
                }
            }
        }
    }
    
    /// <summary>
    /// Checks to see if there is a (current) Identifier within the Identifiers list with the given code and, if one
    /// exists, invalidates it.
    /// </summary>
    /// <param name="code">
    /// The code value to check against each Identifier.IdentifierType.Codings[] instances to see if an Identifier
    /// includes an IdentifierType of that code value.
    /// </param>
    /// <returns>
    ///
    /// </returns>
    public void AddIdentifier(Identifier newIdentifier)
    {
        if (newIdentifier == null)
        {
            return;
        }

        if (newIdentifier.IdentifierType == null)
        {
            return;
        }

        if (newIdentifier.IdentifierType.Codings.Count < 1)
        {
            return;
        }

        foreach (Coding coding in newIdentifier.IdentifierType.Codings)
        {
            foreach (Identifier currentIdentifier in Identifiers)
            {
                if (currentIdentifier.ContainsCodeSystemAndCode(coding.CodeSystem, coding.Code))
                {
                    if (currentIdentifier.IsCurrent())
                    {
                        currentIdentifier.EffectivePeriod.EndDate = DateTime.Now;
                    }
                }
            }
        }
        
        Identifiers.Add(newIdentifier);
    }
    
}