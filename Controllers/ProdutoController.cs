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

        public void Listar()
        {
            produtoView.MostrarNoConsole(produtoModel.Ler());
        }

        public void Filtrar(string _preco)
        {
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            
            produtoView.MostrarNoConsole(lista);

        }

    }
}