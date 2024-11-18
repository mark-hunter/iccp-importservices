namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseAssociatedResourceRoleTypeException : Exception
{
    public UnsupportedImportCaseAssociatedResourceRoleTypeException(string code)
        : base($"Import Case Associated Resource Role Type \"{code}\" is unsupported.")
    {
    }
}