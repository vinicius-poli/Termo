namespace Termo.ConsoleApp;
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

        char[] letrasAcertadas = new char [palavraAleatoria.Length];

        for (int i = 0; i < palavraAleatoria.Length; i++)
        {
            letrasAcertadas[i] = '*';
        }
        Console.WriteLine(letrasAcertadas);     
        Console.WriteLine(palavraAleatoria);

        Console.Write("Digite uma letra: ");
        Console.ReadLine();     
    }
}
