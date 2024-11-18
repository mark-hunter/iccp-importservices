using Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Artifacts;

public class GeneratedDocument : Document
{
    public GeneratedDocumentType? Type { get; set; }

    public GeneratedDocument() : base()
    {
        ResourceType = GetType().Name;
    }
}