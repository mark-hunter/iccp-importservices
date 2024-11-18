namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseActivityStatusReasonTypeException : Exception
{
    public UnsupportedImportCaseActivityStatusReasonTypeException(string code)
        : base($"Import Case Activity Status Reason Type \"{code}\" is unsupported.")
    {
    }
}