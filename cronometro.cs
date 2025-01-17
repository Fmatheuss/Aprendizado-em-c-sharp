using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("começar!");
            Thread.Sleep(1000);
            
            Start(time);
            
        }
        
        static void Start(int time) //time virou um parametro que pode ser escolhido no main
        {
            
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);//faz a aplicação espera uma quantidade x em milissegundos para atualizar o valor
            }
            Console.Clear();
            Console.WriteLine("Contagem finalizada");
            Thread.Sleep(3000); //dou esse tempo para finalizar a tela
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cronometro");
            Console.WriteLine("S - Segundo => 10s= 10 segundos");
            Console.WriteLine("M - Minuto => 1ms= 1 minuto");
            Console.WriteLine("0 - Sair =>");
            Console.WriteLine("----------------------");
            
       
            
            string data = Console.ReadLine().ToLower(); //to.lower faz tudo que o usuario enviar ficar minusculo
            char type = char.Parse(data.Substring(data.Length-1, 1));//substring, pega a cadeia de caracteres que o usuari imputou e vc escolhe qual deles quer pegar para si
            //.lenght-1 faz com que ele conte o numero de carac-1(contagem a partir de 0) para que a gente sempre pegue oultimo caracter
            
            int time = int.Parse(data.Substring(0, data.Length-1));
            
            
            int multiplier = 1;
           
            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {System.Environment.Exit(0);}
            
            PreStart(time*multiplier);
            
           Menu();
                
            }
        }
    }

