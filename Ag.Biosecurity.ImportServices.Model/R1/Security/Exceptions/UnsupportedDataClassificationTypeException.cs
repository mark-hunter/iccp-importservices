namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedDataClassificationTypeException : Exception
{
    public UnsupportedDataClassificationTypeException(string code)
        : base($"Data Classification Type \"{code}\" is unsupported.")
    {
    }
}