using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePenduDuJardinier
{
    abstract class Mot
    {
        public List<string> mot { get; set; }
        public string motATrouver { get; set; }
        public string TirageAuSort(List<string> l)
        {
            string mot = null;
            Random rnd = new Random();
            int v = rnd.Next(0, l.Count);
            mot = l[v];
            return mot;
        }
    }
}
