namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// A CodeableConcept datatype represents a value that is usually supplied by providing a reference to one or 
/// more terminologies or ontologies but may also be defined by the provision of text. This is a common pattern 
/// in data management within the science, health and telecommunications domains.
/// </summary>
public class CodeableConcept : DataTypeMetadata
{
    /// <summary>
    /// The Codings attribute capture the Code(s) defined by a terminology system
    /// </summary>
    public List<Coding> Codings { get; set; }
    /// <summary>
    /// The Value attribute is a free text representation of a attribute value
    /// </summary>
    public string? Value { get; set; }
    /// <summary>
    /// The DisplayText attribute is a free text description of a attribute value
    /// </summary>
    public string? DisplayText { get; set; }
    
    public CodeableConcept()
    {
        Codings = new List<Coding>();
    }

    public CodeableConcept(string code, string codeSystem, string codeVersion, string codeDisplayText, string value, string displayText )
    {
        Codings = new List<Coding>();
        Coding coding = new Coding(code, code, codeSystem, codeVersion, codeDisplayText);
        Codings.Add(coding);
        Value = value;
        DisplayText = displayText;
    }
    
    public CodeableConcept(string code, string longCode, string codeSystem, string codeVersion, string codeDisplayText, string value, string displayText )
    {
        Codings = new List<Coding>();
        Coding coding = new Coding(code, longCode, codeSystem, codeVersion, codeDisplayText);
        Codings.Add(coding);
        Value = value;
        DisplayText = displayText;
    }
}