using System;
using System.Diagnostics;
using System.IO;

namespace TextEditor
{

    class Program
    {
        
        static void Main(string[] args)
        {
                
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1- Abrir Arquivo");
            Console.WriteLine("2- Novo Arquivo");
            Console.WriteLine("0- Sair");
            short option = short.Parse(Console.ReadLine());
                
            switch (option) {
                case 0:
                    System.Environment.Exit(0);
                    break;
                    
                case 1:
                    Console.Clear();
                    Open();
                    break;
                        
                case 2:
                    Console.Clear();
                    New();
                    break;
                    
                default: 
                    Menu();
                    break;


            }
        }

        static void Open()
        { 
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");    
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd(); //le o arquivo ate o fim
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }

        static void New()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto: (ESC para sair)");
            Console.WriteLine("_______________________");
            String text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //adicionar nova linha
            } while
                (Console.ReadKey().Key != ConsoleKey.End); //enquant END nao for pressionado, o usuario pode escrever

            Save(text);

        }

        static void Save(string text)
            {
                Console.Clear();
                Console.WriteLine("qual o caminho para salvar o arquivo");
                var path = Console.ReadLine(); 
                //escreva o caminho: home/felipe/'nome do arquivo'.txt

                using (var file = new StreamWriter(path)) //abre e fecha o arquivo, evitando problemas
                {
                   file.Write(text); 
                    
                }
                Console.WriteLine($"arquivo salvo em {path}");
                Thread.Sleep(1000);
                Menu();
            }
                

        }
    }
