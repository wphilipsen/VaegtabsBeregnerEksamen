using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VægtabsBeregnerEksamen
{
    internal class printinfo
    {
        public static void Print(Bruger bruger, double dagligVedligehold, double dagligjusteretkal)
        {
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Hej {bruger.Navn}");
            Console.WriteLine($"For at opnå en ønsket vægt på {bruger.ØnskedeVægt} i løbet af {bruger.Deadline} uger,");
            Console.WriteLine($"vil det kræve et daglig kalorieindtag på {Math.Round(dagligjusteretkal)} kcal.");

        }
    }
}
