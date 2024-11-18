namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedEntityRelationshipTypeException : Exception
{
    public UnsupportedEntityRelationshipTypeException(string code)
        : base($"EntityRelationshipType \"{code}\" is unsupported.")
    {
    }
}