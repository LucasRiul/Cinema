using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Funcionario funcionario;
        Cliente cliente;
        Sessao sessao;
        Sala sala;
        Atua atua;
        Filme filme;
        Genero genero;
        Ator ator;
        
        public Form1()
        {
            InitializeComponent();
            funcionario = new Funcionario();
            cliente = new Cliente();
            sessao = new Sessao();
            sala = new Sala();
            atua = new Atua();
            filme = new Filme();
            genero = new Genero();
            ator = new Ator();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.Funcao = txtFuncao.Text;
            funcionario.Idade = int.Parse(txtIdadeFuncionario.Text);
            mmObjetos.Text += "Funcionario \n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNomeCliente.Text;
            cliente.Idade = int.Parse(txtIdadeCliente.Text);
            mmObjetos.Text += "Cliente \n";


        }

        private void gbxSessao_Enter(object sender, EventArgs e)
        {

        }

        private void btnCriarSessao_Click(object sender, EventArgs e)
        {
            sessao.ValorInteira = double.Parse(txtValor.Text);
            sessao.DataTempo = txtDataSessao.Text;
            sala.NrSala = cbxSalaSessao.SelectedIndex;
            

            mmObjetos.Text += "Sessao \n";
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Ingresso ingresso = new Ingresso();
            ingresso.Cliente = cliente;
            ingresso.Sessao = sessao;
            ingresso.Funcionario = funcionario;

            funcionario.vendaIngresso(ingresso, cliente);
            sessao.adicionarIngressos(ingresso);

            mmObjetos.Text = "Ingresso vendido \n"+" Nome do Colaborador: "+cliente.ingressos[0].Funcionario.Nome
                +"\n"+ "Nome do cliente: " + cliente.ingressos[0].Cliente.Nome
                +"\n"+"Data e hora da sessão: " + cliente.ingressos[0].Sessao.DataTempo
                +"\n"+"Número da sala: " + cbxSalaSessao.SelectedItem; 
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            sala.NrSala = int.Parse(txtNumeroSala.Text);
            sala.Capacidade = int.Parse(txtCapacidade.Text);
            for (int i = 1; i <= sala.NrSala; i++)
            {
                cbxSalaSessao.Items.Add(i.ToString());
            }

            mmObjetos.Text += "Sala \n";
        }        

        private void cbxFilmeSessao_SelectedIndexChanged(object sender, EventArgs e)
        {       
                     
                   
           
        }

        private void txtNumeroSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAtoresPapeis_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarGenero_Click(object sender, EventArgs e)
        {
            cbxGenero.Items.Add(txtDescricao.Text);

            mmObjetos.Text = "Genero \n";
        }

        private void btnCriarFilme_Click(object sender, EventArgs e)
        {
            genero.Descricao = cbxGenero.SelectedItem.ToString();
            filme.Genero = genero;
            filme.Titulo = txtTitulo.Text;
            filme.Duracao = int.Parse(txtDuracao.Text);



            cbxFilme.Items.Add(filme.Titulo.ToString());
            cbxFilmeSessao.Items.Add(filme.Titulo.ToString());


            mmObjetos.Text += "Filme \n";
        }

        private void btnCriarAtor_Click(object sender, EventArgs e)
        {
            atua.Filme = filme;
            ator.Nome = txtNomeAtor.Text;
            atua.Papel = txtPapel.Text;
            filme.Titulo = cbxFilme.SelectedItem.ToString();

            atua.adicionarPapeis(filme, ator);

            mmObjetos.Text += "Ator \n";
        }
    }
}
