using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;

public class ClientActivityBaseResource : BaseResource
{
    public Reference<EntityRole>? Owner { get; set; }
    public Reference<ImportCaseActivity>? RelatedDepartmentOperation { get; set; }

    public ClientActivityBaseResource() : base()
    {
        ResourceType = GetType().Name;
    }
}