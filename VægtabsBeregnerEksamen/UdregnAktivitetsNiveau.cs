using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VægtabsBeregnerEksamen;

namespace VægtabsBeregnerEksamen
{
    internal class UdregnAktivitetsNiveau
    {
        //Metode til at finde ud af hvor aktiv et job brugeren har
        private static int JobAktivitetUdregner()
        {
            Console.WriteLine("Vælg hvilken af følgende der bedst beskriver dit arbejde");
            Console.WriteLine();
            Console.WriteLine("1. Passivt job - Siddende det meste af dagen");
            Console.WriteLine("2. Moderat aktiv job - Stående det meste af dagen");
            Console.WriteLine("3. Aktivt job - Mere eller mindre i konstant bevægelse");
            Console.WriteLine();

            //Tryparse for at sikre at det indtastede er et tal || og mellem 1 og 3 så der ikke kan vælges noget udenfor valgmulighederne
            if (!int.TryParse(Console.ReadLine(), out int jobaktivitet) || jobaktivitet < 1 && jobaktivitet > 3)
            {
                Console.WriteLine("vælg venligst en af valgmulighederne:");
                Console.WriteLine();
                //hvis ikke krav opfyldt køres metoden igen, indtil den er tilfreds med indtastning
                JobAktivitetUdregner();
            }
            return jobaktivitet;
        }

        //metode til at finde ud af hvor aktivt brugeren er
        private static int TræningsAktivitetUdregner()
        {
            Console.WriteLine("Vælg hvilken af følgende der bedst beskriver din træningsaktivitet");
            Console.WriteLine();
            Console.WriteLine("1. Ingen struktureret træning");
            Console.WriteLine("2. 1 times daglig træning");
            Console.WriteLine("3. 2 timers daglig træning");
            Console.WriteLine();

            //Tryparse for at sikre at det indtastede er et tal || og mellem 1 og 3 så der ikke kan vælges noget udenfor valgmulighederne
            if (!int.TryParse(Console.ReadLine(), out int træningsaktivitet) || træningsaktivitet < 1 && træningsaktivitet > 3)
            {
                Console.WriteLine("vælg venligst en af valgmulighederne:");
                Console.WriteLine();
                //hvis ikke krav opfyldt køres metoden igen, indtil den er tilfreds med indtastning
                TræningsAktivitetUdregner();
            }
            return træningsaktivitet;
        }

        //metode til at sammenholde jobaktivitet og træningsaktivitet i et todimensionelt array for at finde det samlede aktivitets niveau
        public static double Aktivitetsniveau()
        {
            double[,] aktivitetgrid =
            {
                {1.55, 1.85, 2.2 },
                {1.85, 2.2, 2.4 },
                {2.2, 2.4, 2.6 }
            };
            int træningaktivitet = TræningsAktivitetUdregner() - 1; // -1 da grid går fra 0-2, og vi bruger tal 1-3
            int jobaktivitet = JobAktivitetUdregner() - 1; // -1 da grid går fra 0-2, og vi bruger tal 1-3
            double totalaktivitet = aktivitetgrid[træningaktivitet, jobaktivitet];

            return totalaktivitet;

        }

    }
}
