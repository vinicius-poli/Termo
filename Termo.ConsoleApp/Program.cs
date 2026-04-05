﻿namespace Termo.ConsoleApp;

using System.Data.Common;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string[] palavras = [
            "IDEIA"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];        

        Console.Write("Digite uma palavra: ");
        string? palavraEscolhida = Console.ReadLine();        
                   
        Console.WriteLine(palavraAleatoria);
                        
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
        //Console.WriteLine(letrasSeparadasPalavraEscolhida);
    }
}


// for escolhida
    //for aleatoria
    // if Escolhida[x] = Escolhida[x] Letra Verde
    // if Escolhida[x] = Escolhlida[não x] Letra Amarela
    // if Escolhida[x] != Escolhlida[x] Letra Vermelha