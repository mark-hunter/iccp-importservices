using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo;

public class ImportedItem : BaseResource
{
    public ItemDefinition? ItemDefinition { get; set; } // Definitional::ItemType
    public String? Description { get; set; }
    public String? Quantity { get; set; }
    public String? UnitOfMeasure { get; set; }
    public String? ItemQualification { get; set; }

    public ImportedItem() : base()
    {
        ResourceType = GetType().Name;
    }
}