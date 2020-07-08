using System;
using System.Collections.Generic;
using System.IO;


namespace Aula34MVCConsole.Models
{
    public class Produto
    {
        public int Codigo {get;set;}
        public float Preco {get;set;}
        public string Nome {get;set;}
        private const string PATH = "Database/Produto.csv";
        
        public List<Produto> Ler(){

            //Criamos uma lista de produtos
            List<Produto> produto1 = new List<Produto>();

            //Transformamos as linhas encontradas em uma array de strings
            string [] lista = File.ReadAllLines(PATH);

            //Varremos este array de strings
            foreach(var linha in lista){

                //Quebramos cada linha da lista em partes
                string[] dados = linha.Split(';'); //dividindo a string em cada ;

                //Tratamento dos dados e adicionar um novo produto
                Produto prod = new Produto();
                prod.Codigo = Int32.Parse (SepararDados(dados[0]));
                prod.Nome   = SepararDados(dados[1]);
                prod.Preco  = float.Parse (SepararDados(dados[2]));

                //Adicionar o produto tratado na lista                
                produto1.Add(prod);

            }

            return produto1;

        }

        private string SepararDados(string _coluna){
            
            //cada informação esta assim
            //0       1
            //Nome = The Last Of Us II
            return _coluna.Split("=")[1];

        }

        
    }
}