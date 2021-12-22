using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Sessao
    {
        private string dataTempo;
        private double valorInteira;
        private double valorMeia;
        private double valorPromocao;
        private List<Ingresso> ingressos = new List<Ingresso>();
        private Filme filme;
        private Sala sala;

        public string DataTempo { get => dataTempo; set => dataTempo = value; }
        public double ValorInteira { get => valorInteira; set => valorInteira = value; }
        public double ValorMeia { get => valorMeia; set => valorMeia = value; }
        public double ValorPromocao { get => valorPromocao; set => valorPromocao = value; }
        internal Filme Filme { get => filme; set => filme = value; }
        internal Sala Sala { get => sala; set => sala = value; }

        public void adicionarIngressos(Ingresso ingresso)
        {
            ingressos.Add(ingresso);

        }
    }
}
