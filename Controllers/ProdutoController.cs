using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {

        // Usar CRTL + . 
        // Adiciona a classe produto ao contexto atual (using Aula34MVCConsole.Models;)
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        /// <summary>
        /// Mostra a lista
        /// </summary>
        public void Listar()
        {
            produtoView.MostrarNoConsole(produtoModel.Ler());
        }

        /// <summary>
        /// Filtro de busca baseado no preço do produto
        /// </summary>
        /// <param name="_preco">Preço do produto buscado</param>
        public void Filtrar(string _preco)
        {
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            
            produtoView.MostrarNoConsole(lista);

        }

    }
}