using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Entity.ValueSets;

/// <summary>
/// The set of ImportDeclarationIdentifierTypes values
/// </summary>
public class EntityIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/entity-identifier-type";
        private const string CodeSystemVersion = "R1";

        public static readonly EntityIdentifierType AimsBrokerId = new EntityIdentifierType( "AimsBrokerId", "EntityIdentityType.AimsBrokerId", CodeSystemId, CodeSystemVersion, "Entity Identifier Type - AIMS Broker Id", "" );
        public static readonly EntityIdentifierType AimsImporterId = new EntityIdentifierType( "AimsImporterId", "EntityIdentityType.AimsImporterId", CodeSystemId, CodeSystemVersion, "Entity Identifier Type - AIMS Importer Id", "" );
        private EntityIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<EntityIdentifierType> EntityIdentifierTypes
        {
                get
                {
                        yield return AimsBrokerId;
                        yield return AimsImporterId;
                }
        }

        private static EntityIdentifierType FromCode(string code)
        {
                foreach(EntityIdentifierType entityIdentifierType in EntityIdentifierTypes )

                        if (string.Equals(entityIdentifierType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (entityIdentifierType);
                        }

                throw new UnsupportedEntityIdentifierTypeException(code);
        }

        private static EntityIdentifierType FromGuid(string guid)
        {
                foreach(EntityIdentifierType entityIdentifierType in EntityIdentifierTypes )

                        if (string.Equals(entityIdentifierType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (entityIdentifierType);
                        }

                throw new UnsupportedEntityIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(EntityIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator EntityIdentifierType(string code)
        {
                return FromCode(code);
        }
}