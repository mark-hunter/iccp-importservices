namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

public class UnsupportedDirectionCategoryTypeException : Exception
{
    public UnsupportedDirectionCategoryTypeException(string code)
        : base($"Direction Category Type \"{code}\" is unsupported.")
    {
    }
}