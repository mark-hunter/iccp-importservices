using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

/// <summary>
/// The set of ImportDeclarationIdentifierTypes values
/// </summary>
public class DirectionIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/direction-identifier-type";
        private const string CodeSystemVersion = "R1";

        public static readonly DirectionIdentifierType AimsId = new DirectionIdentifierType( "AimsId", "DirectionIdentifierType.AimsId", CodeSystemId, CodeSystemVersion, "Direction Identifier Type - AIMS Id", "" );
        private DirectionIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<DirectionIdentifierType> DirectionIdentifierTypes
        {
                get
                {
                        yield return AimsId;
                }
        }

        private static DirectionIdentifierType FromCode(string code)
        {
                foreach(DirectionIdentifierType directionIdentifierType in DirectionIdentifierTypes )

                        if (string.Equals(directionIdentifierType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionIdentifierType);
                        }

                throw new UnsupportedImportDeclarationIdentifierTypeException(code);
        }

        private static DirectionIdentifierType FromGuid(string guid)
        {
                foreach(DirectionIdentifierType directionIdentifierType in DirectionIdentifierTypes )

                        if (string.Equals(directionIdentifierType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionIdentifierType);
                        }

                throw new UnsupportedImportDeclarationIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(DirectionIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator DirectionIdentifierType(string code)
        {
                return FromCode(code);
        }
}