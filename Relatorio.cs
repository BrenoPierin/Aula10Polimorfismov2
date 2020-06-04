using System;

namespace Aula10Desafio
{
    public class Relatorio
    {
        public DateTime data {get; set;}


         public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrando relatório geral");
         }
         

    }
}