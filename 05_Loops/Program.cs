using System;
using System.Linq;


namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
            //criação de um vetor para armazenamento de 100 elementos
            //string [] nomes= {"UserUm", "UserDois", "UserTrês}
        {
            string[] nomes = new string[100];
            string continuar = "S";
            int contador = 0;

            //Loop while
            //Sintaxe: while( expressão booleana)
            //método ToUpper
            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0} nome:  ", contador);
                
                nomes[contador] = Console.ReadLine();

                contador++;
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Nomes informados:");
            foreach(string str in nomes)
            {
                // != significa diferente
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
