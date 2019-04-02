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
    public partial class CadastroCrianca : Form
    {
        //public int idCrianca;
        //public int idMae;
        //public int idPai;
        //public int idOutrosContatos;
        public string nomeCrianca;
        public string dataNasc;
        public char sexo;
        public string tipoSanguineo;
        public string nomeMae;
        public string nomePai;
        public string nomeOutrosContatos;
        public string telefoneMae;
        public string telefonePai;
        public string telefoneOutros;
        public string cpfMae;
        public string cpfPai;
        public string cpfOutros;
        public string rgMae;
        public string rgPai;
        public string rgOutros;
        public string enderecoPais;
        public string enderecoOutros;
        public string noEnderecoPais;
        public string noEnderecoOutros;
        public string bairroPais;
        public string bairroOutros;
        public string cepPais;
        public string cepOutros;
        public string parentescoOutros;

        //public CadastroCrianca crianca { get; private set; }

        //private CadastroCrianca crianca;

        public CadastroCrianca()
        {
            InitializeComponent();
        }

        private void chkAtivarPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivarPai.Checked)
            {
                txtNomePai.Enabled = true;
                txtCPFPai.Enabled = true;
                txtRGPai.Enabled = true;
                txtTelefonePai.Enabled = true;
                chkAtivarPai.Text = "Desativar";
            }
            else
            {
                txtNomePai.Enabled = false;
                txtCPFPai.Enabled = false;
                txtRGPai.Enabled = false;
                txtTelefonePai.Enabled = false;
                chkAtivarPai.Text = "Ativar";
                txtNomePai.Text = "";
                txtCPFPai.Text = "";
                txtRGPai.Text = "";
                txtTelefonePai.Text = "";
            }
        }

        private void chkAtivarMae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivarMae.Checked)
            {
                txtNomeMae.Enabled = true;
                txtCPFMae.Enabled = true;
                txtRGMae.Enabled = true;
                txtTelefoneMae.Enabled = true;
                chkAtivarMae.Text = "Desativar";
            }
            else
            {
                txtNomeMae.Enabled = false;
                txtCPFMae.Enabled = false;
                txtRGMae.Enabled = false;
                txtTelefoneMae.Enabled = false;
                chkAtivarMae.Text = "Ativar";
                txtNomeMae.Text = "";
                txtCPFMae.Text = "";
                txtRGMae.Text = "";
                txtTelefoneMae.Text = "";
            }
        }

        private void btnDadosOpcionais_Click(object sender, EventArgs e)
        {
            if ((txtNomePai.Text != "" && txtCPFPai.Text != "" && txtRGPai.Text != "" && txtTelefonePai.Text != "") ||
                (txtNomeMae.Text != "" && txtCPFMae.Text != "" && txtRGMae.Text != "" && txtTelefoneMae.Text != ""))
            {
                OutrosContatos outros = new OutrosContatos();
                outros.Show();
            }
            else if ((txtNomePai.Enabled == false && txtCPFPai.Enabled == false && txtRGPai.Enabled == false && txtTelefonePai.Enabled == false) &&
                (txtNomeMae.Enabled == false && txtCPFMae.Enabled == false && txtRGMae.Enabled == false && txtTelefoneMae.Enabled == false))
            {
                OutrosContatos outros = new OutrosContatos();
                outros.Show();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNomeCrianca.Text != "" && (radioCriancaFem.Checked || radioCriancaMasc.Checked) && dtpNascimentoCrianca.Text != "")
            {
                if (chkAtivarPai.Checked && chkAtivarMae.Checked)
                {
                    if ((txtNomePai.Text != "" && txtCPFPai.Text != "" && txtRGPai.Text != "" && txtTelefonePai.Text != "") &&
                        (txtNomeMae.Text != "" && txtCPFMae.Text != "" && txtRGMae.Text != "" && txtTelefoneMae.Text != ""))
                    {
                        //metodo salvar após verificar se campos obrigatórios dos pais estão preenchidos
                        if (txtNomeCrianca.Text != "")
                        {
                            nomeCrianca = txtNomeCrianca.Text;
                        } else
                        {
                            MessageBox.Show("Digite o nome\n" +
                                            "completo da criança!");
                        }
                        if (dtpNascimentoCrianca.Text != "")
                        {
                            dataNasc = dtpNascimentoCrianca.Text;
                        } else
                        {
                            MessageBox.Show("Defina a data de\n" +
                                            "nascimento da criança!");
                        }                        
                        if (radioCriancaFem.Checked)
                        {
                            sexo = 'F';
                        }
                        else if (radioCriancaMasc.Checked)
                        {
                            sexo = 'M';
                        } else
                        {
                            MessageBox.Show("Defina se a criança é do\n" +
                                            "sexo Masculino ou Feminino!");
                        }
                        if (comboCriancaTipoSanguineo.Text != "")
                        {
                            tipoSanguineo = comboCriancaTipoSanguineo.Text;
                        }
                        else
                        {
                            //MessageBox.Show("Defina o tipo sanguíneo da criança!");
                            tipoSanguineo = "-";
                        }
                        CadastroCrianca crianca = new CadastroCrianca();
                        crianca.nomeMae = txtNomeMae.Text;
                        crianca.nomePai = txtNomePai.Text;
                        crianca.rgMae = txtRGMae.Text;
                        crianca.rgPai = txtRGPai.Text;
                        crianca.cpfMae = txtCPFMae.Text;
                        crianca.cpfPai = txtCPFPai.Text;
                        crianca.enderecoPais = txtEnderecoPais.Text;
                        crianca.noEnderecoPais = txtNumeroCasaPais.Text;
                        crianca.bairroPais = txtBairroPais.Text;
                        crianca.cepPais = txtCEPPais.Text;
                        
                        DAOHelper.AddCrianca(nomeCrianca, dataNasc, sexo, tipoSanguineo);
                        
                        
                    } else
                    {
                        MessageBox.Show("Verifique se algum dado referente\n" +
                                        "aos pais da criança está incompleto!");
                    }
                } else if (chkAtivarMae.Checked && !chkAtivarPai.Checked)
                {
                    if (txtNomeMae.Text != "" && txtCPFMae.Text != "" && txtRGMae.Text != "" && txtTelefoneMae.Text != "")
                    {
                        //metodo salvar após verificar se campos obrigatórios da mãe estão preenchidos, na ausência do pai
                    }
                } else if (!chkAtivarPai.Checked && !chkAtivarMae.Checked)
                {
                    //verificar se o Form de outros contatos estão devidamente preenchidos.
                    string nomeResponsavel = OutrosContatos.nomeCompleto;
                    string cpf = OutrosContatos.cpf;
                    string rg = OutrosContatos.rg;
                    string telefone = OutrosContatos.telefone;
                    string parentesco = OutrosContatos.parentesco;
                    string endereco = OutrosContatos.endereco;
                    string numero = OutrosContatos.numeroCasa;
                    string bairro = OutrosContatos.bairro;
                    string cep = OutrosContatos.cep;

                    if (nomeResponsavel != "" && cpf != "" && rg != "" && telefone != "" &&
                        parentesco != "" && endereco != "" && numero != "" && bairro != "" && cep != "")
                    {
                        //metodo salvar após verificar se campos obrigatórios dos pais não estão preenchidos e 
                        //alguns dados do Form do responsável não está em branco
                    }
                }
            }
        }

        private void picCriancaFoto_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picCriancaFoto.Image = new Bitmap(openFile.FileName);
            }            
        }

        private void radioCriancaMasc_Click(object sender, EventArgs e)
        {
            sexo = 'M';
        }

        private void radioCriancaFem_Click(object sender, EventArgs e)
        {
            sexo = 'F';
        }
    }
}
