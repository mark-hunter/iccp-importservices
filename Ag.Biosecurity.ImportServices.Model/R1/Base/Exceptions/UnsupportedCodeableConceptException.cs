namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

public class UnsupportedCodeableConceptException : Exception
{
    public UnsupportedCodeableConceptException(string reason)
        : base($"Codeable Concept is unsupported, reason -> {reason}")
    {
    }
}