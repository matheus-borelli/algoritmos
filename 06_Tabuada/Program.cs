using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número de 1 a 10: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 || numero <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    }
}
