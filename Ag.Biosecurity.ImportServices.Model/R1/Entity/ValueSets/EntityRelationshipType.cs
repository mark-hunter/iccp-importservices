using System.ComponentModel;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

public class EntityRelationshipType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/entity-relationship-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly EntityRelationshipType ParentOrganisation = new EntityRelationshipType( "ParentOrganisation");
    public static readonly EntityRelationshipType ChildOrganisation = new EntityRelationshipType( "ChildOrganisation");
    public static readonly EntityRelationshipType BusinessUnit = new EntityRelationshipType( "BusinessUnit");
    public static readonly EntityRelationshipType Employee = new EntityRelationshipType( "Employee");
    public static readonly EntityRelationshipType Employer = new EntityRelationshipType( "Employer");
    public static readonly EntityRelationshipType Subcontractor = new EntityRelationshipType( "Subcontractor");
    public static readonly EntityRelationshipType ParentContractor = new EntityRelationshipType( "ParentContractor");
    public static readonly EntityRelationshipType Client = new EntityRelationshipType( "Client");
    public static readonly EntityRelationshipType ServiceProvider = new EntityRelationshipType( "ServiceProvider");
    public static readonly EntityRelationshipType GroupMember = new EntityRelationshipType( "GroupMember");
    public static readonly EntityRelationshipType IndustryBody = new EntityRelationshipType( "IndustryBody");
    public static readonly EntityRelationshipType StandardsBody = new EntityRelationshipType( "StandardsBody");
    public static readonly EntityRelationshipType UndocumentedRelationship = new EntityRelationshipType( "UndocumentedRelationship");

    private EntityRelationshipType(string code)
    {
        Code = code;
        Text = GetType().Name + "." + code;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    
    private static IEnumerable<EntityRelationshipType> EntityRelationshipTypes
    {
        get
        {
            yield return ParentOrganisation;
            yield return ChildOrganisation;
            yield return BusinessUnit;
            yield return Employee;
            yield return Employer;
            yield return Subcontractor;
            yield return ParentContractor;
            yield return Client;
            yield return ServiceProvider;
            yield return ServiceProvider;
            yield return GroupMember;
            yield return IndustryBody;
            yield return StandardsBody;
            yield return UndocumentedRelationship;
        }
    }
    
    private static EntityRelationshipType From(string code)
    {
        foreach (EntityRelationshipType relationshipType in EntityRelationshipTypes)
        {
            if (string.Equals(relationshipType.Code, code))
            {
                return relationshipType;
            }
        }
        throw new UnsupportedEntityRelationshipTypeException(code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(EntityRelationshipType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator EntityRelationshipType(string code)
    {
        return From(code);
    }
}