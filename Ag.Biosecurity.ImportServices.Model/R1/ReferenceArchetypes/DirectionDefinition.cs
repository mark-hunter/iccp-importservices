using Ag.Biosecurity.ImportServices.Model.R1.Artifacts;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

public class DirectionDefinition : BaseResource
{
    public Reference<GeneratedDocument>? DirectionTypeDocumentTemplate { get; set; }
    public DirectionType? DirectionCode { get; set; }
    public DirectionCategoryType? DirectionCategoryCode { get; set; } 

    public LegacyAimsDirectionDefinition AimsDirectionDefinition{ get; set; }

    public DirectionDefinition() : base()
    {
        ResourceType = GetType().Name;
        AimsDirectionDefinition = new LegacyAimsDirectionDefinition();
    }
}