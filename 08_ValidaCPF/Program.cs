using System;

using System;

using System.Linq;

using System.Text.RegularExpressions;

namespace _08_ValidaCPF

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Digite o CPF: ");

            string cpf = Console.ReadLine();

            // 1 - Eliminar caractres não numéricos

            //cpf.replace("'.", "");

            //cpf.Replace("'-", "");

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            // 2 - Validar se tem 11 digitos

            if (cpf.Length != 11)

            {

                Console.WriteLine("CPF deve conter 11 digitos");

                return;

            }

            // 3- Validas CPFs com todos os números iguais

            /* if( cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||

                 cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||

                 cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"                 

             )*/

            if (cpf.Distinct().Count() == 1)

            {

                Console.WriteLine("CPF inválido! Números repetidos não são permitidos");

                return;

            }

            //4 - Cálculo do 1º Digito verificador

            //int soma = 0;

            //char[] cpfVetor = cpf.ToCharArray();

            //for (int i = 0; i < 9; i++)

            //{

            //    soma += int.Parse(cpfVetor[i].ToString()) * (10 - i);

            //}

            //int resto = soma % 11;

            //int digX = 0;

            //if (resto >= 2)

            //{

            //    digX = 11 - resto;

            //}

            int digX = CalculaDV(cpf, 9, 10);

            //5 - Cálculo do 2º Digito Verificador

            //soma = 0;

            ////char[] cpfVetor = cpf.ToCharArray();

            //for (int i = 0; i < 10; i++)

            //{

            //    soma += int.Parse(cpfVetor[i].ToString()) * (11 - i);

            //}

            //resto = soma % 11;

            //int digY = 0;

            //if (resto >= 2)

            //{

            //    digY = 11 - resto;

            //}

            int digY = CalculaDV(cpf, 10, 11);

            //6 - Comparar os dígitos

            if (

                int.Parse(cpf[9].ToString()) == digX &&

                int.Parse(cpf[10].ToString()) == digY

               )

            {

                Console.WriteLine("CPF VÁLIDO!");

            }

            else

            {

                Console.WriteLine("CPF INVÁLIDO!");

            }

        }

        public static int CalculaDV(string cpf, int qtdeNumeros, int peso)

        {

            int soma = 0;

            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < 9; i++)

            {

                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);

            }

            int resto = soma % 11;

            int digito = 0;

            if (resto >= 2)

            {

                digito = 11 - resto;

            }

            return digito;

        }

    }

}

