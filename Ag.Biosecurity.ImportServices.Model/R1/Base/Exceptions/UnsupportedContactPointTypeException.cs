namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedContactPointTypeException : Exception
{
    public UnsupportedContactPointTypeException(string code)
        : base($"Contact Point Code \"{code}\" is unsupported.")
    {
    }
}