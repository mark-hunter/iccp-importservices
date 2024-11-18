namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseActivityStatusTypeException : Exception
{
    public UnsupportedImportCaseActivityStatusTypeException(string code)
        : base($"ImportCaseActivityType \"{code}\" is unsupported.")
    {
    }
}