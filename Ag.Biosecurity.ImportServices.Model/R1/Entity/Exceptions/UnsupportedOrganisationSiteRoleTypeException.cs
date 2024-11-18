namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedOrganisationSiteRoleTypeException : Exception
{
    public UnsupportedOrganisationSiteRoleTypeException(string code)
        : base($"OrganisationSiteRoleType \"{code}\" is unsupported.")
    {
    }
}