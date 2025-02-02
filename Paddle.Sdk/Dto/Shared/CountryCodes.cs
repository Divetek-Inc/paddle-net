using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Dto.Shared;

[JsonConverter(typeof(PaddleJsonConverter<CountryCodes>))]
public enum CountryCodes {
    [EnumMember(Value = "AD")]
    [Description("Andorra")]
    AD,

    [EnumMember(Value = "AE")]
    [Description("United Arab Emirates")]
    AE,

    [EnumMember(Value = "AG")]
    [Description("Antigua and Barbuda")]
    AG,

    [EnumMember(Value = "AI")]
    [Description("Anguilla")]
    AI,

    [EnumMember(Value = "AL")]
    [Description("Albania")]
    AL,

    [EnumMember(Value = "AM")]
    [Description("Armenia")]
    AM,

    [EnumMember(Value = "AO")]
    [Description("Angola")]
    AO,

    [EnumMember(Value = "AR")]
    [Description("Argentina")]
    AR,

    [EnumMember(Value = "AS")]
    [Description("American Samoa")]
    AS,

    [EnumMember(Value = "AT")]
    [Description("Austria")]
    AT,

    [EnumMember(Value = "AU")]
    [Description("Australia")]
    AU,

    [EnumMember(Value = "AW")]
    [Description("Aruba")]
    AW,

    [EnumMember(Value = "AX")]
    [Description("Åland Islands")]
    AX,

    [EnumMember(Value = "AZ")]
    [Description("Azerbaijan")]
    AZ,

    [EnumMember(Value = "BA")]
    [Description("Bosnia and Herzegovina")]
    BA,

    [EnumMember(Value = "BB")]
    [Description("Barbados")]
    BB,

    [EnumMember(Value = "BD")]
    [Description("Bangladesh")]
    BD,

    [EnumMember(Value = "BE")]
    [Description("Belgium")]
    BE,

    [EnumMember(Value = "BF")]
    [Description("Burkina Faso")]
    BF,

    [EnumMember(Value = "BG")]
    [Description("Bulgaria")]
    BG,

    [EnumMember(Value = "BH")]
    [Description("Bahrain")]
    BH,

    [EnumMember(Value = "BI")]
    [Description("Burundi")]
    BI,

    [EnumMember(Value = "BJ")]
    [Description("Benin")]
    BJ,

    [EnumMember(Value = "BL")]
    [Description("Saint Barthélemy")]
    BL,

    [EnumMember(Value = "BM")]
    [Description("Bermuda")]
    BM,

    [EnumMember(Value = "BN")]
    [Description("Brunei")]
    BN,

    [EnumMember(Value = "BO")]
    [Description("Bolivia")]
    BO,

    [EnumMember(Value = "BQ")]
    [Description("Caribbean Netherlands (Bonaire, Sint Eustatius, and Saba)")]
    BQ,

    [EnumMember(Value = "BR")]
    [Description("Brazil")]
    BR,

    [EnumMember(Value = "BS")]
    [Description("Bahamas")]
    BS,

    [EnumMember(Value = "BT")]
    [Description("Bhutan")]
    BT,

    [EnumMember(Value = "BV")]
    [Description("Bouvet Island")]
    BV,

    [EnumMember(Value = "BW")]
    [Description("Botswana")]
    BW,

    [EnumMember(Value = "BZ")]
    [Description("Belize")]
    BZ,

    [EnumMember(Value = "CA")]
    [Description("Canada")]
    CA,

    [EnumMember(Value = "CC")]
    [Description("Cocos Islands")]
    CC,

    [EnumMember(Value = "CG")]
    [Description("Republic of Congo")]
    CG,

    [EnumMember(Value = "CH")]
    [Description("Switzerland")]
    CH,

    [EnumMember(Value = "CI")]
    [Description("Côte d'Ivoire (Ivory Coast)")]
    CI,

    [EnumMember(Value = "CK")]
    [Description("Cook Islands")]
    CK,

    [EnumMember(Value = "CL")]
    [Description("Chile")]
    CL,

    [EnumMember(Value = "CM")]
    [Description("Cameroon")]
    CM,

    [EnumMember(Value = "CN")]
    [Description("China")]
    CN,

