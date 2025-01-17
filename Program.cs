using System;
using System.Diagnostics;

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
                
                
            }

            static void New()
            {
                Console.Clear();
                Console.WriteLine("Digite seu texto: (ESC para sair)");
                Console.WriteLine("_______________________");
                string text = "";

                do
                {
                    text += Console.ReadLine();
                    text += Environment.NewLine;
                } while (Console.ReadKey().Key != ConsoleKey.Escape); //enquant ESC nao for pressionado, o usuario pode escrever
                
                Console.Write(text);
                

            }
        }
    }
