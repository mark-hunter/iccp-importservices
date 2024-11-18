using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

/// <summary>
/// The set of EvidenceTypes
/// Derived (initially) from the IMS DocEvidenceType and DocumentEvidenceType constant classes.
/// </summary>
public class EvidenceType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/evidence-type";
        private const string CodeSystemVersion = "R1";

        public static readonly EvidenceType OtherEvidenceType = new EvidenceType( "IM-DOC-EVDNCE-TYPE-OTHER", "EvidenceType.OtherEvidenceType", CodeSystemId, CodeSystemVersion, "Evidence Type  - Other Evidence Type", "" );
        public static readonly EvidenceType ImportPermit = new EvidenceType( "IM-DOC-EVDNCE-TYPE-IMPRT-PRMT", "EvidenceType.ImportPermit", CodeSystemId, CodeSystemVersion,"Evidence Type  - Import Permit", "" );
        public static readonly EvidenceType Hawb = new EvidenceType( "IM-DOC-EVDNCE-TYPE-HAWB", "EvidenceType.Hawb", CodeSystemId, CodeSystemVersion,"Evidence Type  - Hawb", "" );
        public static readonly EvidenceType Hbol = new EvidenceType( "IM-DOC-EVDNCE-TYPE-HBOL", "EvidenceType.Hbol", CodeSystemId, CodeSystemVersion,"Evidence Type  - Hbol", "" );
        public static readonly EvidenceType Invoice = new EvidenceType( "IM-DOC-EVDNCE-TYPE-INVOICE", "EvidenceType.Invoice", CodeSystemId, CodeSystemVersion,"Evidence Type  - Invoice", "" );
        public static readonly EvidenceType DisposeConveyanceForm = new EvidenceType( "IM-DOC-EVDNCE-TYPE-DISPOSE-CONVYNC-FORM", "EvidenceType.DisposeConveyanceForm", CodeSystemId, CodeSystemVersion,"Evidence Type  -Dispose Conveyance Form", "" );
        public static readonly EvidenceType Manufacture = new EvidenceType( "IM-DOC-EVDNCE-TYPE-MNFCTR-DEC", "EvidenceType.ManufacturerDeclaration", CodeSystemId, CodeSystemVersion,"Evidence Type  - Manufacturer Declaration", "" );
        public static readonly EvidenceType Phytocntry = new EvidenceType( "IM-DOC-EVDNCE-TYPE-PHYTOCNTRY-CERT", "EvidenceType.Phytocntry", CodeSystemId, CodeSystemVersion,"Evidence Type  - Phytocntry Certificate", "" );
        public static readonly EvidenceType Export = new EvidenceType( "IM-DOC-EVDNCE-TYPE-EXPRT-BILL", "EvidenceType.ExportBill", CodeSystemId, CodeSystemVersion,"Evidence Type  - Export Bill", "" );
        public static readonly EvidenceType SeedCert = new EvidenceType( "IM-DOC-EVDNCE-TYPE-SEED-CERT", "EvidenceType.SeedCertificate", CodeSystemId, CodeSystemVersion,"Evidence Type  - Seed Certificate", "" );
        public static readonly EvidenceType Treatment = new EvidenceType( "IM-DOC-EVDNCE-TYPE-TRTMNT-CERT", "EvidenceType.TreatmentCertificate", CodeSystemId, CodeSystemVersion,"Evidence Type  - Treatement Certificate", "" );
        
        private EvidenceType(string code, string longCode, string codeSystem, string codeSystemVersion, string text, string legacyGuid)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = codeSystem;
                CodeVersion = codeSystemVersion;
                LegacyGuid = legacyGuid;
        }
        
        private static IEnumerable<EvidenceType> EvidenceTypes
        {
                get
                {
                        yield return OtherEvidenceType;
                        yield return ImportPermit;
                        yield return Hawb;
                        yield return Hbol;
                        yield return Invoice;
                        yield return DisposeConveyanceForm;
                        yield return Manufacture;
                        yield return Phytocntry;
                        yield return Export;
                        yield return SeedCert;
                        yield return Treatment;
                }
        }

        private static EvidenceType FromCode(string code)
        {
                foreach(EvidenceType directionType in EvidenceTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedEvidenceTypeException(code);
        }

        private static EvidenceType FromGuid(string guid)
        {
                foreach(EvidenceType directionType in EvidenceTypes )

                        if (string.Equals(directionType.LegacyGuid, guid, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedEvidenceTypeException(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(EvidenceType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator EvidenceType(string code)
        {
                return FromCode(code);
        }
}