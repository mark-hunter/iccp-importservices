using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

/// <summary>
/// The set of ImportDeclarationEntryIdentifierTypes values
/// </summary>
public class ImportDeclarationLineItemIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-declaration-line-item-identifier-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ImportDeclarationLineItemIdentifierType AimsLineItemId = new ImportDeclarationLineItemIdentifierType( "AimsEntryId", "ImportDeclarationLineItemIdentifierType.AimsEntryId", CodeSystemId, CodeSystemVersion,"Import Declaration Line Item Identifier Type - AIMS::Entry Table PK", "" );
        public static readonly ImportDeclarationLineItemIdentifierType ImsLineItemId = new ImportDeclarationLineItemIdentifierType( "ImsEntryId", "ImportDeclarationLineItemIdentifierType.ImsEntryId", CodeSystemId, CodeSystemVersion,"Import Declaration Line Item Identifier Type - IMS::Entry Table PK", "" );
         
        private ImportDeclarationLineItemIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ImportDeclarationLineItemIdentifierType> ImportDeclarationLineItemIdentifierTypes
        {
                get
                {
                        yield return AimsLineItemId;
                        yield return ImsLineItemId;
                }
        }

        private static ImportDeclarationLineItemIdentifierType FromCode(string code)
        {
                foreach(ImportDeclarationLineItemIdentifierType directionType in ImportDeclarationLineItemIdentifierTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationLineItemIdentifierTypeException(code);
        }

        private static ImportDeclarationLineItemIdentifierType FromGuid(string guid)
        {
                foreach(ImportDeclarationLineItemIdentifierType directionType in ImportDeclarationLineItemIdentifierTypes )

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

        public static implicit operator string(ImportDeclarationLineItemIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ImportDeclarationLineItemIdentifierType(string code)
        {
                return FromCode(code);
        }
}