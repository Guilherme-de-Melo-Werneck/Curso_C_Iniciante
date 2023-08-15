//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

//namespace PrimeiroProjeto.Aula18
//{
//    internal class exemplo1
//    {
//        static void Main(string[] args)
//        {
//            int n1 = int.Parse(Console.ReadLine());
//            char ch = char.Parse(Console.ReadLine());
//            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture = para escrever ponto ao inves da vírgula

//            string[] vet = Console.ReadLine().Split(' ');
//            string nome = vet[0];
//            char sexo = char.Parse(vet[1]);
//            int idade = int.Parse(vet[2]);
//            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


//            Console.WriteLine("Você digitou: ");
//            Console.WriteLine(n1);
//            Console.WriteLine(ch);
//            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); //ToString("F2") = imprimir 2 números depois da vírgula
//                                                                                //CultureInfo.InvariantCulture = imprimir resultado com . ao inves de vírgula
//            Console.WriteLine(nome);
//            Console.WriteLine(sexo);
//            Console.WriteLine(idade.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
//        }
//    }
//}