    [EnumMember(Value = "CO")]
    [Description("Colombia")]
    CO,

    [EnumMember(Value = "CR")]
    [Description("Costa Rica")]
    CR,

    [EnumMember(Value = "CV")]
    [Description("Cape Verde")]
    CV,

    [EnumMember(Value = "CW")]
    [Description("Curaçao")]
    CW,

    [EnumMember(Value = "CX")]
    [Description("Christmas Island")]
    CX,

    [EnumMember(Value = "CY")]
    [Description("Cyprus")]
    CY,

    [EnumMember(Value = "CZ")]
    [Description("Czechia (Czech Republic)")]
    CZ,

    [EnumMember(Value = "DE")]
    [Description("Germany")]
    DE,

    [EnumMember(Value = "DJ")]
    [Description("Djibouti")]
    DJ,

    [EnumMember(Value = "DK")]
    [Description("Denmark")]
    DK,

    [EnumMember(Value = "DM")]
    [Description("Dominica")]
    DM,

    [EnumMember(Value = "DO")]
    [Description("Dominican Republic")]
    DO,

    [EnumMember(Value = "DZ")]
    [Description("Algeria")]
    DZ,

    [EnumMember(Value = "EC")]
    [Description("Ecuador")]
    EC,

    [EnumMember(Value = "EE")]
    [Description("Estonia")]
    EE,

    [EnumMember(Value = "EG")]
    [Description("Egypt")]
    EG,

    [EnumMember(Value = "EH")]
    [Description("Western Sahara")]
    EH,

    [EnumMember(Value = "ER")]
    [Description("Eritrea")]
    ER,

    [EnumMember(Value = "ES")]
    [Description("Spain")]
    ES,

    [EnumMember(Value = "ET")]
    [Description("Ethiopia")]
    ET,

    [EnumMember(Value = "FI")]
    [Description("Finland")]
    FI,

    [EnumMember(Value = "FJ")]
    [Description("Fiji")]
    FJ,

    [EnumMember(Value = "FK")]
    [Description("Falkland Islands")]
    FK,

    [EnumMember(Value = "FM")]
    [Description("Micronesia")]
    FM,

    [EnumMember(Value = "FO")]
    [Description("Faroe Islands")]
    FO,

    [EnumMember(Value = "FR")]
    [Description("France")]
    FR,

    [EnumMember(Value = "GA")]
    [Description("Gabon")]
    GA,

    [EnumMember(Value = "GB")]
    [Description("United Kingdom")]
    GB,

    [EnumMember(Value = "GD")]
    [Description("Grenada")]
    GD,

    [EnumMember(Value = "GE")]
    [Description("Georgia")]
    GE,

    [EnumMember(Value = "GF")]
    [Description("French Guiana")]
    GF,

    [EnumMember(Value = "GG")]
    [Description("Guernsey")]
    GG,

    [EnumMember(Value = "GH")]
    [Description("Ghana")]
    GH,

    [EnumMember(Value = "GI")]
    [Description("Gibraltar")]
    GI,

    [EnumMember(Value = "GL")]
    [Description("Greenland")]
    GL,

    [EnumMember(Value = "GM")]
    [Description("Gambia")]
    GM,

    [EnumMember(Value = "GN")]
    [Description("Guinea")]
    GN,

    [EnumMember(Value = "GP")]
    [Description("Guadeloupe")]
    GP,

    [EnumMember(Value = "GQ")]
    [Description("Equatorial Guinea")]
    GQ,

    [EnumMember(Value = "GR")]
    [Description("Greece")]
    GR,

    [EnumMember(Value = "GS")]
    [Description("South Georgia and the South Sandwich Islands")]
    GS,

    [EnumMember(Value = "GT")]
    [Description("Guatemala")]
    GT,

    [EnumMember(Value = "GU")]
    [Description("Guam")]
    GU,

    [EnumMember(Value = "GW")]
    [Description("Guinea-Bissau")]
    GW,

    [EnumMember(Value = "GY")]
    [Description("Guyana")]
    GY,

    [EnumMember(Value = "HK")]
    [Description("Hong Kong")]
    HK,

    [EnumMember(Value = "HM")]
    [Description("Heard Island and McDonald Islands")]
    HM,

