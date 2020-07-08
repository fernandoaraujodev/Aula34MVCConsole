using System;
using System.Collections.Generic;
using Aula34MVCConsole.Models;

namespace Aula34MVCConsole.Views
{
    public class ProdutoView
    {
        /// <summary>
        /// Imprime os produtos da lista no Console
        /// </summary>
        /// <param name="lista">lista de produto adicionados</param>
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista)
            {
                Console.WriteLine($"Cod. {item.Codigo} = {item.Nome} -> R${item.Preco}");
            }
        }
    }
}