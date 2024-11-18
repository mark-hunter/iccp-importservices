namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedIdentityAssuranceTypeException : Exception
{
    public UnsupportedIdentityAssuranceTypeException(string code)
        : base($"Identity Assurance Type \"{code}\" is unsupported.")
    {
    }
}