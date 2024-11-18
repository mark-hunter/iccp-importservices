namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

public class UnsupportedDirectionTypeException : Exception
{
    public UnsupportedDirectionTypeException(string code)
        : base($"DirectionType \"{code}\" is unsupported.")
    {
    }
}