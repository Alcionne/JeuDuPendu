using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    class MotTransports : Mot
    {
        new List<string> mot = new List<string>
        {
            "accon","aerobus","aerodyne","aeroglisseur","aeronef","aeroplane","aerostat","aerotrain","ascenseur","autobus","autocar","automobile","avion","barque","bateau","bateau mouche","bicyclette","bobsleigh","brouette","bus","caleche","camion","camionnette","canoe","canot","car","carriole","carrosse","catamaran","chameau","char","charrette","cheval","cyclomoteur","deltaplane","diligence","dirigeable","dromadaire","echasses","elephant","escalator","escaliers roulants","esquif","fiacre","fourgon","funiculaire","fusee","galere","goelette","gondole","helicoptere","hoverboard","hydravion","intercite","jet","jetpack","jonque","kayak","landau","langoustier","ligneur","limoniere","limousine","locomobile","locomotive","locomotrice","locotracteur","ludospace","luge","metro","monocycle","monoroue","montgolfiere","moto","motoneige","navette","navire","omnibus","overboard","paddle","papamobile","paquebot","parachute","parapente","patins a roulettes","pedalo","peniche","petrolier","pirogue","planche-a-voile","planeur","pousse-pousse","poussette","quad","quadricycle","quadrimoteur","quadrireacteur","radeau","rer","rickshaw","roller","rosalie","scooter","segway","side-car","skate","skateboard","ski","ski nautique","ski nordique","snowboard","sous-marin","sulky","tandem","tank","tapis roulant","taxi","telepherique","telesiege","tgv","tracteur","train","tramway","tricycle","triporteur","trottinette","tuk-tuk","tyrolienne","ulm","velo","voilier","voiture","wagon","yacht","yole","zeppelin","zodiac",
        };

        public MotTransports()
        {
            motATrouver = TirageAuSort(mot);
        }
    }
}
