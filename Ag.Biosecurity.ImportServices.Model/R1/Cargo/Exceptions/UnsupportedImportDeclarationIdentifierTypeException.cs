namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

public class UnsupportedImportDeclarationIdentifierTypeException : Exception
{
    public UnsupportedImportDeclarationIdentifierTypeException(string code)
        : base($"Import Declaration Identifier Type \"{code}\" is unsupported.")
    {
    }
}