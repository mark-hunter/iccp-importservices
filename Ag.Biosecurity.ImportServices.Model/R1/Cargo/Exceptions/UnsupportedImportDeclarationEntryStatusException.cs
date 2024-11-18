namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

public class UnsupportedImportDeclarationEntryStatusException : Exception
{
    public UnsupportedImportDeclarationEntryStatusException(string code)
        : base($"Import Declaration Entry Status \"{code}\" is unsupported.")
    {
    }
}