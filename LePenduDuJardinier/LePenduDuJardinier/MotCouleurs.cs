﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotCouleurs : Mot
    {
        new List<string> mot = new List<string>
        { 
            "abricot","acajou","aigue-marine","aile de corbeau","albatre","alezan","amarante","ambre","amethyste","ardoise","argent","argile","asperge","aubergine","auburn","aurore","azur","azur brume","azur clair","azurin","basane","beige","beige clair","beigeasse","beurre","beurre frais","bis","bisque","bistre","bitume","blanc","blanc casse","blanc ceruse","blanc creme","blanc d'argent","blanc d'espagne","blanc d'ivoire","blanc de lait","blanc de lin","blanc de platine","blanc de plomb","blanc de saturne","blanc de troyes","blanc de zinc","blanc ecru","blanc lunaire","blanc neige","blanc opalin","blanc-bleu","ble","blet","bleu","bleu acier","bleu ardoise","bleu barbeau","bleu bleuet","bleu bondi","bleu celeste","bleu ceruleen","bleu charrette","bleu charron","bleu ciel","bleu cobalt","bleu de berlin","bleu de france","bleu de minuit","bleu de prusse","bleu denim","bleu des mers du sud","bleu dragee","bleu egyptien","bleu electrique","bleu guede","bleu horizon","bleu majorelle","bleu marine","bleu maya","bleu mineral","bleu nuit","bleu outremer","bleu paon","bleu persan","bleu petrole","bleu roi","bleu saphir","bleu sarcelle","bleu smalt","bleu tiffany","bleu turquin","bleu turquoise","blond","bordeaux","boutton d'or","brique","bronze","brou de noix","brun","bulle","bureau","byzantin","byzantium","caca d'oie","cacao","cachou","cafe","cafe au lait","canard","cannelle","caramel","carotte","cassis","celadon","cerise","cerule","chair","chamois","champagne","chataigne","chatain","chaudron","chocolat","chrome","citron","citrouille","coeruleum","colombin","coquille d'oeuf","corail","cramoisi","cuisse de nymphe","cuivre","cyan","dore","dorian","ebene","ecarlate","ecru","emeraude","etain oxyde","etain pur","fauve","feuille-morte","flave","fleur de soufre","fluo","fraise","fraise ecrasee","framboise","fumee","fushia","givre","glauque","glycine","gomme-gutte","grege","grenadine","grenat","gris","gris acier","gris anthracite","gris de lin","gris de maure","gris de payne","gris fer","gris perle","gris souris","gris tourterelle","heliotrope","hooker","incarnadin","incarnat","indigo","indigo du web","ivoire","jade","jaune","jaune aureolin","jaune banane","jaune canari","jaune chartreuse","jaune d'or","jaune de cobalt","jaune de naples","jaune imperial","jaune mimosa","jaune moutarde","jaune nankin","jaune olive","jaune paille","jaune poussin","kaki","klein","lapis-lazuli","lavalliere","lavande","lie de vin","lilas","magenta","magenta fonce","magenta fushia","maïs","mandarine","marron","mars","mastic","mauve","melon","menthe","menthe a l'eau","miel","mordore","nacarat","noir","noir animal","noir charbon","noir d'aniline","noir d'encre","noir d'ivoire","noir de carbone","noir de fumee","noir de jais","noiraud","noisette","ocre jaune","ocre rouge","or","orange","orange brulee","orchidee","orpiment","parme","passe-velours","pastel","pêche","pervenche","pinchard","plomb","poil de chameau","pourpre","praline","prune","puce","queue de vache","reglisse","rose","rose balais","rose bonbon","rose dragee","rose mountbatten","rose the","rose vif","rouge","rouge alizarine","rouge anglais","rouge bismarck","rouge bourgogne","rouge capucine","rouge cardinal","rouge carmin","rouge cinabre","rouge coquelicot","rouge cramoisi","rouge d'andrinople","rouge d'aniline","rouge de falun","rouge de mars","rouge ecrevisse","rouge feu","rouge garance","rouge groseille","rouge ponceau","rouge rubis","rouge sang","rouge tomate","rouge tomette","rouge turc","rouge vermillon","rouge-violet","rouille","roux","sable","safran","sang de boeuf","saumon","senois","sepia","sinople","soufre","tabac","tangerine","tanne","taupe","terracotta","terre d'ombre","terre de sienne","topaze","tourdille","turquoise","vanille","venitien","ventre de biche","vermeil","vert","vert absinthe","vert amande","vert anglais","vert anis","vert avocat","vert bouteille","vert chartreuse","vert citron","vert d'eau","vert de chrome","vert de gris","vert de vessie","vert emeraude","vert empire","vert epinard","vert gazon","vert imperial","vert kaki","vert lichen","vert lime","vert malachite","vert melese","vert militaire","vert mousse","vert olive","vert opaline","vert perroquet","vert pin","vert pistache","vert poireau","vert pomme","vert prairie","vert prasin","vert printemps","vert sapin","vert sauge","vert smaragdin","vert tilleul","vert veronese","vert viride","violet","violet d'eveque","violine","zinzolin" 
        };

        public MotCouleurs()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}