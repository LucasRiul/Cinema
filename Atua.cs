using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Atua
    {
        private string papel;
        private List<Filme> filmes = new List<Filme>();
        private List<Ator> atores = new List<Ator>();
        private Filme filme;
        private Ator ator;

        public string Papel { get => papel; set => papel = value; }
        internal List<Filme> Filmes { get => filmes; set => filmes = value; }
        internal List<Ator> Atores { get => atores; set => atores = value; }
        internal Filme Filme { get => filme; set => filme = value; }
        internal Ator Ator { get => ator; set => ator = value; }

        public void adicionarPapeis(Filme filme, Ator ator)
        {
            filmes.Add(filme);
            atores.Add(ator);
            
        }

        public string listarPapeis()
        {
            foreach(Filme filme in filmes)
            {
                Console.WriteLine("Ator: " + ator.Nome);
                Console.WriteLine("Papel: " + papel);
            }

            return null;
        }


    }
}
