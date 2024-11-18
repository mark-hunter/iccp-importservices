using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

/// <summary>
/// 
/// </summary>
public class Application : ClientActivityBaseResource
{


    public Application() : base()
    {
        ResourceType = GetType().Name;
    }
}