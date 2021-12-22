using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Funcionario : Pessoa

    {
        private string funcao;

        public string Funcao { get => funcao; set => funcao = value; }

        public void vendaIngresso(Ingresso ingresso, Cliente cliente)
        {
            ingresso.Cliente = cliente;
            ingresso.Funcionario = this;
            cliente.adicionarIngresso(ingresso);

            Console.WriteLine("alteração");
            //a

            Console.WriteLine("alteração outra branch hehehheheheh");
        }
        

        }
    }

