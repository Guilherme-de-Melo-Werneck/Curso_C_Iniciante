using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto.Aula22
{
    internal class exemplo7
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double vhora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            vhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = vhora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
