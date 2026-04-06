﻿namespace Termo.ConsoleApp;

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
        
        Console.WriteLine("-----------------------");
        Console.WriteLine("        TERMO");
        Console.WriteLine("-----------------------");
        Console.Write("Digite uma palavra: ");
        string? palavraEscolhida = Console.ReadLine();        
                   
        Console.WriteLine("\u25A1\u25A1\u25A1\u25A1\u25A1");
                        
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