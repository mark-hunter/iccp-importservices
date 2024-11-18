using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

public class GoodsManifest : BaseResource
{
    public List<Reference<ImportedItem>> Items { get; set; } = new List<Reference<ImportedItem>>(); // ImportedItem
    
    public GoodsManifest() : base()
    {
        ResourceType = "GoodsManifest";
    }
}