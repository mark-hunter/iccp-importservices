namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedGeneratedDocumentTypeException : Exception
{
    public UnsupportedGeneratedDocumentTypeException(string code)
        : base($"Generated Document Type \"{code}\" is unsupported.")
    {
    }
}