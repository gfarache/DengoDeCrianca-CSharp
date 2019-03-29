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
    public partial class CadastroResponsável : Form
    {
        public CadastroResponsável()
        {
            InitializeComponent();
        }

        private void chkAtivarPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivarPai.Checked) {
                txtNomePai.Enabled = true;
                txtCPFPai.Enabled = true;
                txtRGPai.Enabled = true;
                txtTelefonePai.Enabled = true;
            } else {
                txtNomePai.Enabled = false;
                txtCPFPai.Enabled = false;
                txtRGPai.Enabled = false;
                txtTelefonePai.Enabled = false;
            }
        }
        private void chkAtivarMae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivarMae.Checked) {
                txtNomeMae.Enabled = true;
                txtCPFMae.Enabled = true;
                txtRGMae.Enabled = true;
                txtTelefoneMae.Enabled = true;
            } else {
                txtNomeMae.Enabled = false;
                txtCPFMae.Enabled = false;
                txtRGMae.Enabled = false;
                txtTelefoneMae.Enabled = false;
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
    }
}