    [EnumMember(Value = "HN")]
    [Description("Honduras")]
    HN,

    [EnumMember(Value = "HR")]
    [Description("Croatia")]
    HR,

    [EnumMember(Value = "HU")]
    [Description("Hungary")]
    HU,

    [EnumMember(Value = "ID")]
    [Description("Indonesia")]
    ID,

    [EnumMember(Value = "IE")]
    [Description("Ireland")]
    IE,

    [EnumMember(Value = "IL")]
    [Description("Israel")]
    IL,

    [EnumMember(Value = "IM")]
    [Description("Isle of Man")]
    IM,

    [EnumMember(Value = "IN")]
    [Description("India")]
    IN,

    [EnumMember(Value = "IO")]
    [Description("British Indian Ocean Territory")]
    IO,

    [EnumMember(Value = "IQ")]
    [Description("Iraq")]
    IQ,

    [EnumMember(Value = "IS")]
    [Description("Iceland")]
    IS,

    [EnumMember(Value = "IT")]
    [Description("Italy")]
    IT,

    [EnumMember(Value = "JE")]
    [Description("Jersey")]
    JE,

    [EnumMember(Value = "JM")]
    [Description("Jamaica")]
    JM,

    [EnumMember(Value = "JO")]
    [Description("Jordan")]
    JO,

    [EnumMember(Value = "JP")]
    [Description("Japan")]
    JP,

    [EnumMember(Value = "KE")]
    [Description("Kenya")]
    KE,

    [EnumMember(Value = "KG")]
    [Description("Kyrgyzstan")]
    KG,

    [EnumMember(Value = "KH")]
    [Description("Cambodia")]
    KH,

    [EnumMember(Value = "KI")]
    [Description("Kiribati")]
    KI,

    [EnumMember(Value = "KM")]
    [Description("Comoros")]
    KM,

    [EnumMember(Value = "KN")]
    [Description("Saint Kitts and Nevis")]
    KN,

    [EnumMember(Value = "KR")]
    [Description("South Korea")]
    KR,

    [EnumMember(Value = "KW")]
    [Description("Kuwait")]
    KW,

    [EnumMember(Value = "KY")]
    [Description("Cayman Islands")]
    KY,

    [EnumMember(Value = "KZ")]
    [Description("Kazakhstan")]
    KZ,

    [EnumMember(Value = "LA")]
    [Description("Lao People's Democratic Republic (Laos)")]
    LA,

    [EnumMember(Value = "LB")]
    [Description("Lebanon")]
    LB,

    [EnumMember(Value = "LC")]
    [Description("Saint Lucia")]
    LC,

    [EnumMember(Value = "LI")]
    [Description("Liechtenstein")]
    LI,

    [EnumMember(Value = "LK")]
    [Description("Sri Lanka")]
    LK,

    [EnumMember(Value = "LR")]
    [Description("Liberia")]
    LR,

    [EnumMember(Value = "LS")]
    [Description("Lesotho")]
    LS,

    [EnumMember(Value = "LT")]
    [Description("Lithuania")]
    LT,

    [EnumMember(Value = "LU")]
    [Description("Luxembourg")]
    LU,

    [EnumMember(Value = "LV")]
    [Description("Latvia")]
    LV,

    [EnumMember(Value = "MA")]
    [Description("Morocco")]
    MA,

    [EnumMember(Value = "MC")]
    [Description("Monaco")]
    MC,

    [EnumMember(Value = "MD")]
    [Description("Moldova")]
    MD,

    [EnumMember(Value = "ME")]
    [Description("Montenegro")]
    ME,

    [EnumMember(Value = "MF")]
    [Description("Saint Martin")]
    MF,

    [EnumMember(Value = "MG")]
    [Description("Madagascar")]
    MG,

    [EnumMember(Value = "MH")]
    [Description("Marshall Islands")]
    MH,

    [EnumMember(Value = "MK")]
    [Description("Macedonia")]
    MK,

    [EnumMember(Value = "MN")]
    [Description("Mongolia")]
    MN,

    [EnumMember(Value = "MO")]
    [Description("Macao")]
    MO,

