using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

public class ItemDefinition : BaseResource
{
    public Dictionary<string, string> ItemDescription { get; set; }
    public bool IsBiota{ get; set; }
    public Reference<Species>? ItemSpecies{ get; set; }
    public string? Text { get; set; }

    public ItemDefinition() : base()
    {
        ItemDescription = new Dictionary<string, string>();
    }
}