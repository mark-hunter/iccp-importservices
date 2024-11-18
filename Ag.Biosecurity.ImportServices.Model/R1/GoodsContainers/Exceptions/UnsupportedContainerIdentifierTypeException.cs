namespace Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers.Exceptions;

public class UnsupportedContainerIdentifierTypeException : Exception
{
    public UnsupportedContainerIdentifierTypeException(string code)
        : base($"Container Identifier Type \"{code}\" is unsupported.")
    {
    }
}