    [EnumMember(Value = "MP")]
    [Description("Northern Mariana Islands")]
    MP,

    [EnumMember(Value = "MQ")]
    [Description("Martinique")]
    MQ,

    [EnumMember(Value = "MR")]
    [Description("Mauritania")]
    MR,

    [EnumMember(Value = "MS")]
    [Description("Montserrat")]
    MS,

    [EnumMember(Value = "MT")]
    [Description("Malta")]
    MT,

    [EnumMember(Value = "MU")]
    [Description("Mauritius")]
    MU,

    [EnumMember(Value = "MV")]
    [Description("Maldives")]
    MV,

    [EnumMember(Value = "MW")]
    [Description("Malawi")]
    MW,

    [EnumMember(Value = "MX")]
    [Description("Mexico")]
    MX,

    [EnumMember(Value = "MY")]
    [Description("Malaysia")]
    MY,

    [EnumMember(Value = "MZ")]
    [Description("Mozambique")]
    MZ,

    [EnumMember(Value = "NA")]
    [Description("Namibia")]
    NA,

    [EnumMember(Value = "NC")]
    [Description("New Caledonia")]
    NC,

    [EnumMember(Value = "NE")]
    [Description("Niger")]
    NE,

    [EnumMember(Value = "NF")]
    [Description("Norfolk Island")]
    NF,

    [EnumMember(Value = "NG")]
    [Description("Nigeria")]
    NG,

    [EnumMember(Value = "NL")]
    [Description("Netherlands")]
    NL,

    [EnumMember(Value = "NO")]
    [Description("Norway")]
    NO,

    [EnumMember(Value = "NP")]
    [Description("Nepal")]
    NP,

    [EnumMember(Value = "NR")]
    [Description("Nauru")]
    NR,

    [EnumMember(Value = "NU")]
    [Description("Niue")]
    NU,

    [EnumMember(Value = "NZ")]
    [Description("New Zealand")]
    NZ,

    [EnumMember(Value = "OM")]
    [Description("Oman")]
    OM,

    [EnumMember(Value = "PA")]
    [Description("Panama")]
    PA,

    [EnumMember(Value = "PE")]
    [Description("Peru")]
    PE,

    [EnumMember(Value = "PF")]
    [Description("French Polynesia")]
    PF,

    [EnumMember(Value = "PG")]
    [Description("Papua New Guinea")]
    PG,

    [EnumMember(Value = "PH")]
    [Description("Philippines")]
    PH,

    [EnumMember(Value = "PK")]
    [Description("Pakistan")]
    PK,

    [EnumMember(Value = "PL")]
    [Description("Poland")]
    PL,

    [EnumMember(Value = "PM")]
    [Description("Saint Pierre and Miquelon")]
    PM,

    [EnumMember(Value = "PN")]
    [Description("Pitcairn")]
    PN,

    [EnumMember(Value = "PR")]
    [Description("Puerto Rico")]
    PR,

    [EnumMember(Value = "PS")]
    [Description("Palestinian territories")]
    PS,

    [EnumMember(Value = "PT")]
    [Description("Portugal")]
    PT,

    [EnumMember(Value = "PW")]
    [Description("Palau")]
    PW,

    [EnumMember(Value = "PY")]
    [Description("Paraguay")]
    PY,

    [EnumMember(Value = "QA")]
    [Description("Qatar")]
    QA,

    [EnumMember(Value = "RE")]
    [Description("Reunion")]
    RE,

    [EnumMember(Value = "RO")]
    [Description("Romania")]
    RO,

    [EnumMember(Value = "RS")]
    [Description("Republic of Serbia")]
    RS,

    [EnumMember(Value = "RW")]
    [Description("Rwanda")]
    RW,

    [EnumMember(Value = "SA")]
    [Description("Saudi Arabia")]
    SA,

    [EnumMember(Value = "SB")]
    [Description("Solomon Islands")]
    SB,

    [EnumMember(Value = "SC")]
    [Description("Seychelles")]
    SC,

    [EnumMember(Value = "SE")]
    [Description("Sweden")]
    SE,

    [EnumMember(Value = "SG")]
    [Description("Singapore")]
    SG,

    [EnumMember(Value = "SH")]
    [Description("Saint Helena")]
    SH,

