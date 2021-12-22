using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Filme
    {
        private string titulo;
        private int duracao;
        private Genero genero;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }
        internal Genero Genero { get => genero; set => genero = value; }
    }
}
