using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotOutils : Mot
    {
        new List<string> mot = new List<string>
        {
            "aerographe","affiloir","agrafeuse","aiguille","alene","alesoir",
            "amperemetre","arrosoir","auge","balai","bambane","banc a etirer",
            "baratte","barre a mine","batee","batte","beche","bedane","betonniere",
            "bigorne","binette","brosse","brouette","burin","bussetto","chalumeau",
            "chignole","cisaille","ciseaux","cle","cliquet","cognee","coin","compas",
            "cordeau","coupe bordure","coupe-plaque","couteau","craie","crayon","cric",
            "cutter","diable","disqueuse","doloire","doucine","drille","echenilloir",
            "ecouvillon","egoine","elagueuse","elastique","emousseur","enclume","encolleuse",
            "equerre","escargot","etau","faucille","faux","fendeur de buches","fer a souder",
            "fiche","filiere","foret","fourche","fraise","fusil","gaufroir","gomme","gouge",
            "gradine","grattoir","greffoir","grelinette","griffe","guillaume","guimbarde","hache",
            "hachette","herminette","herse","houe","inclinometre","lamelleuse","lampe","langue de chat",
            "laser","lime","marqueur","marteau","martelette","masse","merlin","metre","meule","motobineuse",
            "motoculteur","multimetre","niveau","ohmmetre","optometre","pelle","perceuse","pied a coulisse",
            "pied-de-biche","pince","pinceau","pioche","pistolet","plane","plantoir","platoir","pochoir",
            "poincon","pointerolle","polka","pompe","presse","rabot","raclette","racloir","ramponneau","rape",
            "rapporteur","rasoir","rateau","regle","rifloir","rouet","sarcloir","scalpel","scarificateur","scie",
            "secateur","semoir","serfouette","seringue","serpe","serpette","serre-joints","soufflet","spatule",
            "stabilo","stylo","taillant","taille haie","taloche","tamis","tampon","tamponnoir","taraud","tariere",
            "tenaille","tetu","tourne-a-gauche","tournevis","tranchet","transplantoir","tronconneuse","truelle",
            "trusquin","tyrolienne","varlope","vilebrequin","visseuse","voltmetre","vrille","wastringue"
        };

        public MotOutils()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
