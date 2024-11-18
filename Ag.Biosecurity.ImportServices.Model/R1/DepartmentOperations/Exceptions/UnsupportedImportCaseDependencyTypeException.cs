namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseDependencyTypeException : Exception
{
    public UnsupportedImportCaseDependencyTypeException(string code)
        : base($"Import Case Dependency Type \"{code}\" is unsupported.")
    {
    }
}