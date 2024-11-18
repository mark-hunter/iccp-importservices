namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

public class UnsupportedImportCaseRelationshipTypeException : Exception
{
    public UnsupportedImportCaseRelationshipTypeException(string code)
        : base($"Import Case Relationship Type \"{code}\" is unsupported.")
    {
    }
}