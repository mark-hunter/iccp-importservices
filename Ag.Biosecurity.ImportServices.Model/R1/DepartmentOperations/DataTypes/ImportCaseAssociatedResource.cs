using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.DataTypes;

public class ImportCaseAssociatedResource : DataTypeMetadata
{
    public ImportCaseAssociatedResourceRoleType AssociatedResourceRole { get; set; }
    public Reference<BaseResource> ResourceReference { get; set; }

    public ImportCaseAssociatedResource() : base()
    {
        ResourceReference = new Reference<BaseResource>();
        AssociatedResourceRole = ImportCaseAssociatedResourceRoleType.CaseFocusResource;
    }

    public ImportCaseAssociatedResource(ImportCaseAssociatedResourceRoleType associatedResourceRole,
        Reference<BaseResource> resourceReference)
    {
        AssociatedResourceRole = associatedResourceRole;
        ResourceReference = resourceReference;
    }
}