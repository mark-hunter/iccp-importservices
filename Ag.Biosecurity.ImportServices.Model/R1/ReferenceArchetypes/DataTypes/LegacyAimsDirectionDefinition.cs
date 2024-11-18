using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Datatypes;

public class LegacyAimsDirectionDefinition : DataTypeMetadata
{
    public string DirectionCategory { get; set; } = "";
    public string DirectionDescription { get; set; } = "";
}