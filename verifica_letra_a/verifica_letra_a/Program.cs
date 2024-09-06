//2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre. 
using System;

class ProgramaVerificaLetraA
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra para verificar quantas letras 'a' ela tem: ");
        string entrada = Console.ReadLine();

        int quantidade = ContarLetraA(entrada);
        if (quantidade > 0)
        {
            Console.WriteLine($"Existem {quantidade} letras 'a' nessa palavra.");
        }
        else
        {
            Console.WriteLine("Essa palavra não tem letra 'a'.");
        }
    }

    static int ContarLetraA(string texto)
    {
        int contagem = 0;
        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contagem++;
            }
        }
        return contagem;
    }
}
