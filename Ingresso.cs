using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Ingresso
    {
        private int tipo;
        private Sessao sessao;
        private Cliente cliente; //ingresso identificado
        private Funcionario funcionario;

        public int Tipo { get => tipo; set => tipo = value; }
        public Sessao Sessao { get => sessao; set => sessao = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
