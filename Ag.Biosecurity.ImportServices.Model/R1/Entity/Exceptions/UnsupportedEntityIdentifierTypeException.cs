namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedEntityIdentifierTypeException : Exception
{
    public UnsupportedEntityIdentifierTypeException(string code)
        : base($"Entity Identifier Type \"{code}\" is unsupported.")
    {
    }
}