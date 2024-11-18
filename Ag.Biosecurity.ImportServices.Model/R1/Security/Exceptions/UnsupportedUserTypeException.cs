namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedUserTypeException : Exception
{
    public UnsupportedUserTypeException(string code)
        : base($"User Type \"{code}\" is unsupported.")
    {
    }
}