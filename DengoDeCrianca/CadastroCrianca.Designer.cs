namespace DengoDeCrianca
{
    partial class CadastroCrianca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCrianca));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCrianca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCrianca = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCriancaTipoSanguineo = new System.Windows.Forms.ComboBox();
            this.picCriancaFoto = new System.Windows.Forms.PictureBox();
            this.dtpNascimentoCrianca = new System.Windows.Forms.DateTimePicker();
            this.radioCriancaFem = new System.Windows.Forms.RadioButton();
            this.radioCriancaMasc = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupFiliacao = new System.Windows.Forms.GroupBox();
            this.btnDadosOpcionais = new System.Windows.Forms.Button();
            this.groupEndereco = new System.Windows.Forms.GroupBox();
            this.txtEnderecoPais = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroCasaPais = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEPPais = new System.Windows.Forms.MaskedTextBox();
            this.txtBairroPais = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAtivarPai = new System.Windows.Forms.CheckBox();
            this.groupMae = new System.Windows.Forms.GroupBox();
            this.chkAtivarMae = new System.Windows.Forms.CheckBox();
            this.txtCPFMae = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneMae = new System.Windows.Forms.MaskedTextBox();
            this.txtRGMae = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.groupPai = new System.Windows.Forms.GroupBox();
            this.txtRGPai = new System.Windows.Forms.TextBox();
            this.txtCPFPai = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefonePai = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.groupCadastro = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupCrianca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCriancaFoto)).BeginInit();
            this.groupFiliacao.SuspendLayout();
            this.groupEndereco.SuspendLayout();
            this.groupMae.SuspendLayout();
            this.groupPai.SuspendLayout();
            this.groupCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // txtNomeCrianca
            // 
            this.txtNomeCrianca.Location = new System.Drawing.Point(6, 32);
            this.txtNomeCrianca.Name = "txtNomeCrianca";
            this.txtNomeCrianca.Size = new System.Drawing.Size(291, 20);
            this.txtNomeCrianca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // groupCrianca
            // 
            this.groupCrianca.Controls.Add(this.label10);
            this.groupCrianca.Controls.Add(this.comboCriancaTipoSanguineo);
            this.groupCrianca.Controls.Add(this.picCriancaFoto);
            this.groupCrianca.Controls.Add(this.dtpNascimentoCrianca);
            this.groupCrianca.Controls.Add(this.radioCriancaFem);
            this.groupCrianca.Controls.Add(this.radioCriancaMasc);
            this.groupCrianca.Controls.Add(this.label1);
            this.groupCrianca.Controls.Add(this.txtNomeCrianca);
            this.groupCrianca.Controls.Add(this.label2);
            this.groupCrianca.Location = new System.Drawing.Point(12, 19);
            this.groupCrianca.Name = "groupCrianca";
            this.groupCrianca.Size = new System.Drawing.Size(444, 175);
            this.groupCrianca.TabIndex = 8;
            this.groupCrianca.TabStop = false;
            this.groupCrianca.Text = "Criança:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tipo Sanguíneo:";
            // 
            // comboCriancaTipoSanguineo
            // 
            this.comboCriancaTipoSanguineo.FormattingEnabled = true;
            this.comboCriancaTipoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboCriancaTipoSanguineo.Location = new System.Drawing.Point(209, 78);
            this.comboCriancaTipoSanguineo.Name = "comboCriancaTipoSanguineo";
            this.comboCriancaTipoSanguineo.Size = new System.Drawing.Size(87, 21);
            this.comboCriancaTipoSanguineo.TabIndex = 11;
            // 
            // picCriancaFoto
            // 
            this.picCriancaFoto.Location = new System.Drawing.Point(317, 19);
            this.picCriancaFoto.Name = "picCriancaFoto";
            this.picCriancaFoto.Size = new System.Drawing.Size(111, 137);
            this.picCriancaFoto.TabIndex = 10;
            this.picCriancaFoto.TabStop = false;
            this.picCriancaFoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCriancaFoto_MouseClick);
            // 
            // dtpNascimentoCrianca
            // 
            this.dtpNascimentoCrianca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimentoCrianca.Location = new System.Drawing.Point(93, 80);
            this.dtpNascimentoCrianca.Name = "dtpNascimentoCrianca";
            this.dtpNascimentoCrianca.Size = new System.Drawing.Size(95, 20);
            this.dtpNascimentoCrianca.TabIndex = 9;
            // 
            // radioCriancaFem
            // 
            this.radioCriancaFem.AutoSize = true;
            this.radioCriancaFem.Location = new System.Drawing.Point(9, 82);
            this.radioCriancaFem.Name = "radioCriancaFem";
            this.radioCriancaFem.Size = new System.Drawing.Size(67, 17);
            this.radioCriancaFem.TabIndex = 8;
            this.radioCriancaFem.TabStop = true;
            this.radioCriancaFem.Text = "Feminino";
            this.radioCriancaFem.UseVisualStyleBackColor = true;
            this.radioCriancaFem.CheckedChanged += new System.EventHandler(this.radioCriancaFem_CheckedChanged);
            this.radioCriancaFem.Click += new System.EventHandler(this.radioCriancaFem_Click);
            // 
            // radioCriancaMasc
            // 
            this.radioCriancaMasc.AutoSize = true;
            this.radioCriancaMasc.Location = new System.Drawing.Point(9, 64);
            this.radioCriancaMasc.Name = "radioCriancaMasc";
            this.radioCriancaMasc.Size = new System.Drawing.Size(73, 17);
            this.radioCriancaMasc.TabIndex = 7;
            this.radioCriancaMasc.TabStop = true;
            this.radioCriancaMasc.Text = "Masculino";
            this.radioCriancaMasc.UseVisualStyleBackColor = true;
            this.radioCriancaMasc.CheckedChanged += new System.EventHandler(this.radioCriancaMasc_CheckedChanged);
            this.radioCriancaMasc.Click += new System.EventHandler(this.radioCriancaMasc_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(97, 653);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(179, 653);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 653);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupFiliacao
            // 
            this.groupFiliacao.Controls.Add(this.btnDadosOpcionais);
            this.groupFiliacao.Controls.Add(this.groupEndereco);
            this.groupFiliacao.Controls.Add(this.chkAtivarPai);
            this.groupFiliacao.Controls.Add(this.groupMae);
            this.groupFiliacao.Controls.Add(this.groupPai);
            this.groupFiliacao.Location = new System.Drawing.Point(12, 200);
            this.groupFiliacao.Name = "groupFiliacao";
            this.groupFiliacao.Size = new System.Drawing.Size(444, 437);
            this.groupFiliacao.TabIndex = 12;
            this.groupFiliacao.TabStop = false;
            this.groupFiliacao.Text = "Filiação";
            // 
            // btnDadosOpcionais
            // 
            this.btnDadosOpcionais.Location = new System.Drawing.Point(146, 406);
            this.btnDadosOpcionais.Name = "btnDadosOpcionais";
            this.btnDadosOpcionais.Size = new System.Drawing.Size(142, 23);
            this.btnDadosOpcionais.TabIndex = 16;
            this.btnDadosOpcionais.Text = "Adicionar responsáveis...";
            this.btnDadosOpcionais.UseVisualStyleBackColor = true;
            this.btnDadosOpcionais.Click += new System.EventHandler(this.btnDadosOpcionais_Click);
            // 
            // groupEndereco
            // 
            this.groupEndereco.Controls.Add(this.txtEnderecoPais);
            this.groupEndereco.Controls.Add(this.label11);
            this.groupEndereco.Controls.Add(this.txtNumeroCasaPais);
            this.groupEndereco.Controls.Add(this.label12);
            this.groupEndereco.Controls.Add(this.txtCEPPais);
            this.groupEndereco.Controls.Add(this.txtBairroPais);
            this.groupEndereco.Controls.Add(this.label14);
            this.groupEndereco.Controls.Add(this.label13);
            this.groupEndereco.Location = new System.Drawing.Point(7, 301);
            this.groupEndereco.Name = "groupEndereco";
            this.groupEndereco.Size = new System.Drawing.Size(423, 100);
            this.groupEndereco.TabIndex = 29;
            this.groupEndereco.TabStop = false;
            this.groupEndereco.Text = "Localidade";
            // 
            // txtEnderecoPais
            // 
            this.txtEnderecoPais.Location = new System.Drawing.Point(6, 30);
            this.txtEnderecoPais.Name = "txtEnderecoPais";
            this.txtEnderecoPais.Size = new System.Drawing.Size(315, 20);
            this.txtEnderecoPais.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Endereço:";
            // 
            // txtNumeroCasaPais
            // 
            this.txtNumeroCasaPais.Location = new System.Drawing.Point(327, 30);
            this.txtNumeroCasaPais.Name = "txtNumeroCasaPais";
            this.txtNumeroCasaPais.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroCasaPais.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nº:";
            // 
            // txtCEPPais
            // 
            this.txtCEPPais.Location = new System.Drawing.Point(150, 69);
            this.txtCEPPais.Mask = "00000-999";
            this.txtCEPPais.Name = "txtCEPPais";
            this.txtCEPPais.Size = new System.Drawing.Size(64, 20);
            this.txtCEPPais.TabIndex = 15;
            // 
            // txtBairroPais
            // 
            this.txtBairroPais.Location = new System.Drawing.Point(6, 69);
            this.txtBairroPais.Name = "txtBairroPais";
            this.txtBairroPais.Size = new System.Drawing.Size(139, 20);
            this.txtBairroPais.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "CEP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Bairro:";
            // 
            // chkAtivarPai
            // 
            this.chkAtivarPai.AutoSize = true;
            this.chkAtivarPai.Location = new System.Drawing.Point(6, 20);
            this.chkAtivarPai.Name = "chkAtivarPai";
            this.chkAtivarPai.Size = new System.Drawing.Size(53, 17);
            this.chkAtivarPai.TabIndex = 2;
            this.chkAtivarPai.Text = "Ativar";
            this.chkAtivarPai.UseVisualStyleBackColor = true;
            this.chkAtivarPai.CheckedChanged += new System.EventHandler(this.chkAtivarPai_CheckedChanged);
            // 
            // groupMae
            // 
            this.groupMae.Controls.Add(this.chkAtivarMae);
            this.groupMae.Controls.Add(this.txtCPFMae);
            this.groupMae.Controls.Add(this.txtTelefoneMae);
            this.groupMae.Controls.Add(this.txtRGMae);
            this.groupMae.Controls.Add(this.label3);
            this.groupMae.Controls.Add(this.label4);
            this.groupMae.Controls.Add(this.label6);
            this.groupMae.Controls.Add(this.label5);
            this.groupMae.Controls.Add(this.txtNomeMae);
            this.groupMae.Location = new System.Drawing.Point(7, 157);
            this.groupMae.Name = "groupMae";
            this.groupMae.Size = new System.Drawing.Size(423, 138);
            this.groupMae.TabIndex = 27;
            this.groupMae.TabStop = false;
            this.groupMae.Text = "Dados da Mãe";
            // 
            // chkAtivarMae
            // 
            this.chkAtivarMae.AutoSize = true;
            this.chkAtivarMae.Location = new System.Drawing.Point(6, 16);
            this.chkAtivarMae.Name = "chkAtivarMae";
            this.chkAtivarMae.Size = new System.Drawing.Size(53, 17);
            this.chkAtivarMae.TabIndex = 7;
            this.chkAtivarMae.Text = "Ativar";
            this.chkAtivarMae.UseVisualStyleBackColor = true;
            this.chkAtivarMae.CheckedChanged += new System.EventHandler(this.chkAtivarMae_CheckedChanged);
            // 
            // txtCPFMae
            // 
            this.txtCPFMae.Enabled = false;
            this.txtCPFMae.Location = new System.Drawing.Point(6, 91);
            this.txtCPFMae.Mask = "###.###.###-##";
            this.txtCPFMae.Name = "txtCPFMae";
            this.txtCPFMae.Size = new System.Drawing.Size(100, 20);
            this.txtCPFMae.TabIndex = 9;
            // 
            // txtTelefoneMae
            // 
            this.txtTelefoneMae.Enabled = false;
            this.txtTelefoneMae.Location = new System.Drawing.Point(221, 91);
            this.txtTelefoneMae.Mask = "(99) 00000-0000";
            this.txtTelefoneMae.Name = "txtTelefoneMae";
            this.txtTelefoneMae.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneMae.TabIndex = 11;
            // 
            // txtRGMae
            // 
            this.txtRGMae.Enabled = false;
            this.txtRGMae.Location = new System.Drawing.Point(113, 91);
            this.txtRGMae.Name = "txtRGMae";
            this.txtRGMae.Size = new System.Drawing.Size(103, 20);
            this.txtRGMae.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "RG da Mãe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "CPF da Mãe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nome da Mãe:";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Enabled = false;
            this.txtNomeMae.Location = new System.Drawing.Point(6, 52);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(315, 20);
            this.txtNomeMae.TabIndex = 8;
            // 
            // groupPai
            // 
            this.groupPai.Controls.Add(this.txtRGPai);
            this.groupPai.Controls.Add(this.txtCPFPai);
            this.groupPai.Controls.Add(this.label15);
            this.groupPai.Controls.Add(this.label7);
            this.groupPai.Controls.Add(this.txtTelefonePai);
            this.groupPai.Controls.Add(this.label8);
            this.groupPai.Controls.Add(this.label9);
            this.groupPai.Controls.Add(this.txtNomePai);
            this.groupPai.Location = new System.Drawing.Point(7, 43);
            this.groupPai.Name = "groupPai";
            this.groupPai.Size = new System.Drawing.Size(423, 100);
            this.groupPai.TabIndex = 26;
            this.groupPai.TabStop = false;
            this.groupPai.Text = "Dados do Pai";
            // 
            // txtRGPai
            // 
            this.txtRGPai.Enabled = false;
            this.txtRGPai.Location = new System.Drawing.Point(112, 69);
            this.txtRGPai.Name = "txtRGPai";
            this.txtRGPai.Size = new System.Drawing.Size(103, 20);
            this.txtRGPai.TabIndex = 5;
            // 
            // txtCPFPai
            // 
            this.txtCPFPai.Enabled = false;
            this.txtCPFPai.Location = new System.Drawing.Point(6, 69);
            this.txtCPFPai.Mask = "###.###.###-##";
            this.txtCPFPai.Name = "txtCPFPai";
            this.txtCPFPai.Size = new System.Drawing.Size(100, 20);
            this.txtCPFPai.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "RG do Pai:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "CPF do Pai:";
            // 
            // txtTelefonePai
            // 
            this.txtTelefonePai.Enabled = false;
            this.txtTelefonePai.Location = new System.Drawing.Point(221, 69);
            this.txtTelefonePai.Mask = "(99) 00000-0000";
            this.txtTelefonePai.Name = "txtTelefonePai";
            this.txtTelefonePai.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonePai.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nome do Pai:";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Enabled = false;
            this.txtNomePai.Location = new System.Drawing.Point(6, 30);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(315, 20);
            this.txtNomePai.TabIndex = 3;
            // 
            // groupCadastro
            // 
            this.groupCadastro.Controls.Add(this.groupCrianca);
            this.groupCadastro.Controls.Add(this.btnCancelar);
            this.groupCadastro.Controls.Add(this.groupFiliacao);
            this.groupCadastro.Controls.Add(this.btnLimpar);
            this.groupCadastro.Controls.Add(this.btnSalvar);
            this.groupCadastro.Location = new System.Drawing.Point(0, 12);
            this.groupCadastro.Name = "groupCadastro";
            this.groupCadastro.Size = new System.Drawing.Size(468, 684);
            this.groupCadastro.TabIndex = 13;
            this.groupCadastro.TabStop = false;
            this.groupCadastro.Text = "Cadastro";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CadastroCrianca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 703);
            this.Controls.Add(this.groupCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCrianca";
            this.Text = "Cadastrar Criança";
            this.groupCrianca.ResumeLayout(false);
            this.groupCrianca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCriancaFoto)).EndInit();
            this.groupFiliacao.ResumeLayout(false);
            this.groupFiliacao.PerformLayout();
            this.groupEndereco.ResumeLayout(false);
            this.groupEndereco.PerformLayout();
            this.groupMae.ResumeLayout(false);
            this.groupMae.PerformLayout();
            this.groupPai.ResumeLayout(false);
            this.groupPai.PerformLayout();
            this.groupCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCrianca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCrianca;
        private System.Windows.Forms.DateTimePicker dtpNascimentoCrianca;
        private System.Windows.Forms.RadioButton radioCriancaFem;
        private System.Windows.Forms.RadioButton radioCriancaMasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picCriancaFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCriancaTipoSanguineo;
        private System.Windows.Forms.GroupBox groupFiliacao;
        private System.Windows.Forms.Button btnDadosOpcionais;
        private System.Windows.Forms.GroupBox groupEndereco;
        private System.Windows.Forms.TextBox txtEnderecoPais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroCasaPais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtCEPPais;
        private System.Windows.Forms.TextBox txtBairroPais;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAtivarPai;
        private System.Windows.Forms.GroupBox groupMae;
        private System.Windows.Forms.CheckBox chkAtivarMae;
        private System.Windows.Forms.MaskedTextBox txtCPFMae;
        private System.Windows.Forms.MaskedTextBox txtTelefoneMae;
        private System.Windows.Forms.TextBox txtRGMae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.GroupBox groupPai;
        private System.Windows.Forms.TextBox txtRGPai;
        private System.Windows.Forms.MaskedTextBox txtCPFPai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefonePai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.GroupBox groupCadastro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}