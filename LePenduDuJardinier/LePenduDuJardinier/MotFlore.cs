using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotFlore : Mot
    {
        new List<string> mot = new List<string>
        {
              "abelia", "abricotier", "acacia", "acajou",
              "acerola", "acokanthera", "adenia", "adenium", "agave", "ailante", "ailante glanduleux",
              "airelle rouge", "akebie a cinq feuilles", "albizia", "amandier", "amelanchier",
              "amorpha", "anacardier", "aporocactus", "aquilaria crassna", "aralia de californie",
              "aralia elata", "araucaria", "arbousier", "arbre a miel", "arbre a pain",
              "arbre au caramel", "arbre aux anemones", "arbre aux faisans", "arbre aux lanternes",
              "arbre aux perles", "arbre de jude", "arbre de soie", "arbre du clerge",
              "arbre orchidee", "argousier", "asiminier trilobe", "aubepine", "aucuba", "aulne",
              "avocatier", "azerolier", "baguenaudier", "bambou", "bananier", "baobab", "beaucarnea",
              "belombra", "benjoin", "berberis", "bergamotier", "bibacier", "bigaradier", "bignone",
              "bilimbi", "bougainvillier", "bouleau", "bouleau verruqueux", "bourdaine",
              "brachychiton acerifolius", "brugmansia", "buddleia de david", "buis", "cacaoyer",
              "cactus", "cafeier", "callistemon citrinus", "calocedre", "camelia", "camphrier",
              "canneberge", "cannelier", "cannelle de magellan", "caprier", "caraganier de siberie",
              "carambolier", "caroubier", "caryer ovale", "casseille", "cassissier", "catalpa", "cedratier",
              "cedre", "ceiba", "cephalotaxe de fortune", "cerisier", "charme", "chataignier",
              "chene", "cherimolier", "chevrefeuille", "citrangequat", "citronnier", "cocotier",
              "cognassier", "combava", "cormier", "cornouiller", "cotinus", "cotonnier", "cynorhodon",
              "cypres", "cytise", "davidia", "delonix regia", "deutzia", "dragonnier",
              "echinocactus platyacanthus", "eglantier", "elaeagnus multiflore", "elaeagnus umbrellata",
              "epicea", "epinette", "erable", "erhetia", "escallonia rubra", "eucalyptus", "exochorda",
              "fatsia du japon", "feijoa", "fevier", "figuier", "filaire", "filao", "firmiana simplex",
              "forsythia", "fragon", "framboisier", "frangipanier", "frene", "fusain aile", "fushia de magellan",
              "gainier du canada", "gardenia jasminoides", "gardenia thunbergia", "gattilier",
              "genet a balais", "genevrier", "geranium jungle", "germandree arbustive", "ginkgo biloba",
              "girembellier", "giroflier", "glycine", "gommier", "grenadier", "griottier", "griselinia littoralis",
              "groseillier", "hamamelis", "henne", "hetre", "hevea", "hiba", "hibiscus", "hieble", "hortensia",
              "houx", "hoya", "hydrangea", "idesia", "if", "iochrome", "jacaranda", "jacquier", "jasmin de madagascar",
              "jojoba", "jujubier", "kaki", "kalmia", "kalopanax", "kaloupile", "kauri", "kiwaï", "kiwi", "kolkwitzia",
              "kumquat", "l'arbre corail", "lasiocereus rupicola", "latanier", "laurier", "lavatera trimestris",
              "liane de jade", "libocedre", "lilas", "liquidambar", "longanier", "lycianthes rantonnetii",
              "lyciet de barbarie", "madrone du pacifique", "magnolia", "mandarinier", "mangoustanier",
              "marronnier", "mehonia", "meleze", "merisier", "metrosideros", "micocoulier", "mimosa", "mirabellier",
              "mûre de logan", "murier blanc", "mûrier platane", "muscadier", "myrte", "myrtille arbustive",
              "nashi", "nectarinier", "neflier", "nerprun", "niaouli", "noisetier", "nopal, cactus", "notro",
              "noyer", "nyssa sylvestres", "olivier", "oranger", "orme", "osmophore", "oxydendron", "pacanier",
              "paletuvier", "palmier", "pamplemoussier", "papayer", "parasolier", "parrotia", "paulownia",
              "pavier rouge", "pecher", "pepino", "pernambouc", "peuplier", "phellodendron", "photinia",
              "physalis alkekenge", "physocarpe pacifique", "pieris", "pin", "pin parasol", "pistachier",
              "pivoine arbustive", "platane", "poirier", "pommier", "poncirier", "prosopis alba", "prunier",
              "pterocarya stenoptera", "pterocaryer du caucase", "pterostyrax corymbosus", "pyracanthe",
              "quercus", "quinina rouge", "quisqualier", "ragouminier", "ramboutan", "rauwolfia caffra",
              "ravenale", "rhododendron", "rhubarbe", "rosa beggeriana", "rosa canina", "ruttya fruticosa",
              "sapin", "sapotier", "sapotillier", "sarcococca confusa", "sassafra albidum", "saule",
              "saule marsault", "saule pleureur", "savonnier de chine", "schizophragma hydrangeoide",
              "sequoia", "sequoia geant", "seringat", "sophora", "sorbier", "stachyurus", "stenocactus vaupelianus",
              "stewartia", "sumac des corroyeurs", "sureau", "sureau-sambucus", "symphorine", "tabebuia",
              "tamarillo", "tamarinier", "tamaris de printemps", "tasmannia", "teck", "tetrapanax papyrifer",
              "theier", "thelocactus macdowellii", "thuya", "thuya de chine", "tilleul", "torreya",
              "torreya du japon", "trachycarpus", "trochodendron", "troene", "tsuga", "tulipier de virginie",
              "ulmo", "umbillicus rupestris", "vernis du japon", "vigne", "vinaigrier", "viorne", "virgilier",
              "weigelia", "wenge", "wodyetia bifurcata", "wollemia nobilis", "xanthoceras", "xanthorrhoea glauca",
              "xanthoxylum-fagara", "yerba mate", "ylang-ylang", "yucca", "zelkova", "ziziphus mucronata", "agapanthe",
              "ancolie", "anemone", "arum", "aster", "astrance", "begonia", "bleuet", "boutons d'or", "buglose", "calla",
              "callune", "camelia", "camomille", "campanule", "capucine", "cardinale", "carline", "chardon", "chevrefeuille",
              "chicoree", "ciboulette", "cirse", "ciste", "clematite", "colza", "coquelicot", "coronille", "crocus", "dahlia",
              "dame-d'onze-heures", "digitale", "echinops", "edelweiss", "eglantine", "epiaire", "epilobe", "esparcette",
              "eupatoire", "euphorbe", "ficaire", "fumeterre", "gaillet", "genet", "gentiane", "geranium", "gesse", "giroflee",
              "glaïeul", "globulaire", "grebera", "heliantheme", "hellebore", "hibiscus", "hortense", "hortensia", "hysope",
              "immortelle", "iris", "jacinthe", "jarosse", "jasmin", "jonc", "jonquille", "joubarde", "kalanchoë", "kalmie",
              "lamier", "lavande", "lilas", "linaigrette", "linaire", "liseron", "lobelia", "lobelie", "lotier", "lotus",
              "lunaire", "lupin", "lychnis", "lys", "lysimaque", "magnolia", "marguerite", "marjolaine", "mauve", "melampyre",
              "melisse", "millepertuis", "mimosa", "mouron", "muguet", "muscari", "myosotis", "narcisse", "nenuphar",
              "oeillet", "oiseau du paradis", "onagre", "ononis", "onopordon", "ophrys", "orchidee", "orchis", "origan",
              "orobanche", "orpin", "ortie", "oseille", "paquerette", "patience", "pavot", "pediculaire", "pensee",
              "perce-neige", "petite pervenche", "petunia", "phacelie", "phalangere", "pissenlit", "pivoine", "plantain",
              "pois de senteur", "polygale", "potentille", "primevere", "pulmonaire", "pulsatille", "raiponce", "renoncule",
              "renouee", "reseda", "rose", "sainfoin", "sanve", "saponaire", "sauge", "scabieuse", "scorsonere", "silene",
              "solidage", "stellaire", "tournesol", "trefle", "tulipe", "tussilage", "veronique", "violette", "viperine",
              "xanthium", "ylang-ylang", "zinnia", "oeillet"
        };

        public MotFlore()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
