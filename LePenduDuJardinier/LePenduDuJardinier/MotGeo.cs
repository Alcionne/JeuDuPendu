using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotGeo : Mot
    {
        //new List<string> mot = new List<string> { "afrique du sud", "republique centrafricaine" };
        new List<string> mot = new List<string>
        {
            "pretoria", "kaboul", "tirana", "alger",
            "berlin", "andorre-la-vieille", "luanda", "saint  john's", "riyad", "buenos  aires",
            "erevan", "canberra", "vienne", "bakou", "nassau", "manama", "dacca", "bridgetown",
            "bruxelles", "belmopan", "porto-novo", "thimphou", "minsk", "naypyidaw", "sucre",
            "sarajevo", "gaborone", "brasilia", "bandar  seri  begawan", "sofia", "ouagadougou",
            "gitega", "phnom  penh", "yaounde", "ottawa", "praia", "santiago", "pekin", "nicosie",
            "bogota", "moroni", "pyongyang", "seoul", "san  jose", "yamoussoukro", "zagreb",
            "la  havane", "copenhague", "djibouti", "roseau", "le  caire", "abou  dabi", "quito",
            "asmara", "madrid", "mbabane", "tallinn", "washington", "addis-abeba", "suva", "helsinki",
            "paris", "libreville", "banjul", "tbilissi", "accra", "athènes", "saint-georges", "guatemala",
            "conakry", "malabo", "bissau", "georgetown", "port-au-prince", "tegucigalpa", "budapest",
            "avarua", "majuro", "new delhi", "jakarta", "bagdad", "teheran", "dublin", "reykjavik",
            "jerusalem", "rome", "kingston", "tokyo", "amman", "noursoultan", "nairobi", "bichkek",
            "tarawa-sud", "koweit", "vientiane", "maseru", "riga", "beyrouth", "monrovia", "tripoli",
            "vaduz", "vilnius", "luxembourg", "skopje", "antananarivo", "kuala lumpur", "lilongwe",
            "male", "bamako", "la valette", "rabat", "port-louis", "nouakchott", "mexico", "palikir",
            "chișinau", "monaco", "oulan-bator", "podgorica", "maputo", "windhoek", "yaren", "katmandou",
            "managua", "niamey", "abuja", "alofi", "oslo", "wellington", "mascate", "kampala", "tachkent",
            "islamabad", "ngerulmud", "ramallah", "panama", "port moresby", "asuncion", "amsterdam", "lima",
            "manille", "varsovie", "lisbonne", "doha", "bangui", "kinshasa", "saint-domingue", "brazzaville",
            "prague", "bucarest", "londres", "moscou", "kigali", "basseterre", "kingstown", "castries", "saint-marin",
            "honiara", "san salvador", "apia", "sao tome", "dakar", "belgrade", "victoria", "freetown",
            "singapour", "bratislava", "ljubljana", "mogadiscio", "khartoum", "djouba", "sri jayawardenapura",
            "stockholm", "berne", "paramaribo", "damas", "douchanbe", "dodoma", "n'djamena", "bangkok", "dili",
            "lome", "nukuʻalofa", "port-d'espagne", "tunis", "achgabat", "ankara", "funafuti", "kiev", "montevideo",
            "port-vila", "vatican", "caracas", "hanoi", "sanaa", "lusaka", "harare", "afrique du sud",
            "afghanistan", "albanie", "algerie", "allemagne", "andorre", "angola", "antigua-et-barbuda",
            "arabie saoudite", "argentine", "armenie", "australie", "autriche", "azerbaïdjan", "bahamas",
            "bahrein", "bangladesh", "barbade", "belgique", "belize", "benin", "bhoutan", "bielorussie",
            "birmanie", "bolivie", "bosnie-herzegovine", "botswana", "bresil", "brunei", "bulgarie", "burkina faso",
            "burundi", "cambodge", "cameroun", "canada", "cap-vert", "chili", "chine", "chypre", "colombie",
            "comores", "coree du nord", "coree du sud", "costa rica", "cote d'ivoire", "croatie",
            "cuba", "danemark", "djibouti", "dominique", "egypte", "emirats arabes unis", "equateur",
            "erythree", "espagne", "eswatini", "estonie", "etats-unis", "ethiopie", "fidji", "finlande",
            "france", "gabon", "gambie", "georgie", "ghana", "grece", "grenade", "guatemala", "guinee",
            "guinee equatoriale", "guinee-bissau", "guyana", "haiti", "honduras", "hongrie", "iles cook",
            "iles marshall", "inde", "indonesie", "irak", "iran", "irlande", "islande", "israel", "italie",
            "jamaique", "japon", "jordanie", "kazakhstan", "kenya", "kirghizistan", "kiribati", "koweit", "laos",
            "lesotho", "lettonie", "liban", "liberia", "libye", "liechtenstein", "lituanie", "luxembourg", "macedoine",
            "madagascar", "malaisie", "malawi", "maldives", "mali", "malte", "maroc", "maurice", "mauritanie",
            "mexique", "micronesie", "moldavie", "monaco", "mongolie", "montenegro", "mozambique", "namibie",
            "nauru", "nepal", "nicaragua", "niger", "nigeria", "niue", "norvege", "nouvelle-zelande", "oman",
            "ouganda", "ouzbekistan", "pakistan", "palaos", "palestine", "panama", "papouasie-nouvelle-guinee",
            "paraguay", "pays-bas", "perou", "philippines", "pologne", "portugal", "qatar", "republique centrafricaine",
            "republique democratique du congo", "republique dominicaine", "republique du congo",
            "republique tchèque", "roumanie", "royaume-uni", "russie", "rwanda", "saint-kitts-et-nevis",
            "saint-vincent-et-les-grenadines", "sainte-lucie", "saint-marin", "salomon", "salvador", "samoa",
            "sao tome-et-principe", "senegal", "serbie", "seychelles", "sierra leone", "singapour",
            "slovaquie", "slovenie", "somalie", "soudan", "soudan du sud", "sri lanka", "suède", "suisse",
            "suriname", "syrie", "tadjikistan", "tanzanie", "tchad", "thailande", "timor oriental", "togo",
            "tonga", "trinite-et-tobago", "tunisie", "turkmenistan", "turquie", "tuvalu", "ukraine", "uruguay",
            "vanuatu", "vatican", "venezuela", "viet nam", "yemen", "zambie", "zimbabwe"
        };

        public MotGeo()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
