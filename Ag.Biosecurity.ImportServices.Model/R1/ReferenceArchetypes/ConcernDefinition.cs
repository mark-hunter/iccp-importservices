using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

public class ConcernDefinition : RiskDefinition
{
    public ConcernType? ConcernDefinitionType { get; set; }


    public ConcernDefinition() : base()
    {
        ResourceType = GetType().Name;
    }
}