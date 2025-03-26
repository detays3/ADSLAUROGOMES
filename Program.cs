using System;

class Program
{
    static void Main(string[] args)
    {
        // Variável para controlar se o programa deve continuar ou não
        bool continuar = true;

        // Loop principal do programa
        while (continuar)
        {
            // Menu de opções
            Console.WriteLine("Escolha a base para conversão:");
            Console.WriteLine("1. Decimal para Binário");
            Console.WriteLine("2. Decimal para Octal");
            Console.WriteLine("3. Decimal para Hexadecimal");
            Console.WriteLine("4. Sair");
            Console.Write("Digite sua escolha (1, 2, 3 ou 4): ");

            // Obter a escolha do usuário
            int escolha = Convert.ToInt32(Console.ReadLine());

            // Processar a escolha do usuário
            switch (escolha)
            {
                case 1:
                    // Conversão de decimal para binário
                    Console.Write("Digite o número decimal a ser convertido: ");
                    int numeroDecimal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O número {numeroDecimal} em binário é: {DecimalParaBinario(numeroDecimal)}");
                    break;
                case 2:
                    // Conversão de decimal para octal
                    Console.Write("Digite o número decimal a ser convertido: ");
                    int numeroOctal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O número {numeroOctal} em octal é: {DecimalParaOctal(numeroOctal)}");
                    break;
                case 3:
                    // Conversão de decimal para hexadecimal
                    Console.Write("Digite o número decimal a ser convertido: ");
                    int numeroHexadecimal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O número {numeroHexadecimal} em hexadecimal é: {DecimalParaHexadecimal(numeroHexadecimal)}");
                    break;
                case 4:
                    // Sair do programa
                    continuar = false;
                    break;
                default:
                    // Opção inválida
                    Console.WriteLine("Escolha inválida!");
                    break;
            }

            Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
        }
    }

    // Função para converter decimal para binário
    static string DecimalParaBinario(int numero)
    {
        return Convert.ToString(numero, 2);
    }

    // Função para converter decimal para octal
    static string DecimalParaOctal(int numero)
    {
        return Convert.ToString(numero, 8);
    }

    // Função para converter decimal para hexadecimal
    static string DecimalParaHexadecimal(int numero)
    {
        return Convert.ToString(numero, 16).ToUpper();
    }
}
