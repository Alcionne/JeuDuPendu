using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotSports : Mot
    {
        new List<string> mot = new List<string>
        {
            "accrobranche","acrosport","aerobic","aeromodelisme","aerostation","agility","aikido","airsoft","alpinisme","apnee","aquabike","aquagym","arts du cirque","athletisme","aviation","aviron","babyfoot","badminton","ball-trap","bandy","base jump","baseball","basketball","beach soccer","beach tennis","beach volley","behourd","biathlon","billard","bmx","bobsleigh","boccia","bodyboard","bodybuilding","boomerang","bouzkachi","bowling","boxe","boxe anglaise","boxe chinoise","boxe francaise","boxe thailandaise","bras de fer","bridge","caber","calcio florentin","canicross","canne de combat","canoe","canoe-kayak","canyoning","canyonisme","capoeira","carrom","catch","chanbara","char a voile","chase tag","cheerleading","cirque","claquettes","combat","corde a sauter","course","course a pied","course aerienne","course camarguaise","course d'obstacles","course d'orientation","course de cote","course de drones","course landaise","cricket","croquet","cross training","cross-country","crosse","crossfit","curling","cyclisme","cyclisme artistique","cyclisme sur piste","cyclisme sur route","cyclo cross","cyclotourisme","danse","danse africaine","danse classique","danse contemporaine","danse country","danse indienne","danse orientale","danse rock","danse sportive","danse sur glace","deltaplane","disc golf","dragon boat","dragster","e-sport","echecs","enduro","equitation","escalade","escrime","extreme football league","fierljeppen","fitness","flag","flamenco","flechettes","floorball","football","football americain","football australien","footgolf","footing","footpool","force athletique","full contact","funboard","futsal","giraviation","golf","gouren","grappling","gymnastique","gymnastique artistique","gymnastique rythmique","halterophilie","handball","handisport","hapkido","hip hop","hockey","hockey subaquatique","hockey sur gazon","hockey sur glace","horse ball","hurling","iaido","jetski","jett kune do","jianzi","jodo","jorkyball","joutes","ju-jitsu","judo","kabaddi","kalarippayatt","kali arnis eskrima","karate","karting","kempo","kendo","kenjutsu","kick boxing","kin ball","kitesurf","kobudo","korfbal","krav-maga","kung fu","kyokushinkai","kyudo","lancer du javelot","lancer du marteau","lancer du poids","luge","lutte","marche","marche aquatique","marche athletique","marche nordique","marche sportive","monocycle","moto","moto cross","moto-ball","motoneige","mountainboard","musculation","naginata","natation","natation synchronisee","netball","ninjitsu","nunchaku","omnikin","padel","paintball","pancrace","parachutisme","paramoteur","parapente","parkour","patinage","patinage artistique","patinage de vitesse","peche","pelote basque","pencak-silat","pentathlon","pesäpallo","petanque","peteca","pilates","ping pong","planche a voile","plongee","plongeon","pole dance","polo","qi gong","quad","quilles","qwan ki do","raffa volo","rafting","ragga","raid","rallycross","rallye","randonnee","rink hockey","rock","rodeo","roller","rugby","rugby subaquatique","salsa","samba","sambo","sarbacane","saut a la perche","saut en longueur","sauvetage","self defense","sepak takraw","skateboard","skeleton","ski","ski acrobatique","ski alpin","ski de fond","ski nautique","skicross","slackline","slamball","snorkeling","snowboard","snowkite","softball","speed riding","speleologie","spinning","squash","sumo","surf","taekwondo","tai chi","tambourin","tango","tchoukball","tennis","tennis de table","teqball","tir","tir a l'arc","tractor pulling","trail","traineaux","trampoline","triathlon","tricking","trottinette","tumbling","twirling baton","ulm","ultimate","ultimate fresbee","varappe","velo","voile","volleyball","voltige","vovinam viet vo dao","vtt","wakeboard","waterpolo","watfit","wing chun","wingsuit","yoga","yoseikan budo","yukigassen","zumba"
        };

        public MotSports()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
