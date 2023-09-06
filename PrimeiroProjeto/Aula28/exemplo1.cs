using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Aula28
{
    internal class exemplo1
    {
        static void Main(string[] args)
        {
            int horas;

            Console.Write("Digite as horas ? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa tarde");
            }
        }
    }
}
