namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedCountryCodeException : Exception
{
    public UnsupportedCountryCodeException(string code)
        : base($"CountryCode \"{code}\" is unsupported.")
    {
    }
}