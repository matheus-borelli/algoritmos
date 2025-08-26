using System;
using System.Diagnostics;
using System.Linq;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o mês (1..12):");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            //Descobre a quantidade de dias de um mês
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            //Descobre o dia da semana do primeiro dia do mês
            // 0 = Domingo - 6 = Sábado
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //Matriz de 6 semanas e 7 dias
            int[,] calendario = new int[6, 7];

            int dia = 1;

            //Preenche a matriz com dias do mês
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }

            // título do calendário
            Console.WriteLine($"\nCalendário de {primeiroDiaMes.ToString("MMMM")} de {ano}");
            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            //int[] diasFeriados = { };
            int[] diasFeriados = RetornaFeriados(mes, ano);
            //impressão de calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ResetColor();

                        Console.Write(calendario[semana, diaSemana].ToString("00") + "\t");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("\nFeriados ");
            for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[i] > 0)
                {
                    Console.Write($"{diasFeriados[i].ToString("00")}\t");
                }
            }

            Console.ResetColor();
            Console.ReadLine();

        }
        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            // feriados[indice++] = 11;
            // feriados[indice++] = 21;
            if (mes == 1)
            {
                feriados[indice++] = 1; //Confraternização Universal
            }
            else if (mes == 4)
            {
                feriados[indice++] = 21; //Tiradentes
            }
            else if (mes == 5)
            {
                feriados[indice++] = 1; //Dia do Trabalho
            }
            else if (mes == 7)
            {
                feriados[indice++] = 9;
            }

            else if (mes == 9)
            {
                feriados[indice++] = 7;
            }
            else if (mes == 10)
            {
                feriados[indice++] = 12;
            }
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12)
            {
                feriados[indice++] = 25;
            }
            return feriados;
        }
    }
}

