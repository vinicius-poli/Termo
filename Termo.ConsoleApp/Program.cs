namespace Termo.ConsoleApp;

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

        char[] letrasSeparadasPalavraAleatoria = new char [palavraAleatoria.Length];

        Console.Write("Digite uma palavra: ");
        string? palavraEscolhida = Console.ReadLine();

        char[] letrasSeparadasPalavraEscolhida = new char [palavraAleatoria.Length];

        for (int i = 0; i < palavraAleatoria.Length; i++)
        {
            letrasSeparadasPalavraEscolhida[i] = '*';
        }
             
        Console.WriteLine(palavraAleatoria);
                        
        for (int contador = 0; contador < palavraAleatoria.Length; contador++)
        {   
            char letraAtual = palavraAleatoria[contador];            

            for (int j = 0; j < palavraAleatoria.Length; j++)
            {
                char letraChute = palavraEscolhida[j];                

                if (letraAtual == letraChute)
                {   
                    if (contador == j)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        letrasSeparadasPalavraEscolhida[contador] = letraChute;
                        Console.Write(letraChute);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        letrasSeparadasPalavraEscolhida[contador] = letraChute;
                        Console.Write(letraChute);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }    
                
                else if (letraAtual != letraChute && contador == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    letrasSeparadasPalavraEscolhida[contador] = letraChute;
                    Console.Write(letraChute);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                       
            }
            
                                            
        }
        //Console.WriteLine(letrasSeparadasPalavraEscolhida);
    }
}


// for escolhida
    //for aleatoria
    // if Escolhida[x] = Escolhida[x] Letra Verde
    // if Escolhida[x] = Escolhlida[não x] Letra Amarela
    // if Escolhida[x] != Escolhlida[x] Letra Vermelha


