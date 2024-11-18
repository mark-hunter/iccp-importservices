namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseActivityTypeException : Exception
{
    public UnsupportedImportCaseActivityTypeException(string code)
        : base($"ImportCaseActivityType \"{code}\" is unsupported.")
    {
    }
}