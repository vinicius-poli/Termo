﻿namespace Termo.ConsoleApp;

using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Código para exibir o caracter quadrado
        string[] palavras = [
            "IDEIA",
            "TREVO",
            "PLANO",
            "MUNDO",
            "FESTA"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        bool jogadorAcertouPalavra = false;

        int numeroDeTentativas = 0;

        Console.WriteLine("-----------------------");
        Console.WriteLine("        TERMO");
        Console.WriteLine("-----------------------");
        Console.WriteLine("\u25A1\u25A1\u25A1\u25A1\u25A1"); //QUADRADOS
        
        while (jogadorAcertouPalavra == false)
        {                        
            Console.Write("Digite uma palavra: ");
            string? palavraEscolhida = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(palavraEscolhida) ||
            palavraEscolhida.Length !=5 ||
            !palavraEscolhida.All(c => char.IsLetter(c)))
            {
                Console.WriteLine("Digite uma palavra com 5 letras!");
                continue;
            }   

            palavraEscolhida = palavraEscolhida.ToUpper();               

            for (int contador = 0; contador < palavraAleatoria.Length; contador++)
            {   
                char letraAtual = palavraAleatoria[contador];
                char letraChute = palavraEscolhida[contador];

                if (letraChute == letraAtual)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                else
                {          
                    for (int j = 0; j < palavraAleatoria.Length; j++)               
                    { 
                        letraAtual = palavraAleatoria[j]; 
                        
                        if (letraAtual == letraChute && contador != j)
                        {                          
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;                       
                        }                        
                        
                        else if (letraAtual != letraChute)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;                    
                        }
                    }                                 
                }
                Console.Write(letraChute);
                Console.ForegroundColor = ConsoleColor.White;    
                                                
            }

            Console.WriteLine();

            numeroDeTentativas++;

            if (palavraEscolhida == palavraAleatoria)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("---------------");
                Console.WriteLine("Você venceu!!");
                Console.WriteLine("---------------");
                Console.ForegroundColor = ConsoleColor.White;
                jogadorAcertouPalavra = true;
            }

            if (numeroDeTentativas == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("---------------");
                Console.WriteLine("Você perdeu!!");
                Console.WriteLine("---------------");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }            
        }
        Console.ReadLine();  
    }
}
