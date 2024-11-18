namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedRiskProfileReasonTypeException : Exception
{
    public UnsupportedRiskProfileReasonTypeException(string code)
        : base($"Risk Profile Reason Type \"{code}\" is unsupported.")
    {
    }
}