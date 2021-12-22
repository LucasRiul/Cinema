using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Sala
    {
        private int nrSala;
        private int capacidade;
        private List<Sessao> sessoes = new List<Sessao>();
        //Sessao sessoes2;


        public int NrSala { get => nrSala; set => nrSala = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        internal List<Sessao> Sessoes { get => sessoes; set => sessoes = value; }
      //  internal Sessao Sessoes2 { get => sessoes2; set => sessoes2 = value; }

        public void adicionarSessao(Sessao sessao )
        {
            sessoes.Add(sessao);
            //sessoes2.adicionarIngressos();
            //como fazer para colocar aqui o método de adicionar ingressos?
            //Se eu fizesse isso, não estaria relacionando corretamente?

            
        }
    }
}
