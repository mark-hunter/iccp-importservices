using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

/// <summary>
/// The set of ImportDeclarationEntryIdentifierTypes values
/// </summary>
public class ImportDeclarationEntryIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-declaration-entry-identifier-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ImportDeclarationEntryIdentifierType QuarantineEntryId = new ImportDeclarationEntryIdentifierType( "QuarantineEntryId", "QUARANTINE_ENTRY_ID", "ImportDeclarationEntryIdentifierType.QuarantineEntryId", CodeSystemId, CodeSystemVersion, "Import Declaration Entry Identifier Type - Quarantine Entry Id", "" );
        public static readonly ImportDeclarationEntryIdentifierType AimsEntryId = new ImportDeclarationEntryIdentifierType( "AimsEntryId", "AIMS_ENTRY_ID", "ImportDeclarationEntryIdentifierType.AimsEntryId", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Identifier Type - AIMS::Entry Table PK", "" );
        public static readonly ImportDeclarationEntryIdentifierType ImsEntryId = new ImportDeclarationEntryIdentifierType( "ImsEntryId", "IMS_ENTRY_ID", "ImportDeclarationEntryIdentifierType.ImsEntryId", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Identifier Type - IMS::Entry Table PK", "" );
         
        private ImportDeclarationEntryIdentifierType(string name, string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Name = name;
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ImportDeclarationEntryIdentifierType> ImportDeclarationEntryIdentifierTypes
        {
                get
                {
                        yield return QuarantineEntryId;
                        yield return AimsEntryId;
                        yield return ImsEntryId;

                }
        }

        private static ImportDeclarationEntryIdentifierType FromCode(string code)
        {
                foreach(ImportDeclarationEntryIdentifierType directionType in ImportDeclarationEntryIdentifierTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationEntryIdentifierTypeException(code);
        }

        private static ImportDeclarationEntryIdentifierType FromGuid(string guid)
        {
                foreach(ImportDeclarationEntryIdentifierType directionType in ImportDeclarationEntryIdentifierTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationEntryIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ImportDeclarationEntryIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ImportDeclarationEntryIdentifierType(string code)
        {
                return FromCode(code);
        }
}