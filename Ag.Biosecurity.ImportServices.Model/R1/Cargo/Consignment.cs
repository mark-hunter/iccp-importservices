using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

public class Consignment : BaseResource
{
    public List<Reference<GoodsManifest>> Manifests { get; set; } = new List<Reference<GoodsManifest>>(); // GoodsManifest
    public List<Reference<GoodsContainer>> Containers { get; set; } = new List<Reference<GoodsContainer>>(); // GoodsContainer
    
    public Consignment() : base()
    {
        ResourceType = GetType().Name;
    }
}