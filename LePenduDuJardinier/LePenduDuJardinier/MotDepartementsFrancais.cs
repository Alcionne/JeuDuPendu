using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotDepartementsFrancais : Mot
    {
        new List<string> mot = new List<string>
        { 
            "ain","aisne","allier","alpes-de-haute-provence","alpes-maritimes","ardeche",
            "ardennes","ariege","aube","aude","aveyron","bas-rhin","bouches-du-rhone",
            "calvados","cantal","charente","charente-maritime","cher","correze","corse-du-sud",
            "cote-d'or","cotes-d'armor","creuse","deux-sevres","dordogne","doubs","drome",
            "essonne","eure","eure-et-loir","finistere","gard","gers","gironde","guadeloupe",
            "guyane","haut-rhin","haute-corse","haute-garonne","haute-loire","haute-marne",
            "haute-saone","haute-savoie","haute-vienne","hautes-alpes","hautes-pyrenees",
            "hauts-de-seine","herault","ile-et-vilaine","indre","indre-et-loire","isere","jura",
            "la reunion","landes","loir-et-cher","loire","loire-atlantique","loiret","lot",
            "lot-et-garonne","lozere","maine-et-loire","manche","marne","martinique","mayenne",
            "mayotte","meurthe-et-moselle","meuse","morbihan","moselle","nievre","nord","oise",
            "orne","paris","pas-de-calais","puy-de-dome","pyrenees-atlantiques","pyrenees-orientales",
            "rhone","saint-pierre-et-miquelon","saone-et-loire","sarthe","savoie","seine-et-marne",
            "seine-maritime","seine-saint-denis","somme","tarn","tarn-et-garonne","territoire de belfort",
            "val-d'oise","val-de-marne","var","vaucluse","vendee","vienne","vosges","yonne","yvelines" 
        };

        public MotDepartementsFrancais()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
