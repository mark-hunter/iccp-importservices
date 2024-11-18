namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedContactPointUseTypeException : Exception
{
    public UnsupportedContactPointUseTypeException(string code)
        : base($"Contact Point Use Code \"{code}\" is unsupported.")
    {
    }
}