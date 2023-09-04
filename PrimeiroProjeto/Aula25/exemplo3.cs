//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

//Formula:
// a = (x + y + Math.Abs(x - y)) /2;
// b = (a + z + Math.Abs(a - z)) /2;


//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

//Entrada
//O arquivo de entrada contém três valores inteiros.

//Saída
//Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PrimeiroProjeto.Aula25
//{
//    internal class exemplo3
//    {
//        static void Main(string[] args) 
//        {
//            int x, y, z, a, b;
//            string[] valores = Console.ReadLine().Split(' ');
//            x = int.Parse(valores[0]);
//            y = int.Parse(valores[1]);
//            z = int.Parse(valores[2]);

//            a = (x + y + Math.Abs(x - y)) /2;
//            b = (a + z + Math.Abs(a - z)) /2;

//            Console.WriteLine($"{b} eh o maior");




//        }
//    }
//}
