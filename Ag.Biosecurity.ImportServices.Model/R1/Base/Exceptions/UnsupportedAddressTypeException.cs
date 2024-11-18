namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedAddressTypeException : Exception
{
    public UnsupportedAddressTypeException(string code)
        : base($"AddressType \"{code}\" is unsupported.")
    {
    }
}