﻿//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
//Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

//Entrada
//O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, 
//representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

//Saída
//Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

//namespace PrimeiroProjeto.Aula22
//{
//    internal class exemplo8
//    {
//        static void Main(string[] args)
//        {
//            string nome;
//            double salariofixo, totalvenda, salariototal;

//            nome = Console.ReadLine();
//            salariofixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            totalvenda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

//            salariototal = totalvenda * 15 / 100 + salariofixo;

//            Console.WriteLine();

//            Console.WriteLine("TOTAL = R$ " + salariototal.ToString("F2", CultureInfo.InvariantCulture));


//        }
//    }
//}
