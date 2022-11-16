using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VægtabsBeregnerEksamen;

namespace VægtabsBeregnerEksamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indsaml information om brugeren
            Bruger bruger = Bruger.Information();

            //Udregn det daglige kalorieindtag for at vedligeholde vægt ved at udregne aktivitetsniveau for brugeren
            double DagligVedligehold = UdregningAfDagligVedligehold.UdregnDaglig(bruger, UdregnAktivitetsNiveau.Aktivitetsniveau());


            //Udregn det justerede kaloriemål på baggrund af kg/uge
            double dagligjusteretkal = UdregningAfDagligJusteret.DagligeKalorierJusteret(bruger, DagligVedligehold);

            //Udskriv en overskuelig summering af de udregnede informationer.
            printinfo.Print(bruger, DagligVedligehold, dagligjusteretkal);


            //Console Readkey for at holde concollen åben
            Console.ReadKey();

        }
    }
}
