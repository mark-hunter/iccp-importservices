using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

public class AddressType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/address-type";
        private const string CodeSystemVersion = "R1";

        public static readonly AddressType Postal = new AddressType( "Postal", "AddressType.Postal", "Postal Address" );
        public static readonly AddressType Physical = new AddressType( "Physical", "AddressType.Physical", "Physical Address" );
        public static readonly AddressType Both = new AddressType( "Both", "AddressType.Both", "Both Postal and Physical Address" );
        
        private AddressType(string code, string longCode, string text)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = CodeSystemId;
                CodeVersion = CodeSystemVersion;
        }
        
        private static IEnumerable<AddressType> AddressTypes
        {
                get
                {
                        yield return Postal;
                        yield return Physical;
                        yield return Both;
                }
        }

        private static AddressType From(string code)
        {
                foreach(AddressType directionType in AddressTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedAddressTypeException(code);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(AddressType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator AddressType(string code)
        {
                return From(code);
        }
}