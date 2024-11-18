using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.ValueSets;

/// <summary>
/// The CountryCode class encompasses "most" of the values/details covered within the ISO-3166 standards, including
/// the Alpha2, Alpha3 and Numeric Code mappings.onenote
/// </summary>
public class CountryCode : ValueDataType
{ 
    public string? CountryName { get; set; }
    public string? CondensedName { get; set; }
    public string? NumericCountryCode { get; set; }
    public string? IsoCountryCode { get; set; }
    public string? Region { get; set; }
    public string? SubRegion { get; set; }
    
    private const string codeSystem = "https://www.iso.org/iso-3166-country-codes.html";
    private const string codeVersion = "2024-06-19";
    
    public static readonly CountryCode Afghanistan = new CountryCode( "Afghanistan", codeSystem, codeVersion, "Afghanistan", "AF", "AFG", "004", "ISO 3166-2:AF", "Asia", "Southern Asia");
    public static readonly CountryCode landIslands = new CountryCode( "landIslands", codeSystem, codeVersion, "Åland Islands", "AX", "ALA", "248", "ISO 3166-2:AX", "Europe", "Northern Europe");
    public static readonly CountryCode Albania = new CountryCode( "Albania", codeSystem, codeVersion, "Albania", "AL", "ALB", "008", "ISO 3166-2:AL", "Europe", "Southern Europe");
    public static readonly CountryCode Algeria = new CountryCode( "Algeria", codeSystem, codeVersion, "Algeria", "DZ", "DZA", "012", "ISO 3166-2:DZ", "Africa", "Northern Africa");
    public static readonly CountryCode AmericanSamoa = new CountryCode( "AmericanSamoa", codeSystem, codeVersion, "American Samoa", "AS", "ASM", "016", "ISO 3166-2:AS", "Oceania", "Polynesia");
    public static readonly CountryCode Andorra = new CountryCode( "Andorra", codeSystem, codeVersion, "Andorra", "AD", "AND", "020", "ISO 3166-2:AD", "Europe", "Southern Europe");
    public static readonly CountryCode Angola = new CountryCode( "Angola", codeSystem, codeVersion, "Angola", "AO", "AGO", "024", "ISO 3166-2:AO", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Anguilla = new CountryCode( "Anguilla", codeSystem, codeVersion, "Anguilla", "AI", "AIA", "660", "ISO 3166-2:AI", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Antarctica = new CountryCode( "Antarctica", codeSystem, codeVersion, "Antarctica", "AQ", "ATA", "010", "ISO 3166-2:AQ", "", "");
    public static readonly CountryCode AntiguaandBarbuda = new CountryCode( "AntiguaandBarbuda", codeSystem, codeVersion, "Antigua and Barbuda", "AG", "ATG", "028", "ISO 3166-2:AG", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Argentina = new CountryCode( "Argentina", codeSystem, codeVersion, "Argentina", "AR", "ARG", "032", "ISO 3166-2:AR", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Armenia = new CountryCode( "Armenia", codeSystem, codeVersion, "Armenia", "AM", "ARM", "051", "ISO 3166-2:AM", "Asia", "Western Asia");
    public static readonly CountryCode Aruba = new CountryCode( "Aruba", codeSystem, codeVersion, "Aruba", "AW", "ABW", "533", "ISO 3166-2:AW", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Australia = new CountryCode( "Australia", codeSystem, codeVersion, "Australia", "AU", "AUS", "036", "ISO 3166-2:AU", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode Austria = new CountryCode( "Austria", codeSystem, codeVersion, "Austria", "AT", "AUT", "040", "ISO 3166-2:AT", "Europe", "Western Europe");
    public static readonly CountryCode Azerbaijan = new CountryCode( "Azerbaijan", codeSystem, codeVersion, "Azerbaijan", "AZ", "AZE", "031", "ISO 3166-2:AZ", "Asia", "Western Asia");
    public static readonly CountryCode Bahamas = new CountryCode( "Bahamas", codeSystem, codeVersion, "Bahamas", "BS", "BHS", "044", "ISO 3166-2:BS", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Bahrain = new CountryCode( "Bahrain", codeSystem, codeVersion, "Bahrain", "BH", "BHR", "048", "ISO 3166-2:BH", "Asia", "Western Asia");
    public static readonly CountryCode Bangladesh = new CountryCode( "Bangladesh", codeSystem, codeVersion, "Bangladesh", "BD", "BGD", "050", "ISO 3166-2:BD", "Asia", "Southern Asia");
    public static readonly CountryCode Barbados = new CountryCode( "Barbados", codeSystem, codeVersion, "Barbados", "BB", "BRB", "052", "ISO 3166-2:BB", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Belarus = new CountryCode( "Belarus", codeSystem, codeVersion, "Belarus", "BY", "BLR", "112", "ISO 3166-2:BY", "Europe", "Eastern Europe");
    public static readonly CountryCode Belgium = new CountryCode( "Belgium", codeSystem, codeVersion, "Belgium", "BE", "BEL", "056", "ISO 3166-2:BE", "Europe", "Western Europe");
    public static readonly CountryCode Belize = new CountryCode( "Belize", codeSystem, codeVersion, "Belize", "BZ", "BLZ", "084", "ISO 3166-2:BZ", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Benin = new CountryCode( "Benin", codeSystem, codeVersion, "Benin", "BJ", "BEN", "204", "ISO 3166-2:BJ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Bermuda = new CountryCode( "Bermuda", codeSystem, codeVersion, "Bermuda", "BM", "BMU", "060", "ISO 3166-2:BM", "Americas", "Northern America");
    public static readonly CountryCode Bhutan = new CountryCode( "Bhutan", codeSystem, codeVersion, "Bhutan", "BT", "BTN", "064", "ISO 3166-2:BT", "Asia", "Southern Asia");
    public static readonly CountryCode Bolivia = new CountryCode( "Bolivia", codeSystem, codeVersion, "Bolivia,  Plurinational State of", "BO", "BOL", "068", "ISO 3166-2:BO", "Americas", "");
    public static readonly CountryCode Bonaire = new CountryCode( "Bonaire", codeSystem, codeVersion, "Bonaire,  Sint Eustatius and Saba", "BQ", "BES", "535", "ISO 3166-2:BQ", "Americas", "");
    public static readonly CountryCode BosniaandHerzegovina = new CountryCode( "BosniaandHerzegovina", codeSystem, codeVersion, "Bosnia and Herzegovina", "BA", "BIH", "070", "ISO 3166-2:BA", "Europe", "Southern Europe");
    public static readonly CountryCode Botswana = new CountryCode( "Botswana", codeSystem, codeVersion, "Botswana", "BW", "BWA", "072", "ISO 3166-2:BW", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode BouvetIsland = new CountryCode( "BouvetIsland", codeSystem, codeVersion, "Bouvet Island", "BV", "BVT", "074", "ISO 3166-2:BV", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Brazil = new CountryCode( "Brazil", codeSystem, codeVersion, "Brazil", "BR", "BRA", "076", "ISO 3166-2:BR", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode BritishIndianOceanTerritory = new CountryCode( "BritishIndianOceanTerritory", codeSystem, codeVersion, "British Indian Ocean Territory", "IO", "IOT", "086", "ISO 3166-2:IO", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode BruneiDarussalam = new CountryCode( "BruneiDarussalam", codeSystem, codeVersion, "Brunei Darussalam", "BN", "BRN", "096", "ISO 3166-2:BN", "Asia", "South-eastern Asia");
    public static readonly CountryCode Bulgaria = new CountryCode( "Bulgaria", codeSystem, codeVersion, "Bulgaria", "BG", "BGR", "100", "ISO 3166-2:BG", "Europe", "Eastern Europe");
    public static readonly CountryCode BurkinaFaso = new CountryCode( "BurkinaFaso", codeSystem, codeVersion, "Burkina Faso", "BF", "BFA", "854", "ISO 3166-2:BF", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Burundi = new CountryCode( "Burundi", codeSystem, codeVersion, "Burundi", "BI", "BDI", "108", "ISO 3166-2:BI", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode CaboVerde = new CountryCode( "CaboVerde", codeSystem, codeVersion, "Cabo Verde", "CV", "CPV", "132", "ISO 3166-2:CV", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Cambodia = new CountryCode( "Cambodia", codeSystem, codeVersion, "Cambodia", "KH", "KHM", "116", "ISO 3166-2:KH", "Asia", "South-eastern Asia");
    public static readonly CountryCode Cameroon = new CountryCode( "Cameroon", codeSystem, codeVersion, "Cameroon", "CM", "CMR", "120", "ISO 3166-2:CM", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Canada = new CountryCode( "Canada", codeSystem, codeVersion, "Canada", "CA", "CAN", "124", "ISO 3166-2:CA", "Americas", "Northern America");
    public static readonly CountryCode CaymanIslands = new CountryCode( "CaymanIslands", codeSystem, codeVersion, "Cayman Islands", "KY", "CYM", "136", "ISO 3166-2:KY", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode CentralAfricanRepublic = new CountryCode( "CentralAfricanRepublic", codeSystem, codeVersion, "Central African Republic", "CF", "CAF", "140", "ISO 3166-2:CF", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Chad = new CountryCode( "Chad", codeSystem, codeVersion, "Chad", "TD", "TCD", "148", "ISO 3166-2:TD", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Chile = new CountryCode( "Chile", codeSystem, codeVersion, "Chile", "CL", "CHL", "152", "ISO 3166-2:CL", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode China = new CountryCode( "China", codeSystem, codeVersion, "China", "CN", "CHN", "156", "ISO 3166-2:CN", "Asia", "Eastern Asia");
    public static readonly CountryCode ChristmasIsland = new CountryCode( "ChristmasIsland", codeSystem, codeVersion, "Christmas Island", "CX", "CXR", "162", "ISO 3166-2:CX", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode CocosKeelingIslands = new CountryCode( "CocosKeelingIslands", codeSystem, codeVersion, "Cocos (Keeling) Islands", "CC", "CCK", "166", "ISO 3166-2:CC", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode Colombia = new CountryCode( "Colombia", codeSystem, codeVersion, "Colombia", "CO", "COL", "170", "ISO 3166-2:CO", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Comoros = new CountryCode( "Comoros", codeSystem, codeVersion, "Comoros", "KM", "COM", "174", "ISO 3166-2:KM", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Congo = new CountryCode( "Congo", codeSystem, codeVersion, "Congo", "CG", "COG", "178", "ISO 3166-2:CG", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode CongoDR = new CountryCode( "CongoDR", codeSystem, codeVersion, "Congo,Democratic Republic of the", "CD", "COD", "180", "ISO 3166-2:CD", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode CookIslands = new CountryCode( "CookIslands", codeSystem, codeVersion, "Cook Islands", "CK", "COK", "184", "ISO 3166-2:CK", "Oceania", "Polynesia");
    public static readonly CountryCode CostaRica = new CountryCode( "CostaRica", codeSystem, codeVersion, "Costa Rica", "CR", "CRI", "188", "ISO 3166-2:CR", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode CtedIvoire = new CountryCode( "CtedIvoire", codeSystem, codeVersion, "Côte d'Ivoire", "CI", "CIV", "384", "ISO 3166-2:CI", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Croatia = new CountryCode( "Croatia", codeSystem, codeVersion, "Croatia", "HR", "HRV", "191", "ISO 3166-2:HR", "Europe", "Southern Europe");
    public static readonly CountryCode Cuba = new CountryCode( "Cuba", codeSystem, codeVersion, "Cuba", "CU", "CUB", "192", "ISO 3166-2:CU", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Curaao = new CountryCode( "Curaao", codeSystem, codeVersion, "Curaçao", "CW", "CUW", "531", "ISO 3166-2:CW", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Cyprus = new CountryCode( "Cyprus", codeSystem, codeVersion, "Cyprus", "CY", "CYP", "196", "ISO 3166-2:CY", "Asia", "Western Asia");
    public static readonly CountryCode Czechia = new CountryCode( "Czechia", codeSystem, codeVersion, "Czechia", "CZ", "CZE", "203", "ISO 3166-2:CZ", "Europe", "Eastern Europe");
    public static readonly CountryCode Denmark = new CountryCode( "Denmark", codeSystem, codeVersion, "Denmark", "DK", "DNK", "208", "ISO 3166-2:DK", "Europe", "Northern Europe");
    public static readonly CountryCode Djibouti = new CountryCode( "Djibouti", codeSystem, codeVersion, "Djibouti", "DJ", "DJI", "262", "ISO 3166-2:DJ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Dominica = new CountryCode( "Dominica", codeSystem, codeVersion, "Dominica", "DM", "DMA", "212", "ISO 3166-2:DM", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode DominicanRepublic = new CountryCode( "DominicanRepublic", codeSystem, codeVersion, "Dominican Republic", "DO", "DOM", "214", "ISO 3166-2:DO", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Ecuador = new CountryCode( "Ecuador", codeSystem, codeVersion, "Ecuador", "EC", "ECU", "218", "ISO 3166-2:EC", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Egypt = new CountryCode( "Egypt", codeSystem, codeVersion, "Egypt", "EG", "EGY", "818", "ISO 3166-2:EG", "Africa", "Northern Africa");
    public static readonly CountryCode ElSalvador = new CountryCode( "ElSalvador", codeSystem, codeVersion, "El Salvador", "SV", "SLV", "222", "ISO 3166-2:SV", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode EquatorialGuinea = new CountryCode( "EquatorialGuinea", codeSystem, codeVersion, "Equatorial Guinea", "GQ", "GNQ", "226", "ISO 3166-2:GQ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Eritrea = new CountryCode( "Eritrea", codeSystem, codeVersion, "Eritrea", "ER", "ERI", "232", "ISO 3166-2:ER", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Estonia = new CountryCode( "Estonia", codeSystem, codeVersion, "Estonia", "EE", "EST", "233", "ISO 3166-2:EE", "Europe", "Northern Europe");
    public static readonly CountryCode Eswatini = new CountryCode( "Eswatini", codeSystem, codeVersion, "Eswatini", "SZ", "SWZ", "748", "ISO 3166-2:SZ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Ethiopia = new CountryCode( "Ethiopia", codeSystem, codeVersion, "Ethiopia", "ET", "ETH", "231", "ISO 3166-2:ET", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode FalklandIslandsMalvinas = new CountryCode( "FalklandIslandsMalvinas", codeSystem, codeVersion, "Falkland Islands (Malvinas)", "FK", "FLK", "238", "ISO 3166-2:FK", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode FaroeIslands = new CountryCode( "FaroeIslands", codeSystem, codeVersion, "Faroe Islands", "FO", "FRO", "234", "ISO 3166-2:FO", "Europe", "Northern Europe");
    public static readonly CountryCode Fiji = new CountryCode( "Fiji", codeSystem, codeVersion, "Fiji", "FJ", "FJI", "242", "ISO 3166-2:FJ", "Oceania", "Melanesia");
    public static readonly CountryCode Finland = new CountryCode( "Finland", codeSystem, codeVersion, "Finland", "FI", "FIN", "246", "ISO 3166-2:FI", "Europe", "Northern Europe");
    public static readonly CountryCode France = new CountryCode( "France", codeSystem, codeVersion, "France", "FR", "FRA", "250", "ISO 3166-2:FR", "Europe", "Western Europe");
    public static readonly CountryCode FrenchGuiana = new CountryCode( "FrenchGuiana", codeSystem, codeVersion, "French Guiana", "GF", "GUF", "254", "ISO 3166-2:GF", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode FrenchPolynesia = new CountryCode( "FrenchPolynesia", codeSystem, codeVersion, "French Polynesia", "PF", "PYF", "258", "ISO 3166-2:PF", "Oceania", "Polynesia");
    public static readonly CountryCode FrenchSouthernTerritories = new CountryCode( "FrenchSouthernTerritories", codeSystem, codeVersion, "French Southern Territories", "TF", "ATF", "260", "ISO 3166-2:TF", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Gabon = new CountryCode( "Gabon", codeSystem, codeVersion, "Gabon", "GA", "GAB", "266", "ISO 3166-2:GA", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Gambia = new CountryCode( "Gambia", codeSystem, codeVersion, "Gambia", "GM", "GMB", "270", "ISO 3166-2:GM", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Georgia = new CountryCode( "Georgia", codeSystem, codeVersion, "Georgia", "GE", "GEO", "268", "ISO 3166-2:GE", "Asia", "Western Asia");
    public static readonly CountryCode Germany = new CountryCode( "Germany", codeSystem, codeVersion, "Germany", "DE", "DEU", "276", "ISO 3166-2:DE", "Europe", "Western Europe");
    public static readonly CountryCode Ghana = new CountryCode( "Ghana", codeSystem, codeVersion, "Ghana", "GH", "GHA", "288", "ISO 3166-2:GH", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Gibraltar = new CountryCode( "Gibraltar", codeSystem, codeVersion, "Gibraltar", "GI", "GIB", "292", "ISO 3166-2:GI", "Europe", "Southern Europe");
    public static readonly CountryCode Greece = new CountryCode( "Greece", codeSystem, codeVersion, "Greece", "GR", "GRC", "300", "ISO 3166-2:GR", "Europe", "Southern Europe");
    public static readonly CountryCode Greenland = new CountryCode( "Greenland", codeSystem, codeVersion, "Greenland", "GL", "GRL", "304", "ISO 3166-2:GL", "Americas", "Northern America");
    public static readonly CountryCode Grenada = new CountryCode( "Grenada", codeSystem, codeVersion, "Grenada", "GD", "GRD", "308", "ISO 3166-2:GD", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Guadeloupe = new CountryCode( "Guadeloupe", codeSystem, codeVersion, "Guadeloupe", "GP", "GLP", "312", "ISO 3166-2:GP", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Guam = new CountryCode( "Guam", codeSystem, codeVersion, "Guam", "GU", "GUM", "316", "ISO 3166-2:GU", "Oceania", "Micronesia");
    public static readonly CountryCode Guatemala = new CountryCode( "Guatemala", codeSystem, codeVersion, "Guatemala", "GT", "GTM", "320", "ISO 3166-2:GT", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Guernsey = new CountryCode( "Guernsey", codeSystem, codeVersion, "Guernsey", "GG", "GGY", "831", "ISO 3166-2:GG", "Europe", "Northern Europe");
    public static readonly CountryCode Guinea = new CountryCode( "Guinea", codeSystem, codeVersion, "Guinea", "GN", "GIN", "324", "ISO 3166-2:GN", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode GuineaBissau = new CountryCode( "GuineaBissau", codeSystem, codeVersion, "Guinea-Bissau", "GW", "GNB", "624", "ISO 3166-2:GW", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Guyana = new CountryCode( "Guyana", codeSystem, codeVersion, "Guyana", "GY", "GUY", "328", "ISO 3166-2:GY", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Haiti = new CountryCode( "Haiti", codeSystem, codeVersion, "Haiti", "HT", "HTI", "332", "ISO 3166-2:HT", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode HeardIslandandMcDonaldIslands = new CountryCode( "HeardIslandandMcDonaldIslands", codeSystem, codeVersion, "Heard Island and McDonald Islands", "HM", "HMD", "334", "ISO 3166-2:HM", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode HolySee = new CountryCode( "HolySee", codeSystem, codeVersion, "Holy See", "VA", "VAT", "336", "ISO 3166-2:VA", "Europe", "Southern Europe");
    public static readonly CountryCode Honduras = new CountryCode( "Honduras", codeSystem, codeVersion, "Honduras", "HN", "HND", "340", "ISO 3166-2:HN", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode HongKong = new CountryCode( "HongKong", codeSystem, codeVersion, "Hong Kong", "HK", "HKG", "344", "ISO 3166-2:HK", "Asia", "Eastern Asia");
    public static readonly CountryCode Hungary = new CountryCode( "Hungary", codeSystem, codeVersion, "Hungary", "HU", "HUN", "348", "ISO 3166-2:HU", "Europe", "Eastern Europe");
    public static readonly CountryCode Iceland = new CountryCode( "Iceland", codeSystem, codeVersion, "Iceland", "IS", "ISL", "352", "ISO 3166-2:IS", "Europe", "Northern Europe");
    public static readonly CountryCode India = new CountryCode( "India", codeSystem, codeVersion, "India", "IN", "IND", "356", "ISO 3166-2:IN", "Asia", "Southern Asia");
    public static readonly CountryCode Indonesia = new CountryCode( "Indonesia", codeSystem, codeVersion, "Indonesia", "ID", "IDN", "360", "ISO 3166-2:ID", "Asia", "South-eastern Asia");
    public static readonly CountryCode Iran = new CountryCode( "Iran", codeSystem, codeVersion, "Iran,  Islamic Republic of", "IR", "IRN", "364", "ISO 3166-2:IR", "Asia", "Southern Asia");
    public static readonly CountryCode Iraq = new CountryCode( "Iraq", codeSystem, codeVersion, "Iraq", "IQ", "IRQ", "368", "ISO 3166-2:IQ", "Asia", "Western Asia");
    public static readonly CountryCode Ireland = new CountryCode( "Ireland", codeSystem, codeVersion, "Ireland", "IE", "IRL", "372", "ISO 3166-2:IE", "Europe", "Northern Europe");
    public static readonly CountryCode IsleofMan = new CountryCode( "IsleofMan", codeSystem, codeVersion, "Isle of Man", "IM", "IMN", "833", "ISO 3166-2:IM", "Europe", "Northern Europe");
    public static readonly CountryCode Israel = new CountryCode( "Israel", codeSystem, codeVersion, "Israel", "IL", "ISR", "376", "ISO 3166-2:IL", "Asia", "Western Asia");
    public static readonly CountryCode Italy = new CountryCode( "Italy", codeSystem, codeVersion, "Italy", "IT", "ITA", "380", "ISO 3166-2:IT", "Europe", "Southern Europe");
    public static readonly CountryCode Jamaica = new CountryCode( "Jamaica", codeSystem, codeVersion, "Jamaica", "JM", "JAM", "388", "ISO 3166-2:JM", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Japan = new CountryCode( "Japan", codeSystem, codeVersion, "Japan", "JP", "JPN", "392", "ISO 3166-2:JP", "Asia", "Eastern Asia");
    public static readonly CountryCode Jersey = new CountryCode( "Jersey", codeSystem, codeVersion, "Jersey", "JE", "JEY", "832", "ISO 3166-2:JE", "Europe", "Northern Europe");
    public static readonly CountryCode Jordan = new CountryCode( "Jordan", codeSystem, codeVersion, "Jordan", "JO", "JOR", "400", "ISO 3166-2:JO", "Asia", "Western Asia");
    public static readonly CountryCode Kazakhstan = new CountryCode( "Kazakhstan", codeSystem, codeVersion, "Kazakhstan", "KZ", "KAZ", "398", "ISO 3166-2:KZ", "Asia", "Central Asia");
    public static readonly CountryCode Kenya = new CountryCode( "Kenya", codeSystem, codeVersion, "Kenya", "KE", "KEN", "404", "ISO 3166-2:KE", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Kiribati = new CountryCode( "Kiribati", codeSystem, codeVersion, "Kiribati", "KI", "KIR", "296", "ISO 3166-2:KI", "Oceania", "Micronesia");
    public static readonly CountryCode KoreaDPR = new CountryCode( "Korea", codeSystem, codeVersion, "Korea,  Democratic People's Republic of", "KP", "PRK", "408", "ISO 3166-2:KP", "Asia", "Eastern Asia");
    public static readonly CountryCode KoreaR = new CountryCode( "Korea", codeSystem, codeVersion, "Korea,  Republic of", "KR", "KOR", "410", "ISO 3166-2:KR", "Asia", "East Asia");
    public static readonly CountryCode Kuwait = new CountryCode( "Kuwait", codeSystem, codeVersion, "Kuwait", "KW", "KWT", "414", "ISO 3166-2:KW", "Asia", "Western Asia");
    public static readonly CountryCode Kyrgyzstan = new CountryCode( "Kyrgyzstan", codeSystem, codeVersion, "Kyrgyzstan", "KG", "KGZ", "417", "ISO 3166-2:KG", "Asia", "Central Asia");
    public static readonly CountryCode LaoPeoplesDemocraticRepublic = new CountryCode( "LaoPeoplesDemocraticRepublic", codeSystem, codeVersion, "Lao People's Democratic Republic", "LA", "LAO", "418", "ISO 3166-2:LA", "Asia", "South-eastern Asia");
    public static readonly CountryCode Latvia = new CountryCode( "Latvia", codeSystem, codeVersion, "Latvia", "LV", "LVA", "428", "ISO 3166-2:LV", "Europe", "Northern Europe");
    public static readonly CountryCode Lebanon = new CountryCode( "Lebanon", codeSystem, codeVersion, "Lebanon", "LB", "LBN", "422", "ISO 3166-2:LB", "Asia", "Western Asia");
    public static readonly CountryCode Lesotho = new CountryCode( "Lesotho", codeSystem, codeVersion, "Lesotho", "LS", "LSO", "426", "ISO 3166-2:LS", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Liberia = new CountryCode( "Liberia", codeSystem, codeVersion, "Liberia", "LR", "LBR", "430", "ISO 3166-2:LR", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Libya = new CountryCode( "Libya", codeSystem, codeVersion, "Libya", "LY", "LBY", "434", "ISO 3166-2:LY", "Africa", "Northern Africa");
    public static readonly CountryCode Liechtenstein = new CountryCode( "Liechtenstein", codeSystem, codeVersion, "Liechtenstein", "LI", "LIE", "438", "ISO 3166-2:LI", "Europe", "Western Europe");
    public static readonly CountryCode Lithuania = new CountryCode( "Lithuania", codeSystem, codeVersion, "Lithuania", "LT", "LTU", "440", "ISO 3166-2:LT", "Europe", "Northern Europe");
    public static readonly CountryCode Luxembourg = new CountryCode( "Luxembourg", codeSystem, codeVersion, "Luxembourg", "LU", "LUX", "442", "ISO 3166-2:LU", "Europe", "Western Europe");
    public static readonly CountryCode Macao = new CountryCode( "Macao", codeSystem, codeVersion, "Macao", "MO", "MAC", "446", "ISO 3166-2:MO", "Asia", "Eastern Asia");
    public static readonly CountryCode Madagascar = new CountryCode( "Madagascar", codeSystem, codeVersion, "Madagascar", "MG", "MDG", "450", "ISO 3166-2:MG", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Malawi = new CountryCode( "Malawi", codeSystem, codeVersion, "Malawi", "MW", "MWI", "454", "ISO 3166-2:MW", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Malaysia = new CountryCode( "Malaysia", codeSystem, codeVersion, "Malaysia", "MY", "MYS", "458", "ISO 3166-2:MY", "Asia", "South-eastern Asia");
    public static readonly CountryCode Maldives = new CountryCode( "Maldives", codeSystem, codeVersion, "Maldives", "MV", "MDV", "462", "ISO 3166-2:MV", "Asia", "Southern Asia");
    public static readonly CountryCode Mali = new CountryCode( "Mali", codeSystem, codeVersion, "Mali", "ML", "MLI", "466", "ISO 3166-2:ML", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Malta = new CountryCode( "Malta", codeSystem, codeVersion, "Malta", "MT", "MLT", "470", "ISO 3166-2:MT", "Europe", "Southern Europe");
    public static readonly CountryCode MarshallIslands = new CountryCode( "MarshallIslands", codeSystem, codeVersion, "Marshall Islands", "MH", "MHL", "584", "ISO 3166-2:MH", "Oceania", "Micronesia");
    public static readonly CountryCode Martinique = new CountryCode( "Martinique", codeSystem, codeVersion, "Martinique", "MQ", "MTQ", "474", "ISO 3166-2:MQ", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Mauritania = new CountryCode( "Mauritania", codeSystem, codeVersion, "Mauritania", "MR", "MRT", "478", "ISO 3166-2:MR", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Mauritius = new CountryCode( "Mauritius", codeSystem, codeVersion, "Mauritius", "MU", "MUS", "480", "ISO 3166-2:MU", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Mayotte = new CountryCode( "Mayotte", codeSystem, codeVersion, "Mayotte", "YT", "MYT", "175", "ISO 3166-2:YT", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Mexico = new CountryCode( "Mexico", codeSystem, codeVersion, "Mexico", "MX", "MEX", "484", "ISO 3166-2:MX", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Micronesia = new CountryCode( "Micronesia", codeSystem, codeVersion, "Micronesia,  Federated States of", "FM", "FSM", "583", "ISO 3166-2:FM", "Oceania", "Micronesia");
    public static readonly CountryCode Moldova = new CountryCode( "Moldova", codeSystem, codeVersion, "Moldova,  Republic of", "MD", "MDA", "498", "ISO 3166-2:MD", "Europe", "Eastern Europe");
    public static readonly CountryCode Monaco = new CountryCode( "Monaco", codeSystem, codeVersion, "Monaco", "MC", "MCO", "492", "ISO 3166-2:MC", "Europe", "Western Europe");
    public static readonly CountryCode Mongolia = new CountryCode( "Mongolia", codeSystem, codeVersion, "Mongolia", "MN", "MNG", "496", "ISO 3166-2:MN", "Asia", "Eastern Asia");
    public static readonly CountryCode Montenegro = new CountryCode( "Montenegro", codeSystem, codeVersion, "Montenegro", "ME", "MNE", "499", "ISO 3166-2:ME", "Europe", "Southern Europe");
    public static readonly CountryCode Montserrat = new CountryCode( "Montserrat", codeSystem, codeVersion, "Montserrat", "MS", "MSR", "500", "ISO 3166-2:MS", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Morocco = new CountryCode( "Morocco", codeSystem, codeVersion, "Morocco", "MA", "MAR", "504", "ISO 3166-2:MA", "Africa", "Northern Africa");
    public static readonly CountryCode Mozambique = new CountryCode( "Mozambique", codeSystem, codeVersion, "Mozambique", "MZ", "MOZ", "508", "ISO 3166-2:MZ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Myanmar = new CountryCode( "Myanmar", codeSystem, codeVersion, "Myanmar", "MM", "MMR", "104", "ISO 3166-2:MM", "Asia", "South-eastern Asia");
    public static readonly CountryCode Namibia = new CountryCode( "Namibia", codeSystem, codeVersion, "Namibia", "NA", "NAM", "516", "ISO 3166-2:NA", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Nauru = new CountryCode( "Nauru", codeSystem, codeVersion, "Nauru", "NR", "NRU", "520", "ISO 3166-2:NR", "Oceania", "Micronesia");
    public static readonly CountryCode Nepal = new CountryCode( "Nepal", codeSystem, codeVersion, "Nepal", "NP", "NPL", "524", "ISO 3166-2:NP", "Asia", "Southern Asia");
    public static readonly CountryCode Netherlands = new CountryCode( "Netherlands", codeSystem, codeVersion, "Netherlands,  Kingdom of the", "NL", "NLD", "528", "ISO 3166-2:NL", "Europe", "Western Europe");
    public static readonly CountryCode NewCaledonia = new CountryCode( "NewCaledonia", codeSystem, codeVersion, "New Caledonia", "NC", "NCL", "540", "ISO 3166-2:NC", "Oceania", "Melanesia");
    public static readonly CountryCode NewZealand = new CountryCode( "NewZealand", codeSystem, codeVersion, "New Zealand", "NZ", "NZL", "554", "ISO 3166-2:NZ", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode Nicaragua = new CountryCode( "Nicaragua", codeSystem, codeVersion, "Nicaragua", "NI", "NIC", "558", "ISO 3166-2:NI", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Niger = new CountryCode( "Niger", codeSystem, codeVersion, "Niger", "NE", "NER", "562", "ISO 3166-2:NE", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Nigeria = new CountryCode( "Nigeria", codeSystem, codeVersion, "Nigeria", "NG", "NGA", "566", "ISO 3166-2:NG", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Niue = new CountryCode( "Niue", codeSystem, codeVersion, "Niue", "NU", "NIU", "570", "ISO 3166-2:NU", "Oceania", "Polynesia");
    public static readonly CountryCode NorfolkIsland = new CountryCode( "NorfolkIsland", codeSystem, codeVersion, "Norfolk Island", "NF", "NFK", "574", "ISO 3166-2:NF", "Oceania", "Australia and New Zealand");
    public static readonly CountryCode NorthMacedonia = new CountryCode( "NorthMacedonia", codeSystem, codeVersion, "North Macedonia", "MK", "MKD", "807", "ISO 3166-2:MK", "Europe", "Southern Europe");
    public static readonly CountryCode NorthernMarianaIslands = new CountryCode( "NorthernMarianaIslands", codeSystem, codeVersion, "Northern Mariana Islands", "MP", "MNP", "580", "ISO 3166-2:MP", "Oceania", "Micronesia");
    public static readonly CountryCode Norway = new CountryCode( "Norway", codeSystem, codeVersion, "Norway", "NO", "NOR", "578", "ISO 3166-2:NO", "Europe", "Northern Europe");
    public static readonly CountryCode Oman = new CountryCode( "Oman", codeSystem, codeVersion, "Oman", "OM", "OMN", "512", "ISO 3166-2:OM", "Asia", "Western Asia");
    public static readonly CountryCode Pakistan = new CountryCode( "Pakistan", codeSystem, codeVersion, "Pakistan", "PK", "PAK", "586", "ISO 3166-2:PK", "Asia", "Southern Asia");
    public static readonly CountryCode Palau = new CountryCode( "Palau", codeSystem, codeVersion, "Palau", "PW", "PLW", "585", "ISO 3166-2:PW", "Oceania", "Micronesia");
    public static readonly CountryCode Palestine = new CountryCode( "Palestine", codeSystem, codeVersion, "Palestine,  State of", "PS", "PSE", "275", "ISO 3166-2:PS", "Asia", "Western Asia");
    public static readonly CountryCode Panama = new CountryCode( "Panama", codeSystem, codeVersion, "Panama", "PA", "PAN", "591", "ISO 3166-2:PA", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode PapuaNewGuinea = new CountryCode( "PapuaNewGuinea", codeSystem, codeVersion, "Papua New Guinea", "PG", "PNG", "598", "ISO 3166-2:PG", "Oceania", "Melanesia");
    public static readonly CountryCode Paraguay = new CountryCode( "Paraguay", codeSystem, codeVersion, "Paraguay", "PY", "PRY", "600", "ISO 3166-2:PY", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Peru = new CountryCode( "Peru", codeSystem, codeVersion, "Peru", "PE", "PER", "604", "ISO 3166-2:PE", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Philippines = new CountryCode( "Philippines", codeSystem, codeVersion, "Philippines", "PH", "PHL", "608", "ISO 3166-2:PH", "Asia", "South-eastern Asia");
    public static readonly CountryCode Pitcairn = new CountryCode( "Pitcairn", codeSystem, codeVersion, "Pitcairn", "PN", "PCN", "612", "ISO 3166-2:PN", "Oceania", "Polynesia");
    public static readonly CountryCode Poland = new CountryCode( "Poland", codeSystem, codeVersion, "Poland", "PL", "POL", "616", "ISO 3166-2:PL", "Europe", "Eastern Europe");
    public static readonly CountryCode Portugal = new CountryCode( "Portugal", codeSystem, codeVersion, "Portugal", "PT", "PRT", "620", "ISO 3166-2:PT", "Europe", "Southern Europe");
    public static readonly CountryCode PuertoRico = new CountryCode( "PuertoRico", codeSystem, codeVersion, "Puerto Rico", "PR", "PRI", "630", "ISO 3166-2:PR", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Qatar = new CountryCode( "Qatar", codeSystem, codeVersion, "Qatar", "QA", "QAT", "634", "ISO 3166-2:QA", "Asia", "Western Asia");
    public static readonly CountryCode Runion = new CountryCode( "Runion", codeSystem, codeVersion, "Réunion", "RE", "REU", "638", "ISO 3166-2:RE", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Romania = new CountryCode( "Romania", codeSystem, codeVersion, "Romania", "RO", "ROU", "642", "ISO 3166-2:RO", "Europe", "Eastern Europe");
    public static readonly CountryCode RussianFederation = new CountryCode( "RussianFederation", codeSystem, codeVersion, "Russian Federation", "RU", "RUS", "643", "ISO 3166-2:RU", "Europe", "Eastern Europe");
    public static readonly CountryCode Rwanda = new CountryCode( "Rwanda", codeSystem, codeVersion, "Rwanda", "RW", "RWA", "646", "ISO 3166-2:RW", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SaintBarthlemy = new CountryCode( "SaintBarthlemy", codeSystem, codeVersion, "Saint Barthélemy", "BL", "BLM", "652", "ISO 3166-2:BL", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SaintHelena = new CountryCode( "SaintHelena", codeSystem, codeVersion, "Saint Helena,  Ascension and Tristan da Cunha", "SH", "SHN", "654", "ISO 3166-2:SH", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SaintKittsandNevis = new CountryCode( "SaintKittsandNevis", codeSystem, codeVersion, "Saint Kitts and Nevis", "KN", "KNA", "659", "ISO 3166-2:KN", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SaintLucia = new CountryCode( "SaintLucia", codeSystem, codeVersion, "Saint Lucia", "LC", "LCA", "662", "ISO 3166-2:LC", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SaintMartinFrenchpart = new CountryCode( "SaintMartinFrenchpart", codeSystem, codeVersion, "Saint Martin (French part)", "MF", "MAF", "663", "ISO 3166-2:MF", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SaintPierreandMiquelon = new CountryCode( "SaintPierreandMiquelon", codeSystem, codeVersion, "Saint Pierre and Miquelon", "PM", "SPM", "666", "ISO 3166-2:PM", "Americas", "Northern America");
    public static readonly CountryCode SaintVincentandtheGrenadines = new CountryCode( "SaintVincentandtheGrenadines", codeSystem, codeVersion, "Saint Vincent and the Grenadines", "VC", "VCT", "670", "ISO 3166-2:VC", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Samoa = new CountryCode( "Samoa", codeSystem, codeVersion, "Samoa", "WS", "WSM", "882", "ISO 3166-2:WS", "Oceania", "Polynesia");
    public static readonly CountryCode SanMarino = new CountryCode( "SanMarino", codeSystem, codeVersion, "San Marino", "SM", "SMR", "674", "ISO 3166-2:SM", "Europe", "Southern Europe");
    public static readonly CountryCode SaoTomeandPrincipe = new CountryCode( "SaoTomeandPrincipe", codeSystem, codeVersion, "Sao Tome and Principe", "ST", "STP", "678", "ISO 3166-2:ST", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SaudiArabia = new CountryCode( "SaudiArabia", codeSystem, codeVersion, "Saudi Arabia", "SA", "SAU", "682", "ISO 3166-2:SA", "Asia", "Western Asia");
    public static readonly CountryCode Senegal = new CountryCode( "Senegal", codeSystem, codeVersion, "Senegal", "SN", "SEN", "686", "ISO 3166-2:SN", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Serbia = new CountryCode( "Serbia", codeSystem, codeVersion, "Serbia", "RS", "SRB", "688", "ISO 3166-2:RS", "Europe", "Southern Europe");
    public static readonly CountryCode Seychelles = new CountryCode( "Seychelles", codeSystem, codeVersion, "Seychelles", "SC", "SYC", "690", "ISO 3166-2:SC", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SierraLeone = new CountryCode( "SierraLeone", codeSystem, codeVersion, "Sierra Leone", "SL", "SLE", "694", "ISO 3166-2:SL", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Singapore = new CountryCode( "Singapore", codeSystem, codeVersion, "Singapore", "SG", "SGP", "702", "ISO 3166-2:SG", "Asia", "South-eastern Asia");
    public static readonly CountryCode SintMaartenDutchpart = new CountryCode( "SintMaartenDutchpart", codeSystem, codeVersion, "Sint Maarten (Dutch part)", "SX", "SXM", "534", "ISO 3166-2:SX", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Slovakia = new CountryCode( "Slovakia", codeSystem, codeVersion, "Slovakia", "SK", "SVK", "703", "ISO 3166-2:SK", "Europe", "Eastern Europe");
    public static readonly CountryCode Slovenia = new CountryCode( "Slovenia", codeSystem, codeVersion, "Slovenia", "SI", "SVN", "705", "ISO 3166-2:SI", "Europe", "Southern Europe");
    public static readonly CountryCode SolomonIslands = new CountryCode( "SolomonIslands", codeSystem, codeVersion, "Solomon Islands", "SB", "SLB", "090", "ISO 3166-2:SB", "Oceania", "Melanesia");
    public static readonly CountryCode Somalia = new CountryCode( "Somalia", codeSystem, codeVersion, "Somalia", "SO", "SOM", "706", "ISO 3166-2:SO", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SouthAfrica = new CountryCode( "SouthAfrica", codeSystem, codeVersion, "South Africa", "ZA", "ZAF", "710", "ISO 3166-2:ZA", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode SouthGeorgiaandtheSouthSandwichIslands = new CountryCode( "SouthGeorgiaandtheSouthSandwichIslands", codeSystem, codeVersion, "South Georgia and the South Sandwich Islands", "GS", "SGS", "239", "ISO 3166-2:GS", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SouthSudan = new CountryCode( "SouthSudan", codeSystem, codeVersion, "South Sudan", "SS", "SSD", "728", "ISO 3166-2:SS", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Spain = new CountryCode( "Spain", codeSystem, codeVersion, "Spain", "ES", "ESP", "724", "ISO 3166-2:ES", "Europe", "Southern Europe");
    public static readonly CountryCode SriLanka = new CountryCode( "SriLanka", codeSystem, codeVersion, "Sri Lanka", "LK", "LKA", "144", "ISO 3166-2:LK", "Asia", "Southern Asia");
    public static readonly CountryCode Sudan = new CountryCode( "Sudan", codeSystem, codeVersion, "Sudan", "SD", "SDN", "729", "ISO 3166-2:SD", "Africa", "Northern Africa");
    public static readonly CountryCode Suriname = new CountryCode( "Suriname", codeSystem, codeVersion, "Suriname", "SR", "SUR", "740", "ISO 3166-2:SR", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode SvalbardandJanMayen = new CountryCode( "SvalbardandJanMayen", codeSystem, codeVersion, "Svalbard and Jan Mayen", "SJ", "SJM", "744", "ISO 3166-2:SJ", "Europe", "Northern Europe");
    public static readonly CountryCode Sweden = new CountryCode( "Sweden", codeSystem, codeVersion, "Sweden", "SE", "SWE", "752", "ISO 3166-2:SE", "Europe", "Northern Europe");
    public static readonly CountryCode Switzerland = new CountryCode( "Switzerland", codeSystem, codeVersion, "Switzerland", "CH", "CHE", "756", "ISO 3166-2:CH", "Europe", "Western Europe");
    public static readonly CountryCode SyrianArabRepublic = new CountryCode( "SyrianArabRepublic", codeSystem, codeVersion, "Syrian Arab Republic", "SY", "SYR", "760", "ISO 3166-2:SY", "Asia", "Western Asia");
    public static readonly CountryCode Taiwan = new CountryCode( "Taiwan", codeSystem, codeVersion, "Taiwan,  Province of China", "TW", "TWN", "158", "ISO 3166-2:TW", "TWN", "");
    public static readonly CountryCode Tajikistan = new CountryCode( "Tajikistan", codeSystem, codeVersion, "Tajikistan", "TJ", "TJK", "762", "ISO 3166-2:TJ", "Asia", "Central Asia");
    public static readonly CountryCode Tanzania = new CountryCode( "Tanzania", codeSystem, codeVersion, "Tanzania,  United Republic of", "TZ", "TZA", "834", "ISO 3166-2:TZ", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Thailand = new CountryCode( "Thailand", codeSystem, codeVersion, "Thailand", "TH", "THA", "764", "ISO 3166-2:TH", "Asia", "South-eastern Asia");
    public static readonly CountryCode TimorLeste = new CountryCode( "TimorLeste", codeSystem, codeVersion, "Timor-Leste", "TL", "TLS", "626", "ISO 3166-2:TL", "Asia", "South-eastern Asia");
    public static readonly CountryCode Togo = new CountryCode( "Togo", codeSystem, codeVersion, "Togo", "TG", "TGO", "768", "ISO 3166-2:TG", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Tokelau = new CountryCode( "Tokelau", codeSystem, codeVersion, "Tokelau", "TK", "TKL", "772", "ISO 3166-2:TK", "Oceania", "Polynesia");
    public static readonly CountryCode Tonga = new CountryCode( "Tonga", codeSystem, codeVersion, "Tonga", "TO", "TON", "776", "ISO 3166-2:TO", "Oceania", "Polynesia");
    public static readonly CountryCode TrinidadandTobago = new CountryCode( "TrinidadandTobago", codeSystem, codeVersion, "Trinidad and Tobago", "TT", "TTO", "780", "ISO 3166-2:TT", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Tunisia = new CountryCode( "Tunisia", codeSystem, codeVersion, "Tunisia", "TN", "TUN", "788", "ISO 3166-2:TN", "Africa", "Northern Africa");
    public static readonly CountryCode Trkiye = new CountryCode( "Trkiye", codeSystem, codeVersion, "Türkiye", "TR", "TUR", "792", "ISO 3166-2:TR", "Asia", "Western Asia");
    public static readonly CountryCode Turkmenistan = new CountryCode( "Turkmenistan", codeSystem, codeVersion, "Turkmenistan", "TM", "TKM", "795", "ISO 3166-2:TM", "Asia", "Central Asia");
    public static readonly CountryCode TurksandCaicosIslands = new CountryCode( "TurksandCaicosIslands", codeSystem, codeVersion, "Turks and Caicos Islands", "TC", "TCA", "796", "ISO 3166-2:TC", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Tuvalu = new CountryCode( "Tuvalu", codeSystem, codeVersion, "Tuvalu", "TV", "TUV", "798", "ISO 3166-2:TV", "Oceania", "Polynesia");
    public static readonly CountryCode Uganda = new CountryCode( "Uganda", codeSystem, codeVersion, "Uganda", "UG", "UGA", "800", "ISO 3166-2:UG", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Ukraine = new CountryCode( "Ukraine", codeSystem, codeVersion, "Ukraine", "UA", "UKR", "804", "ISO 3166-2:UA", "Europe", "Eastern Europe");
    public static readonly CountryCode UnitedArabEmirates = new CountryCode( "UnitedArabEmirates", codeSystem, codeVersion, "United Arab Emirates", "AE", "ARE", "784", "ISO 3166-2:AE", "Asia", "Western Asia");
    public static readonly CountryCode UnitedKingdomofGreatBritainandNorthernIreland = new CountryCode( "UnitedKingdomofGreatBritainandNorthernIreland", codeSystem, codeVersion, "United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", "826", "ISO 3166-2:GB", "Europe", "Northern Europe");
    public static readonly CountryCode UnitedStatesofAmerica = new CountryCode( "UnitedStatesofAmerica", codeSystem, codeVersion, "United States of America", "US", "USA", "840", "ISO 3166-2:US", "Americas", "Northern America");
    public static readonly CountryCode UnitedStatesMinorOutlyingIslands = new CountryCode( "UnitedStatesMinorOutlyingIslands", codeSystem, codeVersion, "United States Minor Outlying Islands", "UM", "UMI", "581", "ISO 3166-2:UM", "Oceania", "Micronesia");
    public static readonly CountryCode Uruguay = new CountryCode( "Uruguay", codeSystem, codeVersion, "Uruguay", "UY", "URY", "858", "ISO 3166-2:UY", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode Uzbekistan = new CountryCode( "Uzbekistan", codeSystem, codeVersion, "Uzbekistan", "UZ", "UZB", "860", "ISO 3166-2:UZ", "Asia", "Central Asia");
    public static readonly CountryCode Vanuatu = new CountryCode( "Vanuatu", codeSystem, codeVersion, "Vanuatu", "VU", "VUT", "548", "ISO 3166-2:VU", "Oceania", "Melanesia");
    public static readonly CountryCode Venezuela = new CountryCode( "Venezuela", codeSystem, codeVersion, "Venezuela,  Bolivarian Republic of", "VE", "VEN", "862", "ISO 3166-2:VE", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode VietNam = new CountryCode( "VietNam", codeSystem, codeVersion, "Viet Nam", "VN", "VNM", "704", "ISO 3166-2:VN", "Asia", "South-eastern Asia");
    public static readonly CountryCode VirginIslandsBritish = new CountryCode( "VirginIslandsBritish", codeSystem, codeVersion, "Virgin Islands (British)", "VG", "VGB", "092", "ISO 3166-2:VG", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode VirginIslandsUS = new CountryCode( "VirginIslandsUS", codeSystem, codeVersion, "Virgin Islands (U.S.)", "VI", "VIR", "850", "ISO 3166-2:VI", "Americas", "Latin America and the Caribbean");
    public static readonly CountryCode WallisandFutuna = new CountryCode( "WallisandFutuna", codeSystem, codeVersion, "Wallis and Futuna", "WF", "WLF", "876", "ISO 3166-2:WF", "Oceania", "Polynesia");
    public static readonly CountryCode WesternSahara = new CountryCode( "WesternSahara", codeSystem, codeVersion, "Western Sahara", "EH", "ESH", "732", "ISO 3166-2:EH", "Africa", "Northern Africa");
    public static readonly CountryCode Yemen = new CountryCode( "Yemen", codeSystem, codeVersion, "Yemen", "YE", "YEM", "887", "ISO 3166-2:YE", "Asia", "Western Asia");
    public static readonly CountryCode Zambia = new CountryCode( "Zambia", codeSystem, codeVersion, "Zambia", "ZM", "ZMB", "894", "ISO 3166-2:ZM", "Africa", "Sub-Saharan Africa");
    public static readonly CountryCode Zimbabwe = new CountryCode( "Zimbabwe", codeSystem, codeVersion, "Zimbabwe", "ZW", "ZWE", "716", "ISO 3166-2:ZW", "Africa", "Sub-Saharan Africa");

    private CountryCode(string freeText)
    {
        Text = freeText;
    }
    
    private CountryCode(string condensedName, string codeSystem, string codeVersion, string countryName, string shortCode, string longCode, string numericCode, string isoCode, string region, string subRegion)
    {
        Code = shortCode;
        LongCode = longCode;
        Text = countryName;
        CodeSystem = codeSystem;
        CodeVersion = codeVersion;
        NumericCountryCode = numericCode;
        CondensedName = condensedName;
        CountryName = countryName;
        IsoCountryCode = isoCode;
        Region = region;
        SubRegion = subRegion;
    }

    private static IEnumerable<CountryCode> CountryCodes
    {
        get
        {
            yield return Afghanistan;
            yield return landIslands;
            yield return Albania;
            yield return Algeria;
            yield return AmericanSamoa;
            yield return Andorra;
            yield return Angola;
            yield return Anguilla;
            yield return Antarctica;
            yield return AntiguaandBarbuda;
            yield return Argentina;
            yield return Armenia;
            yield return Aruba;
            yield return Australia;
            yield return Austria;
            yield return Azerbaijan;
            yield return Bahamas;
            yield return Bahrain;
            yield return Bangladesh;
            yield return Barbados;
            yield return Belarus;
            yield return Belgium;
            yield return Belize;
            yield return Benin;
            yield return Bermuda;
            yield return Bhutan;
            yield return Bolivia;
            yield return Bonaire;
            yield return BosniaandHerzegovina;
            yield return Botswana;
            yield return BouvetIsland;
            yield return Brazil;
            yield return BritishIndianOceanTerritory;
            yield return BruneiDarussalam;
            yield return Bulgaria;
            yield return BurkinaFaso;
            yield return Burundi;
            yield return CaboVerde;
            yield return Cambodia;
            yield return Cameroon;
            yield return Canada;
            yield return CaymanIslands;
            yield return CentralAfricanRepublic;
            yield return Chad;
            yield return Chile;
            yield return China;
            yield return ChristmasIsland;
            yield return CocosKeelingIslands;
            yield return Colombia;
            yield return Comoros;
            yield return Congo;
            yield return CongoDR;
            yield return CookIslands;
            yield return CostaRica;
            yield return CtedIvoire;
            yield return Croatia;
            yield return Cuba;
            yield return Curaao;
            yield return Cyprus;
            yield return Czechia;
            yield return Denmark;
            yield return Djibouti;
            yield return Dominica;
            yield return DominicanRepublic;
            yield return Ecuador;
            yield return Egypt;
            yield return ElSalvador;
            yield return EquatorialGuinea;
            yield return Eritrea;
            yield return Estonia;
            yield return Eswatini;
            yield return Ethiopia;
            yield return FalklandIslandsMalvinas;
            yield return FaroeIslands;
            yield return Fiji;
            yield return Finland;
            yield return France;
            yield return FrenchGuiana;
            yield return FrenchPolynesia;
            yield return FrenchSouthernTerritories;
            yield return Gabon;
            yield return Gambia;
            yield return Georgia;
            yield return Germany;
            yield return Ghana;
            yield return Gibraltar;
            yield return Greece;
            yield return Greenland;
            yield return Grenada;
            yield return Guadeloupe;
            yield return Guam;
            yield return Guatemala;
            yield return Guernsey;
            yield return Guinea;
            yield return GuineaBissau;
            yield return Guyana;
            yield return Haiti;
            yield return HeardIslandandMcDonaldIslands;
            yield return HolySee;
            yield return Honduras;
            yield return HongKong;
            yield return Hungary;
            yield return Iceland;
            yield return India;
            yield return Indonesia;
            yield return Iran;
            yield return Iraq;
            yield return Ireland;
            yield return IsleofMan;
            yield return Israel;
            yield return Italy;
            yield return Jamaica;
            yield return Japan;
            yield return Jersey;
            yield return Jordan;
            yield return Kazakhstan;
            yield return Kenya;
            yield return Kiribati;
            yield return KoreaDPR;
            yield return KoreaR;
            yield return Kuwait;
            yield return Kyrgyzstan;
            yield return LaoPeoplesDemocraticRepublic;
            yield return Latvia;
            yield return Lebanon;
            yield return Lesotho;
            yield return Liberia;
            yield return Libya;
            yield return Liechtenstein;
            yield return Lithuania;
            yield return Luxembourg;
            yield return Macao;
            yield return Madagascar;
            yield return Malawi;
            yield return Malaysia;
            yield return Maldives;
            yield return Mali;
            yield return Malta;
            yield return MarshallIslands;
            yield return Martinique;
            yield return Mauritania;
            yield return Mauritius;
            yield return Mayotte;
            yield return Mexico;
            yield return Micronesia;
            yield return Moldova;
            yield return Monaco;
            yield return Mongolia;
            yield return Montenegro;
            yield return Montserrat;
            yield return Morocco;
            yield return Mozambique;
            yield return Myanmar;
            yield return Namibia;
            yield return Nauru;
            yield return Nepal;
            yield return Netherlands;
            yield return NewCaledonia;
            yield return NewZealand;
            yield return Nicaragua;
            yield return Niger;
            yield return Nigeria;
            yield return Niue;
            yield return NorfolkIsland;
            yield return NorthMacedonia;
            yield return NorthernMarianaIslands;
            yield return Norway;
            yield return Oman;
            yield return Pakistan;
            yield return Palau;
            yield return Palestine;
            yield return Panama;
            yield return PapuaNewGuinea;
            yield return Paraguay;
            yield return Peru;
            yield return Philippines;
            yield return Pitcairn;
            yield return Poland;
            yield return Portugal;
            yield return PuertoRico;
            yield return Qatar;
            yield return Runion;
            yield return Romania;
            yield return RussianFederation;
            yield return Rwanda;
            yield return SaintBarthlemy;
            yield return SaintHelena;
            yield return SaintKittsandNevis;
            yield return SaintLucia;
            yield return SaintMartinFrenchpart;
            yield return SaintPierreandMiquelon;
            yield return SaintVincentandtheGrenadines;
            yield return Samoa;
            yield return SanMarino;
            yield return SaoTomeandPrincipe;
            yield return SaudiArabia;
            yield return Senegal;
            yield return Serbia;
            yield return Seychelles;
            yield return SierraLeone;
            yield return Singapore;
            yield return SintMaartenDutchpart;
            yield return Slovakia;
            yield return Slovenia;
            yield return SolomonIslands;
            yield return Somalia;
            yield return SouthAfrica;
            yield return SouthGeorgiaandtheSouthSandwichIslands;
            yield return SouthSudan;
            yield return Spain;
            yield return SriLanka;
            yield return Sudan;
            yield return Suriname;
            yield return SvalbardandJanMayen;
            yield return Sweden;
            yield return Switzerland;
            yield return SyrianArabRepublic;
            yield return Taiwan;
            yield return Tajikistan;
            yield return Tanzania;
            yield return Thailand;
            yield return TimorLeste;
            yield return Togo;
            yield return Tokelau;
            yield return Tonga;
            yield return TrinidadandTobago;
            yield return Tunisia;
            yield return Trkiye;
            yield return Turkmenistan;
            yield return TurksandCaicosIslands;
            yield return Tuvalu;
            yield return Uganda;
            yield return Ukraine;
            yield return UnitedArabEmirates;
            yield return UnitedKingdomofGreatBritainandNorthernIreland;
            yield return UnitedStatesofAmerica;
            yield return UnitedStatesMinorOutlyingIslands;
            yield return Uruguay;
            yield return Uzbekistan;
            yield return Vanuatu;
            yield return Venezuela;
            yield return VietNam;
            yield return VirginIslandsBritish;
            yield return VirginIslandsUS;
            yield return WallisandFutuna;
            yield return WesternSahara;
            yield return Yemen;
            yield return Zambia;
            yield return Zimbabwe;
        }
    }

    private static CountryCode From(string code)
    {
        foreach(CountryCode directionType in CountryCodes )

            if (string.Equals(directionType.Code, code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedCountryCodeException(code);
    }
    
    private static CountryCode FromAlpha2Code(string alpha2Code)
    {
        foreach(CountryCode directionType in CountryCodes )

            if (string.Equals(directionType.Alpha2Code, alpha2Code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedCountryCodeException(alpha2Code);
    }
    
    private static CountryCode FromAlpha3Code(string alpha3Code)
    {
        foreach(CountryCode directionType in CountryCodes )

            if (string.Equals(directionType.Alpha3Code, alpha3Code, StringComparison.OrdinalIgnoreCase))
            {
                return (directionType);
            }

        throw new UnsupportedCountryCodeException(alpha3Code);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    public static implicit operator string(CountryCode roleType)
    {
        return roleType.ToString();
    }

    public static explicit operator CountryCode(string code)
    {
        return From(code);
    }
    
    //
    // Some Helper Methods
    //

    [JsonIgnore]
    public string? Alpha2Code
    {
        get => Code;
        set => Code = value;
    }

    [JsonIgnore]
    public string? Alpha3Code
    {
        get => LongCode;   
        set => LongCode = value;
    }
    
}