namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedTaskPriorityTypeException : Exception
{
    public UnsupportedTaskPriorityTypeException(string code)
        : base($"Task Priority Type \"{code}\" is unsupported.")
    {
    }
}