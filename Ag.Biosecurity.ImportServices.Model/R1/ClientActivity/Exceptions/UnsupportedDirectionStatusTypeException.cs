namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedDirectionStatusTypeException : Exception
{
    public UnsupportedDirectionStatusTypeException(string code)
        : base($"Direction Status Type \"{code}\" is unsupported.")
    {
    }
}