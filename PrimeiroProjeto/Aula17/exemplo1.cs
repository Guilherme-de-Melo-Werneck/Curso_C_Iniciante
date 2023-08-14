using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Aula17
{
    internal class exemplo1
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x  = Console.ReadLine();
            string y =  Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
