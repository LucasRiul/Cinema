using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Cliente : Pessoa
    {
        public List<Ingresso> ingressos = new List<Ingresso>();

        public void adicionarIngresso(Ingresso ingresso)
        {
            ingressos.Add(ingresso); // não precisa de this porque os nomes ingresso e ingressos são diferentes

        }

    }
}
