using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Cargo.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Cargo.ValueSets;

/// <summary>
/// The set of ImportDeclarationEntryStatus values
/// Derived (initially) from the IMS EntryStatusType constant classes.
/// </summary>
public class ImportDeclarationEntryStatusType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/import-declaration-entry-status-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ImportDeclarationEntryStatusType New = new ImportDeclarationEntryStatusType( "New", "ImportDeclarationEntryStatusType.New", CodeSystemId, CodeSystemVersion, "Import Declaration Entry Status - New Id", "0FD56EDF-4726-478F-9B2F-125388724BA5" );
        public static readonly ImportDeclarationEntryStatusType NewWaitingForDocumentation = new ImportDeclarationEntryStatusType( "NewWaitingForDocumentation", "ImportDeclarationEntryStatusType.NewWaitingForDocumentation", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - New - Awaiting Documentations", "AC820DCC-4D52-43ED-82BD-4A736C991958" );
        public static readonly ImportDeclarationEntryStatusType PendingInformation = new ImportDeclarationEntryStatusType( "PendingInformation", "ImportDeclarationEntryStatusType.PendingInformation", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Pending Information", "1D8D8371-C65F-4C4E-BDFE-650E498DF7D8" );
        public static readonly ImportDeclarationEntryStatusType Finalised = new ImportDeclarationEntryStatusType( "Finalised", "ImportDeclarationEntryStatusType.Finalised", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Finalised", "8DD98651-CA5F-4177-99B0-D1228DF5B361" );
        public static readonly ImportDeclarationEntryStatusType PendingClientAction = new ImportDeclarationEntryStatusType( "PendingClientAction", "ImportDeclarationEntryStatusType.PendingClientAction", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Pending Client Action", "A43C5412-CE67-4253-8A83-6271AEA18248" );
        public static readonly ImportDeclarationEntryStatusType AwaitingInspection = new ImportDeclarationEntryStatusType( "AwaitingInspection", "ImportDeclarationEntryStatusType.AwaitingInspection", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Awaiting Inspection", "FE1B1D7F-F70A-493A-AF1C-E81ABC988CD0" );
        public static readonly ImportDeclarationEntryStatusType Withdrawn = new ImportDeclarationEntryStatusType( "Withdrawn", "ImportDeclarationEntryStatusType.Withdrawn", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Withdrawn", "3FDDBB7D-A03D-4ED1-AE10-5E1E7A2212AD" );
        public static readonly ImportDeclarationEntryStatusType Upgraded = new ImportDeclarationEntryStatusType( "Upgraded", "ImportDeclarationEntryStatusType.Upgraded", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Upgraded", "FA4014A1-88AA-42EC-BC42-A61FDE74F423" );
        public static readonly ImportDeclarationEntryStatusType AssessmentInProgress = new ImportDeclarationEntryStatusType( "AssessmentInProgress", "ImportDeclarationEntryStatusType.AssessmentInProgress", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Assessment In Progress", "FA1FB7F7-2C32-4BED-AE12-18D9C0723C0C" );
        public static readonly ImportDeclarationEntryStatusType InspectionInProgress = new ImportDeclarationEntryStatusType( "IInspectionInProgress", "ImportDeclarationEntryStatusType.InspectionInProgress", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Inspection In Progress", "B108D685-9F98-403B-B42C-FC791C235F69" );
        public static readonly ImportDeclarationEntryStatusType Created = new ImportDeclarationEntryStatusType( "Created", "ImportDeclarationEntryStatusType.Created", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Created", "622155C7-1DC3-465A-A63D-BE79FB2DB5E1" );
        public static readonly ImportDeclarationEntryStatusType Active = new ImportDeclarationEntryStatusType( "Active", "ImportDeclarationEntryStatusType.Active", CodeSystemId, CodeSystemVersion,"Import Declaration Entry Status - Active", "26A3ECF3-07F7-4AE6-8F9D-AA019667BC91" );
        
        private ImportDeclarationEntryStatusType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<ImportDeclarationEntryStatusType> ImportDeclarationEntryStatusTypes
        {
                get
                {
                        yield return New;
                        yield return NewWaitingForDocumentation;
                        yield return AssessmentInProgress;
                        yield return InspectionInProgress;
                        yield return Upgraded;
                        yield return PendingInformation;
                        yield return Finalised;
                        yield return AwaitingInspection;
                        yield return PendingClientAction;
                        yield return Withdrawn;
                        yield return Created;
                        yield return Active;
                }
        }

        private static ImportDeclarationEntryStatusType FromCode(string code)
        {
                foreach(ImportDeclarationEntryStatusType directionType in ImportDeclarationEntryStatusTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationEntryStatusException(code);
        }

        private static ImportDeclarationEntryStatusType FromGuid(string guid)
        {
                foreach(ImportDeclarationEntryStatusType directionType in ImportDeclarationEntryStatusTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedImportDeclarationEntryStatusException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ImportDeclarationEntryStatusType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ImportDeclarationEntryStatusType(string code)
        {
                return FromCode(code);
        }
}