using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatounNumeroStamparelaLetteraInAsciiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char carattereascii;
            int ndecimale;
            Console.Write("Inserisci un numero dell'ascii code: ");
            ndecimale = Convert.ToInt32(Console.ReadLine());
            carattereascii = Convert.ToChar(ndecimale);
            Console.WriteLine($"Il Numero - {ndecimale}, carattere ASCII - {carattereascii}");
            Console.ReadLine();

        }
    }
}
