namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedIdentityProofingLevelTypeException : Exception
{
    public UnsupportedIdentityProofingLevelTypeException(string code)
        : base($"Identity Proofing Level Type \"{code}\" is unsupported.")
    {
    }
}