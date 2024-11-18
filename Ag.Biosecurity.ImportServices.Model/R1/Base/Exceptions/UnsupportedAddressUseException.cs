namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedAddressUseException : Exception
{
    public UnsupportedAddressUseException(string code)
        : base($"AddressUse \"{code}\" is unsupported.")
    {
    }
}