namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.txtIdadeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnCriarFuncionario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdadeCliente = new System.Windows.Forms.TextBox();
            this.lblIdadeCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.gbxSessao = new System.Windows.Forms.GroupBox();
            this.mmAtoresPapeis = new System.Windows.Forms.RichTextBox();
            this.lblAtoresPapeis = new System.Windows.Forms.Label();
            this.txtGeneroSessao = new System.Windows.Forms.TextBox();
            this.lblGeneroSessao = new System.Windows.Forms.Label();
            this.cbxFilmeSessao = new System.Windows.Forms.ComboBox();
            this.lblFilme = new System.Windows.Forms.Label();
            this.cbxSalaSessao = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.btnCriarSessao = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDataSessao = new System.Windows.Forms.TextBox();
            this.lblDataSessao = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnVenda = new System.Windows.Forms.Button();
            this.mmObjetos = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gbxSala = new System.Windows.Forms.GroupBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.txtNumeroSala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.btnCriarGenero = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbxFilme = new System.Windows.Forms.GroupBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.btnCriarFilme = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxAtor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriarAtor = new System.Windows.Forms.Button();
            this.txtNomeAtor = new System.Windows.Forms.TextBox();
            this.lblNomeAtor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxSessao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbxSala.SuspendLayout();
            this.gbxGenero.SuspendLayout();
            this.gbxFilme.SuspendLayout();
            this.gbxAtor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtFuncao);
            this.groupBox1.Controls.Add(this.lblFuncao);
            this.groupBox1.Controls.Add(this.txtIdadeFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNomeFuncionario);
            this.groupBox1.Controls.Add(this.btnCriarFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(1119, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(57, 148);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(266, 22);
            this.txtFuncao.TabIndex = 2;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(-1, 148);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(52, 16);
            this.lblFuncao.TabIndex = 5;
            this.lblFuncao.Text = "Função";
            // 
            // txtIdadeFuncionario
            // 
            this.txtIdadeFuncionario.Location = new System.Drawing.Point(57, 105);
            this.txtIdadeFuncionario.Name = "txtIdadeFuncionario";
            this.txtIdadeFuncionario.Size = new System.Drawing.Size(95, 22);
            this.txtIdadeFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Idade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(-3, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(56, 65);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(266, 22);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // btnCriarFuncionario
            // 
            this.btnCriarFuncionario.Location = new System.Drawing.Point(102, 207);
            this.btnCriarFuncionario.Name = "btnCriarFuncionario";
            this.btnCriarFuncionario.Size = new System.Drawing.Size(127, 23);
            this.btnCriarFuncionario.TabIndex = 3;
            this.btnCriarFuncionario.Text = "Criar Funcionário";
            this.btnCriarFuncionario.UseVisualStyleBackColor = true;
            this.btnCriarFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.txtIdadeCliente);
            this.groupBox2.Controls.Add(this.lblIdadeCliente);
            this.groupBox2.Controls.Add(this.lblNomeCliente);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.btnCliente);
            this.groupBox2.Location = new System.Drawing.Point(25, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtIdadeCliente
            // 
            this.txtIdadeCliente.Location = new System.Drawing.Point(57, 105);
            this.txtIdadeCliente.Name = "txtIdadeCliente";
            this.txtIdadeCliente.Size = new System.Drawing.Size(144, 22);
            this.txtIdadeCliente.TabIndex = 4;
            // 
            // lblIdadeCliente
            // 
            this.lblIdadeCliente.AutoSize = true;
            this.lblIdadeCliente.Location = new System.Drawing.Point(-1, 105);
            this.lblIdadeCliente.Name = "lblIdadeCliente";
            this.lblIdadeCliente.Size = new System.Drawing.Size(42, 16);
            this.lblIdadeCliente.TabIndex = 3;
            this.lblIdadeCliente.Text = "Idade";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(-3, 65);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(44, 16);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(56, 65);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(266, 22);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(95, 207);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(127, 23);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Criar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // gbxSessao
            // 
            this.gbxSessao.Controls.Add(this.mmAtoresPapeis);
            this.gbxSessao.Controls.Add(this.lblAtoresPapeis);
            this.gbxSessao.Controls.Add(this.txtGeneroSessao);
            this.gbxSessao.Controls.Add(this.lblGeneroSessao);
            this.gbxSessao.Controls.Add(this.cbxFilmeSessao);
            this.gbxSessao.Controls.Add(this.lblFilme);
            this.gbxSessao.Controls.Add(this.cbxSalaSessao);
            this.gbxSessao.Controls.Add(this.lblSala);
            this.gbxSessao.Controls.Add(this.btnCriarSessao);
            this.gbxSessao.Controls.Add(this.txtValor);
            this.gbxSessao.Controls.Add(this.lblValor);
            this.gbxSessao.Controls.Add(this.txtDataSessao);
            this.gbxSessao.Controls.Add(this.lblDataSessao);
            this.gbxSessao.Location = new System.Drawing.Point(460, 268);
            this.gbxSessao.Name = "gbxSessao";
            this.gbxSessao.Size = new System.Drawing.Size(671, 330);
            this.gbxSessao.TabIndex = 2;
            this.gbxSessao.TabStop = false;
            this.gbxSessao.Text = "Sessão";
            this.gbxSessao.Enter += new System.EventHandler(this.gbxSessao_Enter);
            // 
            // mmAtoresPapeis
            // 
            this.mmAtoresPapeis.Location = new System.Drawing.Point(376, 48);
            this.mmAtoresPapeis.Name = "mmAtoresPapeis";
            this.mmAtoresPapeis.Size = new System.Drawing.Size(286, 224);
            this.mmAtoresPapeis.TabIndex = 13;
            this.mmAtoresPapeis.Text = "";
            // 
            // lblAtoresPapeis
            // 
            this.lblAtoresPapeis.AutoSize = true;
            this.lblAtoresPapeis.Location = new System.Drawing.Point(267, 48);
            this.lblAtoresPapeis.Name = "lblAtoresPapeis";
            this.lblAtoresPapeis.Size = new System.Drawing.Size(103, 16);
            this.lblAtoresPapeis.TabIndex = 12;
            this.lblAtoresPapeis.Text = "Atores e Papeis";
            this.lblAtoresPapeis.Click += new System.EventHandler(this.lblAtoresPapeis_Click);
            // 
            // txtGeneroSessao
            // 
            this.txtGeneroSessao.Location = new System.Drawing.Point(84, 226);
            this.txtGeneroSessao.Name = "txtGeneroSessao";
            this.txtGeneroSessao.Size = new System.Drawing.Size(165, 22);
            this.txtGeneroSessao.TabIndex = 11;
            // 
            // lblGeneroSessao
            // 
            this.lblGeneroSessao.AutoSize = true;
            this.lblGeneroSessao.Location = new System.Drawing.Point(6, 226);
            this.lblGeneroSessao.Name = "lblGeneroSessao";
            this.lblGeneroSessao.Size = new System.Drawing.Size(52, 16);
            this.lblGeneroSessao.TabIndex = 10;
            this.lblGeneroSessao.Text = "Gênero";
            // 
            // cbxFilmeSessao
            // 
            this.cbxFilmeSessao.FormattingEnabled = true;
            this.cbxFilmeSessao.Location = new System.Drawing.Point(84, 177);
            this.cbxFilmeSessao.Name = "cbxFilmeSessao";
            this.cbxFilmeSessao.Size = new System.Drawing.Size(165, 24);
            this.cbxFilmeSessao.TabIndex = 9;
            this.cbxFilmeSessao.SelectedIndexChanged += new System.EventHandler(this.cbxFilmeSessao_SelectedIndexChanged);
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(6, 177);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(40, 16);
            this.lblFilme.TabIndex = 8;
            this.lblFilme.Text = "Filme";
            // 
            // cbxSalaSessao
            // 
            this.cbxSalaSessao.FormattingEnabled = true;
            this.cbxSalaSessao.Location = new System.Drawing.Point(84, 138);
            this.cbxSalaSessao.Name = "cbxSalaSessao";
            this.cbxSalaSessao.Size = new System.Drawing.Size(165, 24);
            this.cbxSalaSessao.TabIndex = 7;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(6, 138);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(35, 16);
            this.lblSala.TabIndex = 6;
            this.lblSala.Text = "Sala";
            // 
            // btnCriarSessao
            // 
            this.btnCriarSessao.Location = new System.Drawing.Point(261, 290);
            this.btnCriarSessao.Name = "btnCriarSessao";
            this.btnCriarSessao.Size = new System.Drawing.Size(127, 23);
            this.btnCriarSessao.TabIndex = 5;
            this.btnCriarSessao.Text = "Criar Sessao";
            this.btnCriarSessao.UseVisualStyleBackColor = true;
            this.btnCriarSessao.Click += new System.EventHandler(this.btnCriarSessao_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(84, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(165, 22);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 92);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // txtDataSessao
            // 
            this.txtDataSessao.Location = new System.Drawing.Point(84, 48);
            this.txtDataSessao.Name = "txtDataSessao";
            this.txtDataSessao.Size = new System.Drawing.Size(165, 22);
            this.txtDataSessao.TabIndex = 2;
            // 
            // lblDataSessao
            // 
            this.lblDataSessao.AutoSize = true;
            this.lblDataSessao.Location = new System.Drawing.Point(6, 48);
            this.lblDataSessao.Name = "lblDataSessao";
            this.lblDataSessao.Size = new System.Drawing.Size(69, 16);
            this.lblDataSessao.TabIndex = 0;
            this.lblDataSessao.Text = "Data Hora";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(1349, 317);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(127, 39);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // mmObjetos
            // 
            this.mmObjetos.Location = new System.Drawing.Point(1136, 501);
            this.mmObjetos.Name = "mmObjetos";
            this.mmObjetos.Size = new System.Drawing.Size(364, 252);
            this.mmObjetos.TabIndex = 5;
            this.mmObjetos.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gbxSala
            // 
            this.gbxSala.Controls.Add(this.txtCapacidade);
            this.gbxSala.Controls.Add(this.lblCapacidade);
            this.gbxSala.Controls.Add(this.btnCriarSala);
            this.gbxSala.Controls.Add(this.txtNumeroSala);
            this.gbxSala.Controls.Add(this.label2);
            this.gbxSala.Location = new System.Drawing.Point(25, 524);
            this.gbxSala.Name = "gbxSala";
            this.gbxSala.Size = new System.Drawing.Size(314, 189);
            this.gbxSala.TabIndex = 11;
            this.gbxSala.TabStop = false;
            this.gbxSala.Text = "Sala";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(85, 97);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(160, 22);
            this.txtCapacidade.TabIndex = 4;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Location = new System.Drawing.Point(-3, 100);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(82, 16);
            this.lblCapacidade.TabIndex = 3;
            this.lblCapacidade.Text = "Capacidade";
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.Location = new System.Drawing.Point(96, 149);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(97, 23);
            this.btnCriarSala.TabIndex = 2;
            this.btnCriarSala.Text = "Criar Salas";
            this.btnCriarSala.UseVisualStyleBackColor = true;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            // 
            // txtNumeroSala
            // 
            this.txtNumeroSala.Location = new System.Drawing.Point(135, 56);
            this.txtNumeroSala.Name = "txtNumeroSala";
            this.txtNumeroSala.Size = new System.Drawing.Size(160, 22);
            this.txtNumeroSala.TabIndex = 1;
            this.txtNumeroSala.TextChanged += new System.EventHandler(this.txtNumeroSala_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade de salas";
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.btnCriarGenero);
            this.gbxGenero.Controls.Add(this.txtDescricao);
            this.gbxGenero.Controls.Add(this.lblDescricao);
            this.gbxGenero.Location = new System.Drawing.Point(25, 12);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(292, 250);
            this.gbxGenero.TabIndex = 13;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Gênero";
            // 
            // btnCriarGenero
            // 
            this.btnCriarGenero.Location = new System.Drawing.Point(96, 207);
            this.btnCriarGenero.Name = "btnCriarGenero";
            this.btnCriarGenero.Size = new System.Drawing.Size(97, 23);
            this.btnCriarGenero.TabIndex = 2;
            this.btnCriarGenero.Text = "Criar Gênero";
            this.btnCriarGenero.UseVisualStyleBackColor = true;
            this.btnCriarGenero.Click += new System.EventHandler(this.btnCriarGenero_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(96, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(160, 22);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // gbxFilme
            // 
            this.gbxFilme.Controls.Add(this.lblGenero);
            this.gbxFilme.Controls.Add(this.cbxGenero);
            this.gbxFilme.Controls.Add(this.txtDuracao);
            this.gbxFilme.Controls.Add(this.lblDuracao);
            this.gbxFilme.Controls.Add(this.btnCriarFilme);
            this.gbxFilme.Controls.Add(this.txtTitulo);
            this.gbxFilme.Controls.Add(this.lblTitulo);
            this.gbxFilme.Location = new System.Drawing.Point(323, 12);
            this.gbxFilme.Name = "gbxFilme";
            this.gbxFilme.Size = new System.Drawing.Size(399, 250);
            this.gbxFilme.TabIndex = 14;
            this.gbxFilme.TabStop = false;
            this.gbxFilme.Text = "Filme";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 148);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Gênero";
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(96, 140);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(160, 24);
            this.cbxGenero.TabIndex = 5;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(96, 100);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(160, 22);
            this.txtDuracao.TabIndex = 4;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(21, 100);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(59, 16);
            this.lblDuracao.TabIndex = 3;
            this.lblDuracao.Text = "Duração";
            // 
            // btnCriarFilme
            // 
            this.btnCriarFilme.Location = new System.Drawing.Point(159, 207);
            this.btnCriarFilme.Name = "btnCriarFilme";
            this.btnCriarFilme.Size = new System.Drawing.Size(97, 23);
            this.btnCriarFilme.TabIndex = 2;
            this.btnCriarFilme.Text = "Criar Filme";
            this.btnCriarFilme.UseVisualStyleBackColor = true;
            this.btnCriarFilme.Click += new System.EventHandler(this.btnCriarFilme_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(96, 60);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(294, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // gbxAtor
            // 
            this.gbxAtor.Controls.Add(this.label3);
            this.gbxAtor.Controls.Add(this.cbxFilme);
            this.gbxAtor.Controls.Add(this.txtPapel);
            this.gbxAtor.Controls.Add(this.label4);
            this.gbxAtor.Controls.Add(this.btnCriarAtor);
            this.gbxAtor.Controls.Add(this.txtNomeAtor);
            this.gbxAtor.Controls.Add(this.lblNomeAtor);
            this.gbxAtor.Location = new System.Drawing.Point(730, 12);
            this.gbxAtor.Name = "gbxAtor";
            this.gbxAtor.Size = new System.Drawing.Size(383, 250);
            this.gbxAtor.TabIndex = 8;
            this.gbxAtor.TabStop = false;
            this.gbxAtor.Text = "Ator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filme";
            // 
            // cbxFilme
            // 
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Location = new System.Drawing.Point(96, 140);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(278, 24);
            this.cbxFilme.TabIndex = 5;
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(96, 100);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(160, 22);
            this.txtPapel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Papel";
            // 
            // btnCriarAtor
            // 
            this.btnCriarAtor.Location = new System.Drawing.Point(142, 201);
            this.btnCriarAtor.Name = "btnCriarAtor";
            this.btnCriarAtor.Size = new System.Drawing.Size(97, 23);
            this.btnCriarAtor.TabIndex = 2;
            this.btnCriarAtor.Text = "Criar Ator";
            this.btnCriarAtor.UseVisualStyleBackColor = true;
            this.btnCriarAtor.Click += new System.EventHandler(this.btnCriarAtor_Click);
            // 
            // txtNomeAtor
            // 
            this.txtNomeAtor.Location = new System.Drawing.Point(96, 60);
            this.txtNomeAtor.Name = "txtNomeAtor";
            this.txtNomeAtor.Size = new System.Drawing.Size(278, 22);
            this.txtNomeAtor.TabIndex = 1;
            // 
            // lblNomeAtor
            // 
            this.lblNomeAtor.AutoSize = true;
            this.lblNomeAtor.Location = new System.Drawing.Point(21, 60);
            this.lblNomeAtor.Name = "lblNomeAtor";
            this.lblNomeAtor.Size = new System.Drawing.Size(44, 16);
            this.lblNomeAtor.TabIndex = 0;
            this.lblNomeAtor.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 762);
            this.Controls.Add(this.gbxAtor);
            this.Controls.Add(this.gbxFilme);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.gbxSala);
            this.Controls.Add(this.mmObjetos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxSessao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxSessao.ResumeLayout(false);
            this.gbxSessao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbxSala.ResumeLayout(false);
            this.gbxSala.PerformLayout();
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.gbxFilme.ResumeLayout(false);
            this.gbxFilme.PerformLayout();
            this.gbxAtor.ResumeLayout(false);
            this.gbxAtor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCriarFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox txtIdadeFuncionario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdadeCliente;
        private System.Windows.Forms.Label lblIdadeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.GroupBox gbxSessao;
        private System.Windows.Forms.Button btnCriarSessao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDataSessao;
        private System.Windows.Forms.Label lblDataSessao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.RichTextBox mmObjetos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cbxSalaSessao;
        private System.Windows.Forms.GroupBox gbxSala;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.TextBox txtNumeroSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilmeSessao;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.Label lblAtoresPapeis;
        private System.Windows.Forms.TextBox txtGeneroSessao;
        private System.Windows.Forms.Label lblGeneroSessao;
        private System.Windows.Forms.RichTextBox mmAtoresPapeis;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.Button btnCriarGenero;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbxFilme;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Button btnCriarFilme;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxAtor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriarAtor;
        private System.Windows.Forms.TextBox txtNomeAtor;
        private System.Windows.Forms.Label lblNomeAtor;
    }
}

