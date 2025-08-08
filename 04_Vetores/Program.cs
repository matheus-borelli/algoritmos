using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável
            //Sintaxe: tipo nomeVariavel = valor
            string nome = "User";
            Console.WriteLine("User Name");

            //Declaração de vetores
            //Sintaxe: tipo[] nomeVariavel = {valor1,valor2,valor3};
            string[] nomes = { "UserUm", "UserDois", "UserTrês","João", "José", "Maria" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            //Sintaxe: for( indice; controle; incrimento)
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("{0}° Nome: {1}",i+1, nomes[i]); 
            }

            //Impressão dos 100 primeiros números
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine("Número: {0}", i);
            }

            // Loop foreach
            // Sintaxe: foreach( variavel in vetor )
            foreach (string varName in nomes) 
            {
                Console.WriteLine("Nome: {0}", varName)
            }
        }
    }
}
