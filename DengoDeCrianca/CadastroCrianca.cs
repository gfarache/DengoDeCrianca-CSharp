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
        public string sexo;
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

        private void LimparCamposForm()
        {
            txtNomeCrianca.Text = "";
            radioCriancaFem.Checked = false;
            radioCriancaMasc.Checked = false;
            dtpNascimentoCrianca.Text = "";
            comboCriancaTipoSanguineo.Text = "";
            chkAtivarPai.Checked = false;
            txtNomePai.Text = "";
            txtCPFPai.Text = "";
            txtRGPai.Text = "";
            txtTelefonePai.Text = "";
            chkAtivarMae.Checked = false;
            txtNomeMae.Text = "";
            txtCPFMae.Text = "";
            txtRGMae.Text = "";
            txtTelefoneMae.Text = "";
            txtEnderecoPais.Text = "";
            txtNumeroCasaPais.Text = "";
            txtBairroPais.Text = "";
            txtCEPPais.Text = "";
        }

        private void LimparCamposCrianca()
        {
            txtNomeCrianca.Text = "";
            radioCriancaFem.Checked = false;
            radioCriancaMasc.Checked = false;
            dtpNascimentoCrianca.Text = "";
            comboCriancaTipoSanguineo.Text = "";
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
            if (txtNomeCrianca.Text != "" && (radioCriancaFem.Checked || radioCriancaMasc.Checked) && dtpNascimentoCrianca.Text != "")
            {
                if (chkAtivarPai.Checked && chkAtivarMae.Checked)
                {
                    if ((txtNomePai.Text != "" && txtCPFPai.Text != "" && txtRGPai.Text != "" && txtTelefonePai.Text != "") &&
                        (txtNomeMae.Text != "" && txtCPFMae.Text != "" && txtRGMae.Text != "" && txtTelefoneMae.Text != ""))
                    {
                        CadastroCrianca novaCrianca = new CadastroCrianca();
                        //metodo salvar após verificar se campos obrigatórios dos pais estão preenchidos
                        //if (txtNomeCrianca.Text != "")
                        //{
                            novaCrianca.nomeCrianca = txtNomeCrianca.Text;
                        //} else
                        //{
                        //    MessageBox.Show("Digite o nome completo da criança!");
                        //}
                        //if (dtpNascimentoCrianca.Text != "")
                        //{
                            novaCrianca.dataNasc = dtpNascimentoCrianca.Text;
                        //} else
                        //{
                        //    MessageBox.Show("Defina a data de nascimento da criança!");
                        //}                        
                        if (radioCriancaFem.Checked)
                        {
                            novaCrianca.sexo = "F";
                        }
                        else if (radioCriancaMasc.Checked)
                        {
                            novaCrianca.sexo = "M";
                        } else
                        {
                            MessageBox.Show("Defina se a criança é do sexo Masculino ou Feminino!");
                        }
                        if (comboCriancaTipoSanguineo.Text != "")
                        {
                            novaCrianca.tipoSanguineo = comboCriancaTipoSanguineo.Text;
                        }
                        else
                        {
                            //MessageBox.Show("Defina o tipo sanguíneo da criança!");
                            novaCrianca.tipoSanguineo = "-";
                        }
                        //CadastroCrianca crianca = new CadastroCrianca();
                        novaCrianca.nomeMae = txtNomeMae.Text;
                        novaCrianca.nomePai = txtNomePai.Text;
                        novaCrianca.rgMae = txtRGMae.Text;
                        novaCrianca.rgPai = txtRGPai.Text;
                        novaCrianca.cpfMae = txtCPFMae.Text;
                        novaCrianca.cpfPai = txtCPFPai.Text;
                        novaCrianca.enderecoPais = txtEnderecoPais.Text;
                        novaCrianca.noEnderecoPais = txtNumeroCasaPais.Text;
                        novaCrianca.bairroPais = txtBairroPais.Text;
                        novaCrianca.cepPais = txtCEPPais.Text;


                        DAOHelper.AddCrianca(novaCrianca);
                        if (MessageBox.Show("Dados da criança e dos pais cadastrados com sucesso!\n\n" +
                                "Deseja cadastrar nova criança com os mesmos pais?","Sucesso!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            LimparCamposCrianca();
                        } else
                        {
                            LimparCamposForm();
                        }                        
                    } else
                    {
                        MessageBox.Show("Verifique se algum dado referente aos pais da criança está incompleto!");
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
            sexo = "M";
        }

        private void radioCriancaFem_Click(object sender, EventArgs e)
        {
            sexo = "F";
        }

        private void radioCriancaMasc_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "M";
        }

        private void radioCriancaFem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "F";
        }
    }
}
