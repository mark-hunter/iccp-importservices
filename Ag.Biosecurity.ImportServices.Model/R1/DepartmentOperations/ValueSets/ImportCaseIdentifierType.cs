using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;

/// <summary>
/// The set of ImportDeclarationIdentifierTypes values
/// </summary>
public class ImportCaseIdentifierType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-case-identifier-type";
        private const string CodeSystemVersion = "R1";

        public static readonly ImportCaseIdentifierType QuarantineEntryId = new ImportCaseIdentifierType( "QuarantineEntryId", "ImportCaseIdentifierType.QuarantineEntryId", CodeSystemId, CodeSystemVersion, "Import Case Identifier Type - AIMS Id", "" );
        private ImportCaseIdentifierType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ImportCaseIdentifierType> ImportCaseIdentifierTypes
        {
                get
                {
                        yield return QuarantineEntryId;
                }
        }

        private static ImportCaseIdentifierType FromCode(string code)
        {
                foreach(ImportCaseIdentifierType importCaseIdentifierType in ImportCaseIdentifierTypes )

                        if (string.Equals(importCaseIdentifierType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (importCaseIdentifierType);
                        }

                throw new UnsupportedImportCaseIdentifierTypeException(code);
        }

        private static ImportCaseIdentifierType FromGuid(string guid)
        {
                foreach(ImportCaseIdentifierType importCaseIdentifierType in ImportCaseIdentifierTypes )

                        if (string.Equals(importCaseIdentifierType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (importCaseIdentifierType);
                        }

                throw new UnsupportedImportCaseIdentifierTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ImportCaseIdentifierType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ImportCaseIdentifierType(string code)
        {
                return FromCode(code);
        }
}