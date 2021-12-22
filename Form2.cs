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
    public partial class Form2 : Form
    {
        Genero genero;
        Filme filme;
        Ator ator;
        Atua atua;        
        public Form2()
        {
            InitializeComponent();
            genero = new Genero();
            filme = new Filme();
            ator = new Ator();
            atua = new Atua();
            



        }

        private void cbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarGenero_Click(object sender, EventArgs e)
        {
            
            
           
                

        }

        private void btnCriarFilme_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnCriarAtor_Click(object sender, EventArgs e)
        {
            

        }
    }
}
