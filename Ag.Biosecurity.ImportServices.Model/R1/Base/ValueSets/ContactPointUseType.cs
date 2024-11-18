using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

public class ContactPointUseType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/contact-point-use-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ContactPointUseType Home = new ContactPointUseType( "Home", "HOME", "ContactPointUseType.Home", "A communication contact point at a home; attempted contacts for business purposes might intrude privacy and chances are one will contact family or other household members instead of the person one wishes to call. Typically used with urgent cases, or if no other contacts are available." );
        public static readonly ContactPointUseType Work = new ContactPointUseType( "Work", "WORK", "ContactPointUseType.Work", "An office contact point. First choice for business related contacts during business hours." );
        public static readonly ContactPointUseType Temp = new ContactPointUseType( "Temp", "TEMP", "ContactPointUseType.Temp", "A temporary contact point. The EffectivePeriod can provide more detailed information." );
        public static readonly ContactPointUseType Old = new ContactPointUseType( "Old", "OLD", "ContactPointUseType.Old", "This contact point is no longer in use (or was never correct, but retained for records)." );
        public static readonly ContactPointUseType Personal = new ContactPointUseType( "Personal", "PERSONAL", "ContactPointUseType.Personal", "A communication contact point identified as personal; attempted contacts for business purposes might intrude privacy and discretion is advised outside business hours." );
        
        private ContactPointUseType(string name, string code, string longCode, string text)
        {
                Name = name;
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = CodeSystemId;
                CodeVersion = CodeSystemVersion;
        }
        
        private static IEnumerable<ContactPointUseType> ContactPointUseTypes
        {
                get
                {
                        yield return Home;
                        yield return Work;
                        yield return Temp;
                        yield return Old;
                        yield return Personal;
                }
        }

        private static ContactPointUseType From(string code)
        {
                foreach(ContactPointUseType directionType in ContactPointUseTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedContactPointUseTypeException(code);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ContactPointUseType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ContactPointUseType(string code)
        {
                return From(code);
        }
}