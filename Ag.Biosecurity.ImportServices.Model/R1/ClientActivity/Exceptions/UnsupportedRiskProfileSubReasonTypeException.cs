namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Exceptions;

public class UnsupportedRiskProfileSubReasonTypeException : Exception
{
    public UnsupportedRiskProfileSubReasonTypeException(string code)
        : base($"Risk Profile Sub-Reason Type \"{code}\" is unsupported.")
    {
    }
}