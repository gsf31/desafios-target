//1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência. 
using System;
using System.Collections.Generic;

class ProgramaFibonacci
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci (ou digite 'sair' para encerrar): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            try
            {
                int numero = int.Parse(entrada);
                string resultado = PertenceAFibonacci(numero);
                Console.WriteLine(resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno. Por favor, digite um número inteiro dentro do intervalo permitido.");
            }
        }
    }

    static string PertenceAFibonacci(int numero)
    {
        List<int> sequenciaFibonacci = new List<int> { 0, 1 };

        while (sequenciaFibonacci[sequenciaFibonacci.Count - 1] < numero)
        {
            int ultimo = sequenciaFibonacci[sequenciaFibonacci.Count - 1];
            int penultimo = sequenciaFibonacci[sequenciaFibonacci.Count - 2];
            sequenciaFibonacci.Add(ultimo + penultimo);
        }

        if (sequenciaFibonacci.Contains(numero))
        {
            return $"O número {numero} pertence à sequência de Fibonacci.";
        }
        else
        {
            return $"O número {numero} não pertence à sequência de Fibonacci.";
        }
    }
}


