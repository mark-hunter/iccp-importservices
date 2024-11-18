using Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

public class ContactPoint : DataTypeMetadata
{
    public ContactPointType? ContactPointType { get; set; }
    public ContactPointUseType? ContactPointUse { get; set; }
    public int? ContactPointPriority { get; set; }
    public EffectiveDateTime? EffectivePeriod { get; set; }
    public string Value { get; set; }
    
    public ContactPoint() : base()
    {
        Value = string.Empty;
        ContactPointType = ContactPointType.Other;
        ContactPointUse = ContactPointUseType.Temp;
    }
}