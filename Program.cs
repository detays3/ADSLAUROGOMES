using System;

class Program
{
    static int BinarioParaDecimal(int[] binario)
    {
        int decimalNumber = 0;
        int potencia = 0;

        for (int i = binario.Length - 1; i >= 0; i--)
        {
            if (binario[i] == 1)
                decimalNumber += (int)Math.Pow(2, potencia);

            potencia++;
        }

        return decimalNumber;
    }

    static void Main(string[] args)
    {
        // Solicita ao usuário que insira um número binário
        Console.Write("Digite um número binário: ");
        string binarioInput = Console.ReadLine();

        // Verifica se a entrada contém apenas 0s e 1s
        foreach (char c in binarioInput)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("Entrada inválida. Por favor, insira apenas 0s e 1s.");
                return;
            }
        }

        // Converte a entrada do usuário para um array de inteiros
        int[] binario = new int[binarioInput.Length];
        for (int i = 0; i < binarioInput.Length; i++)
        {
            binario[i] = binarioInput[i] - '0'; // Convertendo caractere para inteiro
        }

        // Converte o número binário para decimal e imprime o resultado
        int decimalValue = BinarioParaDecimal(binario);
        Console.WriteLine("O número decimal equivalente é: " + decimalValue);

        // Mantém o console aberto até que o usuário pressione Enter
        Console.ReadLine();
    }
}
