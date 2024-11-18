using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

public class ContactPointType: ValueDataType
{
        private const string CodeSystemId = "https://aff.gov.au/imports/iccp/codesets/contact-point-type";
        private const string CodeSystemVersion = "1.0.0";

        public static readonly ContactPointType Email = new ContactPointType( "Email", "EMAIL", "ContactPointType.Email", "Email Address" );
        public static readonly ContactPointType Mobile = new ContactPointType( "Mobile", "MOBILE", "ContactPointType.Mobile", "Mobile (Cell) Phone Number" );
        public static readonly ContactPointType FixedLine = new ContactPointType( "FixedLine", "FIXED_LINE", "ContactPointType.FixedLine", "Fixed Line, Desk or Residential Phone Number" );
        public static readonly ContactPointType Facsimile = new ContactPointType( "Facsimile", "FACSIMILE", "ContactPointType.Facsimile", "Facsimile Line Number" );
        public static readonly ContactPointType SocialMediaAccount = new ContactPointType( "SocialMediaAccount", "SOCIAL_MEDIA_ACCOUNT", "ContactPointType.SocialMediaAccount", "Social Media Account Name / Tag" );
        public static readonly ContactPointType InstantMessaging = new ContactPointType( "InstantMessaging", "INSTANT_MESSAGING", "ContactPointType.InstantMessaging", "Instant Messaging Account Name / Tag" );
        public static readonly ContactPointType Other = new ContactPointType( "Other", "OTHER", "ContactPointType.Other", "Contact Point Type is Not Defined" );

        private ContactPointType(string name, string code, string longCode, string text)
        {
                Name = name;
                Code = code;
                LongCode = longCode;
                Text = text;
                CodeSystem = CodeSystemId;
                CodeVersion = CodeSystemVersion;
        }
        
        private static IEnumerable<ContactPointType> ContactPointTypes
        {
                get
                {
                        yield return Email;
                        yield return Mobile;
                        yield return FixedLine;
                        yield return Facsimile;
                        yield return SocialMediaAccount;
                        yield return InstantMessaging;
                        yield return Other;
                }
        }

        private static ContactPointType From(string code)
        {
                foreach(ContactPointType directionType in ContactPointTypes )

                        if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
                        {
                                return (directionType);
                        }

                throw new UnsupportedContactPointTypeException(code);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
                yield return Code;
        }

        public static implicit operator string(ContactPointType roleType)
        {
                return roleType.ToString();
        }

        public static explicit operator ContactPointType(string code)
        {
                return From(code);
        }
}