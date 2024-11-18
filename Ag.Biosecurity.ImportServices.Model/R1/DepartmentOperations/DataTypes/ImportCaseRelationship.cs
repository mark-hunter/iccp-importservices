using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.DataTypes;

public class ImportCaseRelationship : DataTypeMetadata
{
    public ImportCaseRelationshipType RelationshipType { get; set; }
    public Reference<ImportCase> RelatedCase { get; set; }
    public ImportCaseDependencyType DependencyType { get; set; }

    public ImportCaseRelationship() : base()
    {
        RelationshipType = ImportCaseRelationshipType.SubCase;
        RelatedCase = new Reference<ImportCase>();
    }

    public ImportCaseRelationship(ImportCaseRelationshipType relationshipType, Reference<ImportCase> relatedCase)
    {
        RelationshipType = relationshipType;
        RelatedCase = relatedCase;
    }
}