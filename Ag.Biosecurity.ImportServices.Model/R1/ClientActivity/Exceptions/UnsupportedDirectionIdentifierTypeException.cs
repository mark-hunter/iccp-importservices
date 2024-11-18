namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedDirectionIdentifierTypeException : Exception
{
    public UnsupportedDirectionIdentifierTypeException(string code)
        : base($"Direction Identifier Type \"{code}\" is unsupported.")
    {
    }
}