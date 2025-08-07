using System;
class ParImper
{
	static void main
	{
		int numero;
		
		console.WriteLine("Digite um número: ");
		numero = int.Parse(Console.ReadLine() );
		
		if (numero %2 ==0)
		
			Console.WriteLine("Número é Par! ");
		else	
			Console.WriteLine("Número é Imper! ");
		}
			
	}	