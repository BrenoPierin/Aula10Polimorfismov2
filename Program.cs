using System;

namespace Aula10Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio rela = new Relatorio();
            System.Console.WriteLine("Digite a data");
            rela.data = DateTime.Parse(Console.ReadLine());
            rela.MostrarRelatorio();

            System.Console.WriteLine("-------------------------");

            Mensal mensal = new Mensal();
            System.Console.WriteLine("Digite a data");
            mensal.data = DateTime.Parse(Console.ReadLine());
            mensal.MostrarRelatorio();

            System.Console.WriteLine("--------------------------");

            Anual anual = new Anual();
            System.Console.WriteLine("Digite a data");
            anual.data = DateTime.Parse(Console.ReadLine());
            anual.MostrarRelatorio();

        }
    }
}
