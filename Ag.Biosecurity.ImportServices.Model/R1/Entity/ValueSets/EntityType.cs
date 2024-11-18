using System.ComponentModel;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

public class EntityType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/entity-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly EntityType Organisation = new EntityType( "Organisation");
    public static readonly EntityType BusinessUnit = new EntityType( "BusinessUnit");
    public static readonly EntityType Person = new EntityType( "Person");
    public static readonly EntityType CommunityOfInterest = new EntityType( "CommunityOfInterest");
    public static readonly EntityType IndustryBody = new EntityType( "IndustryBody");
    public static readonly EntityType StandardsBody = new EntityType( "StandardsBody");
    public static readonly EntityType GovernmentDepartment = new EntityType( "GovernmentDepartment");

    private EntityType(string code)
    {
        Code = code;
        Text = GetType().Name + "." + code;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    
    private static IEnumerable<EntityType> EntityTypes
    {
        get
        {
            yield return Organisation;
            yield return BusinessUnit;
            yield return Person;
            yield return CommunityOfInterest;
            yield return StandardsBody;
            yield return IndustryBody;
            yield return GovernmentDepartment;
        }
    }
    
    private static EntityType From(string code)
    {
        var EntityType = new EntityType(code);

        if (!EntityTypes.Contains(EntityType))
        {
            throw new UnsupportedEntityTypeException(code);
        }

        return EntityType;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(EntityType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator EntityType(string code)
    {
        return From(code);
    }
}