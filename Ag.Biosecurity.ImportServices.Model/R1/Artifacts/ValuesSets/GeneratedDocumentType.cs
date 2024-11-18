using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

public class GeneratedDocumentType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/generated-document-type";
        private const string CodeSystemVersion = "R1";

        public static readonly GeneratedDocumentType AttDocument = new GeneratedDocumentType( "AttDocument", "GeneratedDocumentType.AttDocumentType", CodeSystemId, CodeSystemVersion, "Generated Document Type  - Attached Document", "4F402A0A-7124-4047-B595-21BD3802A660" );
        public static readonly GeneratedDocumentType SacDocumentDirection = new GeneratedDocumentType( "SacDocumentDirection", "GeneratedDocumentType.SacDocumentDirection", CodeSystemId, CodeSystemVersion,"Generated Document Type - SAC Document Direction", "AF89C2C1-9189-4B1B-8A2C-2B79A0ECD615" );
        public static readonly GeneratedDocumentType SacDocumentNotice= new GeneratedDocumentType( "SacDocumentNotice", "GeneratedDocumentType.SacDocumentNotice", CodeSystemId, CodeSystemVersion,"Generated Document Type - SAC Document Notice", "9D05CAAD-06CC-4CF5-B7E9-DB44C28D4DF3" );
        public static readonly GeneratedDocumentType ContainerDocument= new GeneratedDocumentType( "ContainerDocument", "GeneratedDocumentType.ContainerDocument", CodeSystemId, CodeSystemVersion,"Generated Document Type - Container Document", "2E4BEDC2-2CF8-486E-B28E-ABC754134B09" );

        private GeneratedDocumentType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<GeneratedDocumentType> GeneratedDocumentTypes
        {
                get
                {
                        yield return AttDocument;
                        yield return SacDocumentDirection;
                        yield return SacDocumentNotice;
                        yield return ContainerDocument;
                }
        }

        private static GeneratedDocumentType FromCode(string code)
        {
                foreach(GeneratedDocumentType directionType in GeneratedDocumentTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedGeneratedDocumentTypeException(code);
        }

        private static GeneratedDocumentType FromGuid(string guid)
        {
                foreach(GeneratedDocumentType directionType in GeneratedDocumentTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedGeneratedDocumentTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(GeneratedDocumentType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator GeneratedDocumentType(string code)
        {
                return FromCode(code);
        }
}