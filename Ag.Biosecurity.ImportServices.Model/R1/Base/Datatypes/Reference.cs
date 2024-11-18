using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// The Reference type contains at least one of a reference (literal reference), an identifier (logical reference), 
/// and a display (text description of target). In addition, it may contain a target type.
/// </summary>
public class Reference<T>
{
    /// <summary>
    /// TThis property allows you to store an instance of a BaseResource that the reference points to. 
    /// The nullable type (BaseResource?) indicates that this may not always be populated.
    /// </summary>
    public BaseResource? IncludedResource { get; set; }
    /// <summary>
    /// This property holds a URI that defines the type of resource being referenced.
    /// </summary>
    public Uri? ResourceType { get; set; }
    /// <summary>
    /// The DirectReference contains a Literal reference, Relative, internal or absolute URL to the actual resource.
    /// </summary>
    public string? DirectReference { get; set; }
    /// <summary>
    /// The BusinessIdentifier is a logical reference to the resource, when literal reference is not known
    /// </summary>
    public Identifier? BusinessIdentifier { get; set; }
    /// <summary>
    /// The BusinessIdentifier is a logical reference to the resource, when literal reference is not known
    /// </summary>
    public string? Display { get; set; }

    // Default constructor
    public Reference()
    {
        // All properties are initialized to their default values (null for reference types).
        IncludedResource = null;
        ResourceType = null;
        DirectReference = null;
        BusinessIdentifier = null;
        Display = null;
    }

    // Constructor with parameters for all attributes
    public Reference(BaseResource? includedResource, Uri? resourceType, string? directReference, Identifier? businessIdentifier, string? display)
    {
        IncludedResource = includedResource;
        ResourceType = resourceType;
        DirectReference = directReference;
        BusinessIdentifier = businessIdentifier;
        Display = display;
    }

    // Constructor with parameters for all attributes
    public Reference(Uri? resourceType, Identifier? businessIdentifier, string? display)
    {
        IncludedResource = null;
        ResourceType = resourceType;
        DirectReference = null;
        BusinessIdentifier = businessIdentifier;
        Display = display;
    }

    public Reference(BaseResource includedResource)
    {
        IncludedResource = includedResource;
        ResourceType = new Uri(includedResource.ResourceType);
        BusinessIdentifier = includedResource.Identifiers.FirstOrDefault();
        Display = BusinessIdentifier.DisplayText;
    }
}