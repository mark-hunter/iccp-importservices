namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

/// <summary>
/// The Coding datatype is a representation of a defined concept using a symbol from a defined "code system".
/// </summary>
public class Coding
{
    /// <summary>
    /// The Name attribute captures a use-friendly single (camel-case) word describing the code.
    /// </summary>
    public string? Name { get; set; }
    /// <summary> 
    /// The Code attribute captures the "Symbol" in syntax defined by the system
    /// </summary>
    public string? Code { get; set; }
    /// <summary>
    /// The CodeSystem attribute identifies the system of the terminology
    /// </summary>
    public string? CodeSystem { get; set; }
    /// <summary>
    /// The CodeVersion attribute details the version of the system - if relevant
    /// </summary>
    public string? CodeVersion { get; set; }
    /// <summary>
    /// The Text attributes encapsulates a representation defined by the system
    /// </summary>
    /// 
    public string? Text { get; set; }
    /// <summary>
    /// The LongCode attributes encapsulates a representation defined by the system
    /// </summary>
    /// 
    public string? LongCode { get; set; }
    /// <summary>
    /// The LegacyGuid attributes encapsulates a reference value for the type instance as managed/stored within the
    /// BIIS framework.
    /// </summary>
    /// 
    public string? LegacyGuid { get; set; }
    

    public Coding()
    {

    }
    
    public Coding(string code, string longCode, string codeSystem, string codeVersion, string displayText)
    {
        Code = code;
        LongCode = longCode;
        LongCode = longCode;
        CodeSystem = codeSystem;
        CodeVersion = codeVersion; 
        Text = displayText; 
    }
    
    public Coding(string code, string longCode, string codeSystem, string codeVersion, string displayText, string legacyGuid)
    {
        Code = code;
        LongCode = longCode;
        CodeSystem = codeSystem;
        CodeVersion = codeVersion; 
        Text = displayText; 
        LegacyGuid = legacyGuid;
    }
    
    public Coding(string name, string code, string longCode, string codeSystem, string codeVersion, string displayText, string legacyGuid)
    {
        Name = name;
        Code = code;
        LongCode = longCode;
        CodeSystem = codeSystem;
        CodeVersion = codeVersion; 
        Text = displayText; 
        LegacyGuid = legacyGuid;
    }

    public override string ToString()
    {
        string toStringValue = "Coding[" + 
                 "Name=" + Name + ", " +
                 "Code="+ Code + "," +
                 "LongCode=" + LongCode + "," +
                 "CodeSystem =" + CodeSystem + "," +
                 "CodeVersion=" + CodeVersion + "," +
                 "Text="+ Text +"]";
        return toStringValue;
    }
}