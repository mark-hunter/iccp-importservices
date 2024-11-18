namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedDirectionLevelTypeException : Exception
{
    public UnsupportedDirectionLevelTypeException(string code)
        : base($"Direction Level Type \"{code}\" is unsupported.")
    {
    }
}