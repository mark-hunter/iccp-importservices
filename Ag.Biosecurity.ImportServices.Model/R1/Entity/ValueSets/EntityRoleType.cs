using System.ComponentModel;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

public class EntityRoleType : ValueDataType
{
    private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/entity-role-type";
    private const string CodeSystemVersion = "R1";
    
    public static readonly EntityRoleType Broker = new EntityRoleType( "Broker");
    public static readonly EntityRoleType ConveyanceProvider = new EntityRoleType( "ConveyanceProvider");
    public static readonly EntityRoleType DepartmentalOfficer = new EntityRoleType( "DepartmentalOfficer");
    public static readonly EntityRoleType Exporter = new EntityRoleType( "Exporter");
    public static readonly EntityRoleType Importer = new EntityRoleType( "Importer");
    public static readonly EntityRoleType InspectionOfficer = new EntityRoleType( "InspectionOfficer");
    public static readonly EntityRoleType Manufacturer = new EntityRoleType( "Manufacturer");
    public static readonly EntityRoleType Recipient = new EntityRoleType( "Recipient");
    public static readonly EntityRoleType Sender = new EntityRoleType( "Sender");
    public static readonly EntityRoleType ServiceProvider = new EntityRoleType( "ServiceProvider");
    public static readonly EntityRoleType Supplier = new EntityRoleType( "Supplier");
    public static readonly EntityRoleType TreatmentProvider = new EntityRoleType( "TreatmentProvider");

    private EntityRoleType(string code)
    {
        Code = code;
        Text = GetType().Name + "." + code;
        CodeSystem = CodeSystemId;
        CodeVersion = CodeSystemVersion;
    }
    
    private static IEnumerable<EntityRoleType> EntityRoleTypes
    {
        get
        {
            yield return Broker;
            yield return ConveyanceProvider;
            yield return DepartmentalOfficer;
            yield return Exporter;
            yield return Importer;
            yield return InspectionOfficer;
            yield return Manufacturer;
            yield return Recipient;
            yield return Sender;
            yield return ServiceProvider;
            yield return Supplier;
            yield return TreatmentProvider;
        }
    }
    
    private static EntityRoleType From(string code)
    {
        var entityRoleType = new EntityRoleType(code);

        if (!EntityRoleTypes.Contains(entityRoleType))
        {
            throw new UnsupportedEntityRoleTypeException(code);
        }

        return entityRoleType;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(EntityRoleType roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator EntityRoleType(string code)
    {
        return From(code);
    }
}