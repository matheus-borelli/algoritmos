using System;

namespace _07_TempoDownload
{
    class Program
    {
        static void Main()
        {
            double tamanhoMB = 0, velocidadeMbps = 0;
            bool entradaValida = false;

            // Entrada e validação do tamanho do arquivo
            while (!entradaValida)
            {
                Console.Write("Informe o tamanho do arquivo (MB): ");
                if (double.TryParse(Console.ReadLine(), out tamanhoMB) || tamanhoMB > 0)
                {
                    entradaValida = true;
                }
                if (!entradaValida)
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            }

            entradaValida = false; // reset para validar a próxima entrada

            // Entrada e validação da velocidade da internet
            while (!entradaValida)
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                if (double.TryParse(Console.ReadLine(), out velocidadeMbps) || velocidadeMbps > 0)
                {
                    entradaValida = true;
                }
                if (!entradaValida)
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            }

            // Cálculo do tempo em minutos
            double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            double tempoMinutos = tempoSegundos / 60;

            // Saída formatada com 2 casas decimais
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
        }
    }
}
