namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

public class HumanName : Name
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }
    public string? Prefix { get; set; }
}