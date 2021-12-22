using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
