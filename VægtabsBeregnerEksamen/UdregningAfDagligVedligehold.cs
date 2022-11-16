using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VægtabsBeregnerEksamen
{
    internal class UdregningAfDagligVedligehold
    {
        //Metode til udregning af daglige vedligeholdskalorier (BMR)
        //BMR Mænd: 10 x vægt + (6.25 x højde i cm) – (5 x alder) + 5
        //BMR Kvinder: 10 x vægt + (6.25 x højde i cm) – (5 x alder) -161
        public static double UdregnDaglig(Bruger bruger, double aktivitestniveau)
        {
            int resultat = 0;
            if (bruger.Køn == "mand")
            {
                resultat = (int)((10 * bruger.Vægt) + (6.25 * bruger.Højde) - (5 * bruger.Alder) + 5);
            }
            else if (bruger.Køn == "kvinde")
            {
                resultat = (int)((10 * bruger.Vægt) + (6.25 * bruger.Højde) - (5 * bruger.Alder) - 161);
            }
            return resultat * aktivitestniveau;

        }

    }
}
