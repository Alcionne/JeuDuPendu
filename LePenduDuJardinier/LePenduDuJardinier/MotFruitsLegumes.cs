using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotFruitsLegumes : Mot
    {
        new List<string> mot = new List<string>
        {   
            "abricot", "açai", "airelle",
            "alkekenge", "amande", "ananas", "anone", "aronia", "avocat", "banane",
            "bergamote", "bibasse", "bigaradier", "bleuet", "brugnon", "cacahuete",
            "caimite", "calamondin", "camerise", "canneberge", "carambole", "cassis",
            "cedrat", "cerise", "chataigne", "cherimole", "citron", "citron vert",
            "citron-caviar", "clementine", "coing", "combava", "corosole", "cranberry",
            "damassine", "datte", "durian", "figue", "fraise", "fraise des bois",
            "framboise", "fruit de la passion", "fruit du baobab",
            "fruit du dragon", "goyave", "grenade", "grenadelle", "grenadille",
            "griotte", "groseille", "groseille a maquereau", "icaque",
            "ichang papeda", "jaboticaba", "jacque", "jamalac", "jamelon",
            "jujube", "kabosu", "kaki", "kiwi", "kumquat", "lime", "limette",
            "litchi", "longane", "lucuma", "mandarine", "mangoustan", "mangue",
            "marron", "melon", "merise", "mineola", "mirabelle", "mure", "muroise",
            "myrtille", "nashi", "nectarine", "nefle", "noisette", "noix", "noix de cajou",
            "noix de coco", "noix de macadamia", "noix de pecan", "olive",
            "orange", "orange sanguine", "pamplemousse", "papaye", "pasteque", "peche",
            "pepino", "physalis", "pignon de pin", "pistache", "pitaya", "poire",
            "pomelo", "pomme", "prune", "pruneau", "quetsche", "raisin", "ramboutan",
            "safou", "salacca", "sapotille", "sudachi", "sureau noir", "surelle",
            "tamarin", "tangelo", "tangerine", "tangor", "taxo", "tomate", "ugli",
            "vanille", "vavangue", "ximenia", "yuzu", "zatte", "ail", "artichaut",
            "asperge", "aubergine", "avocat", "bette", "betterave", "blette", "brocoli",
            "carotte", "catalonia", "celeri", "champignon", "chou-fleur", "choux",
            "citrouille", "concombre", "courge", "courgette", "cresson", "crosne",
            "dachine", "daikon", "echalote", "endive", "epinard", "fenouil", "feve",
            "flageolet", "giromon", "haricot", "igname", "kancon", "konbu", "laitue",
            "lentille", "mache", "maïs", "manioc", "navet", "oignon", "olive", "oseille",
            "panais", "patate", "patisson", "petits pois", "poireau", "poivron",
            "pomme de terre", "potimarron", "potiron", "radis", "rhubarbe", "roquette",
            "rutabaga", "salade", "salsifi", "salsifis", "tetragone", "tomate", "topinambour",
            "udo", "vitelotte", "wakame", "wasabi", "yacon", "yin tsoi"
        };

        public MotFruitsLegumes()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
