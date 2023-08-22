using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto.Aula22
{
    internal class exemplo10
    {
        static void Main(string[] args)
        {
            int x;
            double y, kml;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            kml = (double) x / y;

            Console.WriteLine($"{kml.ToString("f3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
