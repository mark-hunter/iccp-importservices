using Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// An Address is used to express address information using postal conventions (as opposed to GPS or other location 
/// definition formats). This datatype may be used to convey addresses for use in delivering mail as well as for 
/// visiting locations which might not be valid for mail delivery. There are a variety of postal address formats 
/// defined around the world.
/// </summary>
public class Address : DataTypeMetadata
{
    /// <summary>
    /// The AddressLines attributes captures the Street name, number, direction and P.O. Box etc.
    /// This repeating element order: The order in which lines should appear in an address label
    /// </summary>
    public Dictionary<int, string> AddressLines { get; set; }
    /// <summary>
    /// The AddressType attribute captures the type of the address (e.g. postal | physical | both)
    /// <example>
    /// Examples include [postal | physical | both]
    /// </summary>
    public AddressType? AddressType { get; set; }
    /// <summary>
    /// The AddressUse attribute captures the use/rule of the address.
    /// </summary>
    /// <example>
    /// Examples include [home | work | temp | old | billing]
    /// <code>
    /// AddressUse = AddressUseFactory.createCodeableConcept(AddressUseEnum.Home);
    /// </code>
    /// </example>
    public AddressUseType? AddressUse { get; set; }
    /// <summary>
    /// The CountryCode attribute captures the country of the address.
    /// Examples of use may include ISO 3166 2 or 3 letter code.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The DisplayText encapsulates a Text representation of the address
    /// </summary>
    public string? DisplayText { get; set; }
    /// <summary> 
    /// The District attribute encapsulates the District name (aka county)
    /// </summary>
    public string? District { get; set; }
    /// <summary> 
    /// The PostalCode attribute encapsulates the postal code
    /// </summary>
    public string? PostalCode { get; set; }
    /// <summary> 
    /// The State attribute encapsulates the sub-unit of a country (abbreviations ok)
    /// </summary>
    public string? State { get; set; }
    /// <summary> 
    /// The Town attribute encapsulates the city or town.
    /// </summary>
    public string? Town { get; set; }
    /// <summary> 
    /// The EffectivePeriod is used in conjunction with the AddressUse attribute to detail the effective
    /// dates that the address may be used (or may be defined as "correct")
    /// </summary>
    public EffectiveDateTime? EffectivePeriod { get; set; }

    public Address() : base()
    {
        AddressLines = new Dictionary<int, string>();
    }
}