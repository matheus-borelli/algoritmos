using System;

class Idade
{
    static void Main()
    {
        int idade;
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine("Você é Criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Você é Adolescente");
        }
        else if (idade <= 60)
        {
            Console.WriteLine("Você é Adulto");
        }
        else
        {
            Console.WriteLine("Você é Idoso");
        }
    }
}
