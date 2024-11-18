namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

public class ClientRole
{
    public ClientRole()
    {
        permissions = new List<Permission>();
    }

    public List<Permission> permissions { get; set; }
}