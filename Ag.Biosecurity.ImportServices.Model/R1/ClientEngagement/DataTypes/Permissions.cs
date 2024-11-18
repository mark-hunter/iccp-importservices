namespace Ag.Biosecurity.ImportServices.Model.R1.ClientEngagement.DataTypes;

public class Permissions
{
    public Permissions()
    {
        DerivedPermissions = new List<DerivedPermission>();
        ExplicitPermissions = new List<ExplicitPermission>();
    }

    public List<DerivedPermission> DerivedPermissions { get; set; }
    public List<ExplicitPermission> ExplicitPermissions { get; set; }
}