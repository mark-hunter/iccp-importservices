namespace Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchetypes.Exceptions;

public class UnsupportedConcernTypeException : Exception
{
    public UnsupportedConcernTypeException(string code)
        : base($"Concern Type \"{code}\" is unsupported.")
    {
    }
}