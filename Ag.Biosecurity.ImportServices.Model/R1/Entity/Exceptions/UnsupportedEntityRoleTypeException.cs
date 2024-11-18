namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedEntityRoleTypeException : Exception
{
    public UnsupportedEntityRoleTypeException(string code)
        : base($"EntityRoleType \"{code}\" is unsupported.")
    {
    }
}