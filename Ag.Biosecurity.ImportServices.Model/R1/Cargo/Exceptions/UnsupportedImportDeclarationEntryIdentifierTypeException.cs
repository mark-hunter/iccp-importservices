namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

public class UnsupportedImportDeclarationEntryIdentifierTypeException : Exception
{
    public UnsupportedImportDeclarationEntryIdentifierTypeException(string code)
        : base($"Import Declaration Entry Identifier Type \"{code}\" is unsupported.")
    {
    }
}