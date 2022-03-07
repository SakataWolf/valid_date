using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano;
        }
        static void Main(string[] args)
        {
            Data dat;

            Console.Write("Dia:");
            dat.dia = int.Parse(Console.ReadLine());
            Console.Write("Mês:");
            dat.mes = int.Parse(Console.ReadLine());
            Console.Write("Ano:");
            dat.ano = int.Parse(Console.ReadLine());

            if (dat.dia <= 31 && dat.dia >= 1 && dat.mes == 1||dat.mes == 3 || dat.mes == 5 || dat.mes == 7 || dat.mes == 8 || dat.mes == 10 || dat.mes == 12 && dat.ano <= 2022 )
            {
             Console.WriteLine("\n\nA Data {0}/{1}/{2} é valida", dat.dia, dat.mes, dat.ano);
            }
            else if (dat.dia <= 31 && dat.dia >= 1 && dat.mes == 4 || dat.mes == 6 || dat.mes == 9 || dat.mes == 11 && dat.ano <= 2022)
            {
             Console.WriteLine("\n\nA Data {0}/{1}/{2} é valida", dat.dia, dat.mes, dat.ano);
            }
            else if (dat.dia <= 31 && dat.dia >= 1 && dat.mes == 2 && dat.ano % 4 == 0 && dat.ano % 100 !=0 || dat.ano % 400 == 0 && dat.ano <= 2022)
            {
             Console.WriteLine("\n\nA Data {0}/{1}/{2} é valida", dat.dia, dat.mes, dat.ano);
            }
            else
            {
                Console.WriteLine("\n\nA Data é invalida");
            }
            Console.ReadKey();
        }
    }
}
