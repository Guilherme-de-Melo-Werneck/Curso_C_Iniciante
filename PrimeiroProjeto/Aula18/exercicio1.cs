//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

//namespace PrimeiroProjeto.Aula18
//{
//    internal class exercicio1
//    {
//        static void Main(string[] args)
//        {
//            string nome = Console.ReadLine();
//            int quarto = int.Parse(Console.ReadLine());
//            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            string[] vet = Console.ReadLine().Split(' ');
//            string nomeUsuario = vet[0];
//            int idade = int.Parse(vet[1]);
//            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

//            Console.WriteLine("Informações digitadas: ");
//            Console.WriteLine("Entre com seu nome completo: " + nome);
//            Console.WriteLine("Quantos quartos tem na sua casa: " + quarto);
//            Console.WriteLine("Entre com o preço de um produto: " + preco.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Último nome do usuário: " + nomeUsuario);
//            Console.WriteLine("Idade: " + idade);
//            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

//        }
//    }
//}
