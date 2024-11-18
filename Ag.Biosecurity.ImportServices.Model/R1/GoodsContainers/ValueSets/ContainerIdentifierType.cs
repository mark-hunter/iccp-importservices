using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.GoodsContainers.ValueSets;

/// <summary>
/// The set of Container Identifier Types values
/// </summary>
public class ContainerIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/container-identifier-type";
        private const string CodeSystemVersion = "R1";

        public static readonly ContainerIdentifierType AimsContainerId = new ContainerIdentifierType( "AimsContainerId", "ContainerIdentifierType.AimsContainerId", CodeSystemId, CodeSystemVersion,"Container Identifier Type - AIMS::Entry Table PK", "" );
        public static readonly ContainerIdentifierType ImsContainerId = new ContainerIdentifierType( "ImsContainerId", "ContainerIdentifierType.ImsContainerId", CodeSystemId, CodeSystemVersion,"Container Identifier Type - IMS::Entry Table PK", "" );
         
        private ContainerIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ContainerIdentifierType> ContainerIdentifierTypes
        {
                get
                {
                        yield return AimsContainerId;
                        yield return ImsContainerId;
                }
        }

        private static ContainerIdentifierType FromCode(string code)
        {
                foreach(ContainerIdentifierType directionType in ContainerIdentifierTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationLineItemIdentifierTypeException(code);
        }

        private static ContainerIdentifierType FromGuid(string guid)
        {
                foreach(ContainerIdentifierType directionType in ContainerIdentifierTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationLineItemIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ContainerIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ContainerIdentifierType(string code)
        {
                return FromCode(code);
        }

}