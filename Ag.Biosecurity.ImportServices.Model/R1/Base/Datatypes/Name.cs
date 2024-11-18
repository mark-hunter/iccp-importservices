namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

public class Name : DataTypeMetadata
{
    public string? DisplayName { get; set; }
    public string? ShortName { get; set; }
    public string? LongName { get; set; }
    public CodeableConcept? NameUse { get; set; }
    public CodeableConcept? NameType { get; set; }
    public EffectiveDateTime? effectiveDate { get; set; }
}