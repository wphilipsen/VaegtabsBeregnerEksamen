using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VægtabsBeregnerEksamen
{
    internal class UdregningAfDagligJusteret
    {
        //metode til at udregne brugerens daglige kaloriemål i forhold til ønsket vægtjustering
        public static double DagligeKalorierJusteret(Bruger bruger, double dagligvedligehold)
        {
            //udregn brugerens total vægtjustering
            double totalvægtjustering = bruger.Vægt - bruger.ØnskedeVægt;

            //Udregning vægtjustering pr uge ud fra den ønskede vægjustering delt med deadline i uger.
            //Eftersom 1kg svarer til 7700 kalorier ganges vægtjsutering pr uge og deles med 7 for at få en daglig kaloriejustering
            double dagligkaloriejustering = ((totalvægtjustering / bruger.Deadline) * 7700) / 7;

            //Da vi gerne vil kunne udregne ønske om vægtforøgelse også tjekkes om totalt vægtjustering er et positivt diference eller negativt
            if (totalvægtjustering > 0)
            {
                //ved en positiv difference forstås det som vægttab, og den daglige kalorie justering skal derfor trækkes fra det daglige vedligehold
                return (dagligvedligehold - dagligkaloriejustering);
            }
            else
            {
                //ved en negativ difference forstås det som vægtforøgelse, og den daglige kalorie justering skal derfor lægges til det daglige vedligehold
                return (dagligvedligehold + (dagligkaloriejustering * -1)); //ganges med -1 for at få et positivt tal
            }

        }

    }
}
