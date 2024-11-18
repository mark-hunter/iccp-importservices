namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseIdentifierTypeException : Exception
{
    public UnsupportedImportCaseIdentifierTypeException(string code)
        : base($"Import Case Identifier Type \"{code}\" is unsupported.")
    {
    }
}