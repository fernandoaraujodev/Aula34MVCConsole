using System;
using Aula34MVCConsole.Controllers;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando o Controller, pois View e Model já estão instanciados dentro dele
            ProdutoController produto = new ProdutoController();
            //produto.Listar();

            produto.Filtrar("21,98");// Não usar ponto para dividir centavos
        }
    }
}
