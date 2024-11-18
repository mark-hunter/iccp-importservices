using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

public class AddressUseType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/address-use-type";
        private const string CodeSystemVersion = "R1";

        public static readonly AddressUseType Home = new AddressUseType( "Home", "AddressType.Home", "Home Address" );
        public static readonly AddressUseType Work = new AddressUseType( "Work", "AddressType.Work", "Work Address" );
        public static readonly AddressUseType Billing = new AddressUseType( "Billing", "AddressType.Billing", "Billing Address" );
        public static readonly AddressUseType Old = new AddressUseType( "Old", "AddressType.Old", "Old Address" );
        public static readonly AddressUseType Temp = new AddressUseType( "Temp", "AddressType.Temp", "Temp Address" );
        private AddressUseType(string code, string longCode, string text)
        {
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = CodeSystemId;
                CodeVersion = CodeSystemVersion;
        }
        
        private static IEnumerable<AddressUseType> AddressUses
        {
                get
                {
                        yield return Home;
                        yield return Work;
                        yield return Billing;
                        yield return Old;
                        yield return Temp;
                }
        }

        private static AddressUseType From(string code)
        {
                foreach(AddressUseType directionType in AddressUses )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }
                
                throw new UnsupportedAddressUseException(code);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(AddressUseType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator AddressUseType(string code)
        {
                return From(code);
        }
}