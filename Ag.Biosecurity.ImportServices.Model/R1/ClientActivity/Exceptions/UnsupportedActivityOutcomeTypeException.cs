namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedOutcomeTypeException : Exception
{
    public UnsupportedOutcomeTypeException(string code)
        : base($"Activity Outcome Type \"{code}\" is unsupported.")
    {
    }
}