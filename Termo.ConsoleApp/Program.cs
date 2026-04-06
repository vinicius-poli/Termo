﻿namespace Termo.ConsoleApp;

using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {           
        ExibirCabecalho();

        ExecutarTentativas();           
    }
    static void ExibirCabecalho()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Código para exibir o caracter quadrado
        Console.WriteLine("-----------------------");
        Console.WriteLine("        TERMO");
        Console.WriteLine("-----------------------");
        Console.WriteLine("\u25A1\u25A1\u25A1\u25A1\u25A1"); //QUADRADOS
    }
    static string SortearPalavraAleatoria()
    {
        string[] palavras = [
            "IDEIA",
            "TREVO",
            "PLANO",
            "MUNDO",
            "FESTA"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        return palavraAleatoria;
    }
    static void ExecutarTentativas()
    {
        bool jogoTerminou = false;
        int numeroDeTentativas = 0;
        string palavraAleatoria = SortearPalavraAleatoria();

        while (jogoTerminou == false)
        {   
            string palavraEscolhida = InserirPalavra();                   

            ImpressaoDasLetras(palavraAleatoria, palavraEscolhida);            

            numeroDeTentativas++;

            if (palavraEscolhida == palavraAleatoria)
            {
                ColorirTexto("azul");
                Console.WriteLine("---------------");
                Console.WriteLine("Você venceu!!");
                Console.WriteLine("---------------");
                ColorirTexto("branco");
                break;                
            }

            if (numeroDeTentativas == 5)
            {
                ColorirTexto("lilas");
                Console.WriteLine("---------------");
                Console.WriteLine("Você perdeu!!");
                Console.WriteLine("---------------");
                ColorirTexto("branco");
                jogoTerminou = true;
            }            
        }
        Console.ReadLine();  
    }
    static string InserirPalavra()
    {
        Console.Write("Digite uma palavra: ");
            string? palavraEscolhida = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(palavraEscolhida) ||
            palavraEscolhida.Length !=5 ||
            !palavraEscolhida.All(c => char.IsLetter(c)))
            {
                Console.WriteLine("Digite uma palavra com 5 letras!");
                continue;
            }
            palavraEscolhida = palavraEscolhida.ToUpper();

            return palavraEscolhida;   
    }
    static void ImpressaoDasLetras(string palavraAleatoria, string palavraEscolhida)
    {
        for (int contador = 0; contador < palavraAleatoria.Length; contador++)
            {   
                char letraAtual = palavraAleatoria[contador];
                char letraChute = palavraEscolhida[contador];

                if (letraChute == letraAtual)
                {
                    ColorirTexto("verde");
                }

                else
                {          
                    for (int j = 0; j < palavraAleatoria.Length; j++)               
                    { 
                        letraAtual = palavraAleatoria[j]; 
                        
                        if (letraAtual == letraChute && contador != j)
                        {                          
                            ColorirTexto("amarelo");
                            break;                       
                        }                        
                        
                        else if (letraAtual != letraChute)
                        {
                            ColorirTexto("vermelho");                    
                        }
                    }                                 
                }
                Console.Write(letraChute);
                ColorirTexto("branco");                                                
            }
            Console.WriteLine();
    }
    static void ColorirTexto(string cor = "branco")
    {
        if (cor == "branco")
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (cor == "verde")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (cor == "amarelo")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (cor == "vermelho")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        else if (cor == "lilas")
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else if (cor == "azul")
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
    }
}

