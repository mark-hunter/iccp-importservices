namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedCredentialTypeException : Exception
{
    public UnsupportedCredentialTypeException(string code)
        : base($"Credential Type \"{code}\" is unsupported.")
    {
    }
}