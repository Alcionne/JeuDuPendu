using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotHumain : Mot
    {
        new List<string> mot = new List<string>
        {   
            "abdomen","abducteur","adducteur","alveole pulmonaire",
            "amygdale","annulaire","anus","aorte","apophyse mastoidienne",
            "appendice","arcade sourciliere","artere","astragale","auriculaire",
            "avant-bras","biceps brachial","biceps de la cuisse","bouche",
            "brachial anterieur","bras","bronche","cage thoracique","calcaneum",
            "canine","carpe","carpes","cavite orbitaire","cerveau","cheveux",
            "cheville","cil","clavicule","clitoris","coccyx","colon","colonne cervicale",
            "colonne dorsale","colonne lombaire","colonne vertebrale","cordes vocales",
            "cornee","cotes","cotes flottantes","cou","coude","couturier","crane",
            "cristallin","cubital posterieur","cubitus","cuisse","cuneiforme medial",
            "cuticule","coeur","deltoide","dent","dent de sagesse","derme","diaphragme",
            "doigt","dos","droit anterieur","droit interne de la cuisse","duodenum",
            "encephale","enclume","epaule","epiderme","estomac","etrier","extenseur commun des doigts",
            "extenseur commun des orteils","fausses cotes","femur","fesse","fibula","foie",
            "fosse nasale","front","frontal","genou","glabelle","gland","glotte","gorge",
            "grand adducteur","grand dentele","grand dorsal","grand droit de l'abdomen",
            "grand fessier","grand palmaire","grand pectoral","grand rond","gros orteil",
            "hanche","humerus","incisive","index","intestin","intestin grele","ischio-jambiers",
            "ischion","jambe","jambier anterieur","joue","jumeaux","langue","larynx","levre",
            "ligament","lobe d’oreille","lombaires","long peronier lateral","long supinateur",
            "luette","main","majeur","malaire ou zygomatique","mamelon","manubrium","marteau",
            "mastoide","maxillaire inferieur","maxillaire superieur","menton","metacarpe","metatarse",
            "molaire","mollet","moyen fessier","muscle","nerf","nez","nombril","nuque","oblique externe",
            "occipital","oeil","oesophage","omoplate","ongle","orbiculaire des levres",
            "orbiculaire des paupieres","oreille","orteil","os","os frontal","os hyoide",
            "os iliaque","os malaire","os naviculaire","os parietal","ovaire","palais",
            "pancreas","paupiere","peau","penis","perone","petit orteil","petit palmaire",
            "petit pectoral","petit rond","phalange","phalangette","phalangine","pharynx",
            "pied","poignet","poil","poitrine","pouce","poumon","premolaire","prepuce","prostate",
            "pubis","pupille","quadriceps femoral","rachis","radius","rectum","rein","retinaculum",
            "retine","rhinopharynx","rhomboide","rocher","rotule","sacrum","scrotum","sein","soleaire",
            "sourcil","sous-epineux","sphenoide","sterno cleido mastoidien","sternum","talon","tarse",
            "tempe","temporal","tendon","tendon d’achille","tenseur du fascia lata","testicule","tete",
            "teton","thorax","tibia","trachee","tragus","trapeze","triceps brachial","tronc","tympan",
            "uretere","uretre","uterus","vagin","vaste externe","vaste interne","veine","ventre","ventricule",
            "vertebres","vesicule biliaire","vessie","visage","yeux","zygomatique" 
        };

        public MotHumain()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
