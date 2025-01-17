using System;
using System.Numerics;
using Microsoft.VisualBasic.FileIO;

namespace Calculator
{

    file class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Calculator!");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão"); 
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione uma opção:");
            short opcao = short.Parse(Console.ReadLine());
        
            switch(opcao)

            {
                case 1:
                    Console.Clear();
                    Soma();
                    break;
                case 2:
                    Console.Clear();
                    Subtracao();
                    break;
                case 3:
                    Console.Clear();
                    Divisao();
                    break;
                case 4:
                    Console.Clear();
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0); //usado para sair da interface
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;


            }

        }
        static void Soma() //criei uma função p soma e posso chama-la no main
        {
            Console.WriteLine("digite um valor: ");
            //float valor1 = Console.ReadLine(); //desse jeito vira string
            float valor1 = float.Parse(Console.ReadLine());//readline esera o usuario dar o enter no terminal
            Console.WriteLine("digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float soma = valor1 + valor2;
            // Console.WriteLine("o resultado da soma é:" + soma); //o + servirá para concatenar 
            Console.WriteLine($"o resultado da soma é: {soma}" ); //($"  {variavel}" para inserir no meio do texto
            //Console.WriteLine($"o resultado da soma é: {valor1+valor2}" ); //posso fazer o calculo dentro das chaves
            Console.ReadKey();
            Menu(); //para que o programa volte ao menu
        }

        static void Subtracao()
        {
            Console.WriteLine("digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float sub= valor1 - valor2;
            
            Console.WriteLine($"O resutado da subtração é:{sub}");
            Console.ReadKey();//para o programa não fechar ao fim da primeira função chamada no main
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float divisao = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é: {divisao}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine()); 
            Console.WriteLine("digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float multiplicacao = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
            Console.ReadKey();
            Menu();
        }
    }
}
