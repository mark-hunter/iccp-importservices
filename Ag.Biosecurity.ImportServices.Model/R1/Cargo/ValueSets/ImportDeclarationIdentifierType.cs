using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

/// <summary>
/// The set of ImportDeclarationIdentifierTypes values
/// </summary>
public class ImportDeclarationIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-declaration-identifier-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ImportDeclarationIdentifierType QuarantineEntryId = new ImportDeclarationIdentifierType( "QuarantineEntryId", "ImportDeclarationIdentifierType.QuarantineEntryId", CodeSystemId, CodeSystemVersion, "Import Declaration Identifier Type - Quarantine Entry Id", "" );
        private ImportDeclarationIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ImportDeclarationIdentifierType> ImportDeclarationIdentifierTypes
        {
                get
                {
                        yield return QuarantineEntryId;
                }
        }

        private static ImportDeclarationIdentifierType FromCode(string code)
        {
                foreach(ImportDeclarationIdentifierType directionType in ImportDeclarationIdentifierTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationIdentifierTypeException(code);
        }

        private static ImportDeclarationIdentifierType FromGuid(string guid)
        {
                foreach(ImportDeclarationIdentifierType directionType in ImportDeclarationIdentifierTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ImportDeclarationIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ImportDeclarationIdentifierType(string code)
        {
                return FromCode(code);
        }
}