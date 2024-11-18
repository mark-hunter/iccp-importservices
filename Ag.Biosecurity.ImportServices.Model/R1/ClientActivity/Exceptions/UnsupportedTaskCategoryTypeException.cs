namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedTaskCategoryTypeException : Exception
{
    public UnsupportedTaskCategoryTypeException(string code)
        : base($"Task Category Type \"{code}\" is unsupported.")
    {
    }
}