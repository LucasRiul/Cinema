using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Genero
    {
        private string descricao;
        private List<Filme> filmes = new List<Filme>();

        public string Descricao { get => descricao; set => descricao = value; }
        internal List<Filme> Filmes { get => filmes; set => filmes = value; }

        public void AdicionarFilme(Filme filme)
        {
            filmes.Add(filme);
        }

        public void ListarFilmes()
        {

            foreach (Filme filme in Filmes)// vai pegar sempre do início ao fim da lista
            {

                Console.WriteLine("Genero: " + descricao);
                Console.WriteLine("Titulo : " + filme.Titulo);
                Console.WriteLine("Duração: " + filme.Duracao);


            }
        }
    }
}
