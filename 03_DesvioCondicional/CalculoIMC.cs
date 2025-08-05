using System;

class CalculoIMC
{
    static void Main()
    {
        double peso, altura, imc;

        Console.WriteLine("Digite seu peso (kg):");
        // Lê o peso e converte para double
        peso = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura (m):");
        // Lê a altura e converte para double
        altura = Double.Parse(Console.ReadLine());

        // Calcula o IMC
        imc = peso / (altura * altura);

        // Mostra o IMC com 3 casas decimais
        Console.WriteLine("Seu IMC é {0:F3}", imc);
		
		if( imc < 18.5)
		{
			Console.WriteLine("Classificação: abaixo do peso");
		}else if (imc < 25)
		{
		Console.WriteLine("Classificação:peso normal");
		}else
		{
		Console.WriteLine("Classificação:Acima do peso");
		}
    }
}
