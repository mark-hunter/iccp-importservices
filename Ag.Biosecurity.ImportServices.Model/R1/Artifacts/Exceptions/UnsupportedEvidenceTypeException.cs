namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

public class UnsupportedEvidenceTypeException : Exception
{
    public UnsupportedEvidenceTypeException(string code)
        : base($"Evidence Type \"{code}\" is unsupported.")
    {
    }
}