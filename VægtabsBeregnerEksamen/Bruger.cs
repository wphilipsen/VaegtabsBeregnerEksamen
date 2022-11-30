using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VægtabsBeregnerEksamen
{
    internal class Bruger
    {
        public string Navn { get; set; }
        public int Vægt { get; set; }
        public int ØnskedeVægt { get; set; }
        public int Deadline { get; set; }
        public int Højde { get; set; }
        public int Alder { get; set; }
        public string Køn { get; set; }
        public double Aktivitetsniveau { get; set; }

        public static Bruger Information()
        {
            Bruger bruger = new Bruger();
            Console.WriteLine("Indtast brugerens navn");
            bruger.Navn = Console.ReadLine();
            bruger.Køn = ValgafKøn();

            Console.WriteLine("Indtast brugerens alder");
            bruger.Alder = GetInput();

            Console.WriteLine("Indtast brugerens højde");
            bruger.Højde = GetInput();
            

            Vægttab(bruger);

            return bruger;
        }

        private static string ValgafKøn()
        {
            Console.WriteLine("Indtast brugerens køn: mand / kvinde");
            string valgafkøn = Console.ReadLine().ToLower();
            if (valgafkøn != "mand" && valgafkøn != "kvinde")
            {
                Console.WriteLine("indtastning skal indehold enten mand eller kvinde");
                valgafkøn = ValgafKøn();
            }

            return valgafkøn;

        }
        private static int GetInput()
        {

            //Tryparse for at sikre at det indtastede er et tal 
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Indtast venligst kun tal.");
                Console.WriteLine();
                //hvis ikke krav opfyldt køres metoden igen, indtil den er tilfreds med indtastning
                input = GetInput();
            }
            return input;
        }
        private static void Vægttab(Bruger bruger)
        {
            Console.WriteLine("Indtast brugerens vægt");
            bruger.Vægt = GetInput();
            Console.WriteLine("Indtast brugerens ønskede vægt");
            bruger.ØnskedeVægt = GetInput();
            Console.WriteLine("Indtast ønskede deadline for vægttab i uger");
            bruger.Deadline = GetInput();
            RealistiskVægttab(bruger);
        }

        private static void RealistiskVægttab(Bruger bruger)
        {

            double kgPrUge = (bruger.Vægt - bruger.ØnskedeVægt) / bruger.Deadline;

            if (kgPrUge > 1 || kgPrUge < -1)
            {
                
                Console.WriteLine("Dette vægttab er urealistisk.");
                Console.WriteLine("Sigt efter max 1kg pr uge.");
                Vægttab(bruger);

            }

        }
    }
}