    [EnumMember(Value = "SI")]
    [Description("Slovenia")]
    SI,

    [EnumMember(Value = "SJ")]
    [Description("Svalbard and Jan Mayen")]
    SJ,

    [EnumMember(Value = "SK")]
    [Description("Slovakia")]
    SK,

    [EnumMember(Value = "SL")]
    [Description("Sierra Leone")]
    SL,

    [EnumMember(Value = "SM")]
    [Description("San Marino")]
    SM,

    [EnumMember(Value = "SN")]
    [Description("Senegal")]
    SN,

    [EnumMember(Value = "SR")]
    [Description("Suriname")]
    SR,

    [EnumMember(Value = "ST")]
    [Description("São Tomé and Príncipe")]
    ST,

    [EnumMember(Value = "SV")]
    [Description("El Salvador")]
    SV,

    [EnumMember(Value = "SX")]
    [Description("Sint Maarten")]
    SX,

    [EnumMember(Value = "SZ")]
    [Description("Swaziland")]
    SZ,

    [EnumMember(Value = "TC")]
    [Description("Turks and Caicos Islands")]
    TC,

    [EnumMember(Value = "TD")]
    [Description("Chad")]
    TD,

    [EnumMember(Value = "TF")]
    [Description("French Southern and Antarctic Lands")]
    TF,

    [EnumMember(Value = "TG")]
    [Description("Togo")]
    TG,

    [EnumMember(Value = "TH")]
    [Description("Thailand")]
    TH,

    [EnumMember(Value = "TJ")]
    [Description("Tajikistan")]
    TJ,

    [EnumMember(Value = "TK")]
    [Description("Tokelau")]
    TK,

    [EnumMember(Value = "TL")]
    [Description("Timor-Leste")]
    TL,

    [EnumMember(Value = "TM")]
    [Description("Turkmenistan")]
    TM,

    [EnumMember(Value = "TN")]
    [Description("Tunisia")]
    TN,

    [EnumMember(Value = "TO")]
    [Description("Tonga")]
    TO,

    [EnumMember(Value = "TR")]
    [Description("Turkey")]
    TR,

    [EnumMember(Value = "TT")]
    [Description("Trinidad and Tobago")]
    TT,

    [EnumMember(Value = "TV")]
    [Description("Tuvalu")]
    TV,

    [EnumMember(Value = "TW")]
    [Description("Taiwan")]
    TW,

    [EnumMember(Value = "TZ")]
    [Description("Tanzania")]
    TZ,

    [EnumMember(Value = "UA")]
    [Description("Ukraine")]
    UA,

    [EnumMember(Value = "UG")]
    [Description("Uganda")]
    UG,

    [EnumMember(Value = "UM")]
    [Description("United States Minor Outlying Islands")]
    UM,

    [EnumMember(Value = "US")]
    [Description("United States")]
    US,

    [EnumMember(Value = "UY")]
    [Description("Uruguay")]
    UY,

    [EnumMember(Value = "UZ")]
    [Description("Uzbekistan")]
    UZ,

    [EnumMember(Value = "VA")]
    [Description("Holy See (Vatican City)")]
    VA,

    [EnumMember(Value = "VC")]
    [Description("Saint Vincent and the Grenadines")]
    VC,

    [EnumMember(Value = "VG")]
    [Description("British Virgin Islands")]
    VG,

    [EnumMember(Value = "VI")]
    [Description("U.S. Virgin Islands")]
    VI,

    [EnumMember(Value = "VN")]
    [Description("Vietnam")]
    VN,

    [EnumMember(Value = "VU")]
    [Description("Vanuatu")]
    VU,

    [EnumMember(Value = "WF")]
    [Description("Wallis and Futuna")]
    WF,

    [EnumMember(Value = "WS")]
    [Description("Samoa")]
    WS,

    [EnumMember(Value = "XK")]
    [Description("Kosovo")]
    XK,

    [EnumMember(Value = "YT")]
    [Description("Mayotte")]
    YT,

    [EnumMember(Value = "ZA")]
    [Description("South Africa")]
    ZA,

    [EnumMember(Value = "ZM")]
    [Description("Zambia")]
    ZM
}