using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DengoDeCrianca
{
    public partial class OutrosContatos : Form
    {
        public static string nomeCompleto = "";
        public static string cpf = "";
        public static string rg = "";
        public static string telefone = "";
        public static string parentesco = "";
        public static string endereco = "";
        public static string numeroCasa = "";
        public static string bairro = "";
        public static string cep = "";
        public OutrosContatos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nomeCompleto = txtNomeResponsável.Text;
            cpf = txtCPFResponsavel.Text;
            rg = txtRGResponsavel.Text;
            telefone = txtTelefoneResponsavel.Text;
            parentesco = txtParentescoResponsavel.Text;
            endereco = txtEnderecoResponsavel.Text;
            numeroCasa = txtNumeroCasaResponsavel.Text;
            bairro = txtBairroResponsavel.Text;
            cep = txtCEPResponsavel.Text;

            if (nomeCompleto != "" && cpf != "" && rg != "" && telefone != "" && 
                parentesco != "" && endereco != "" && numeroCasa != "" && bairro != "" && cep != "")
            {
                //método para salvar nas váriaveis do Form de cadastro da criança

            } else
            {
                MessageBox.Show("Alguns dados do responsável podem estar incompletos!\n" +
                                "Verifique novamente os dados inseridos no formulário!");
            }
    }
    }
}
