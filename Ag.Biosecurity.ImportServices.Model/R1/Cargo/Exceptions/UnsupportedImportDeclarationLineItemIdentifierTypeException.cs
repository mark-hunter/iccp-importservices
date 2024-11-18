namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

public class UnsupportedImportDeclarationLineItemIdentifierTypeException : Exception
{
    public UnsupportedImportDeclarationLineItemIdentifierTypeException(string code)
        : base($"Import Declaration Entry Identifier Type \"{code}\" is unsupported.")
    {
    }
}