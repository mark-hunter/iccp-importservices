using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Conveyance;
using Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers;

public class GoodsContainer : BaseResource
{
    public Reference<Journey>? ContainerJourney { get; set; }

    public GoodsContainer() : base()
    {
        ResourceType = "GoodsContainer";
    }


    //
    // Helper Methods
    // 

    [JsonIgnore]
    public Identifier? AimsIdentifier
    {
        set
        {
            Identifier qeiIdentifier = new Identifier(ContainerIdentifierType.AimsContainerId.AsCodeableConcept, value.Id, value.DisplayText);
            AddIdentifier(qeiIdentifier);
        }
        get => GetIdentifierWithCode(ContainerIdentifierType.AimsContainerId);
    }
}