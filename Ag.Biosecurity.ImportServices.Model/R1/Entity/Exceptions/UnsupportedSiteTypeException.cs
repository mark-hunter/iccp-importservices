namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedSiteTypeException : Exception
{
    public UnsupportedSiteTypeException(string code)
        : base($"SiteType \"{code}\" is unsupported.")
    {
    }
}