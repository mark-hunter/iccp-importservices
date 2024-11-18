namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedEntityTypeException : Exception
{
    public UnsupportedEntityTypeException(string code)
        : base($"EntityType \"{code}\" is unsupported.")
    {
    }
}