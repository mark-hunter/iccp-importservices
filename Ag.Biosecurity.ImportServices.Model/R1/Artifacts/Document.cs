using System.Security.AccessControl;
using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Artifacts;

/// <summary>
/// The Document resource encompasses any serialized object with a mime-type, it includes formal 
/// scanned paper, reports, policy text, as well as a photo, video, or audio recording acquired or used in the business
/// processes. 
/// The Document resource provides metadata about the document so that the document can be 
/// discovered and managed. The actual content may be inline base64 encoded data or provided by direct 
/// reference.
/// </summary>
public class Document : BaseResource
{
    public Attachment? Content{ get; set; }

    public Document() : base()
    {
        ResourceType = GetType().Name;
    }
}