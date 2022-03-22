namespace PROJECTO__BACK_END_
{
    partial class Receitas
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
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lbTipoCozinha = new System.Windows.Forms.Label();
            this.lbTipoPrato = new System.Windows.Forms.Label();
            this.lbDoses = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.cbTipoPrato = new System.Windows.Forms.ComboBox();
            this.cbTipoCozinha = new System.Windows.Forms.ComboBox();
            this.cbTempo = new System.Windows.Forms.ComboBox();
            this.nudDoses = new System.Windows.Forms.NumericUpDown();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.dgvIngrediente = new System.Windows.Forms.DataGridView();
            this.lbIngrediente = new System.Windows.Forms.Label();
            this.txtNomeIngrediente = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.btnInserirIngrediente = new System.Windows.Forms.Button();
            this.btnModificarIngrediente = new System.Windows.Forms.Button();
            this.btnRemoverIngrediente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificarReceita = new System.Windows.Forms.Button();
            this.btnRemoverReceita = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.lbAprovar = new System.Windows.Forms.Label();
            this.cbAprovar = new System.Windows.Forms.ComboBox();
            this.lbImagem = new System.Windows.Forms.Label();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.AllowUserToResizeColumns = false;
            this.dgvReceitas.AllowUserToResizeRows = false;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(12, 36);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.RowHeadersVisible = false;
            this.dgvReceitas.RowHeadersWidth = 51;
            this.dgvReceitas.RowTemplate.Height = 24;
            this.dgvReceitas.Size = new System.Drawing.Size(451, 497);
            this.dgvReceitas.TabIndex = 0;
            this.dgvReceitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvReceitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceitas_CellContentClick);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(485, 94);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(141, 23);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome da Receita";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.Location = new System.Drawing.Point(777, 164);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(162, 23);
            this.lbNivel.TabIndex = 1;
            this.lbNivel.Text = "Nivel de Dificuldade";
            // 
            // lbTipoCozinha
            // 
            this.lbTipoCozinha.AutoSize = true;
            this.lbTipoCozinha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoCozinha.Location = new System.Drawing.Point(485, 236);
            this.lbTipoCozinha.Name = "lbTipoCozinha";
            this.lbTipoCozinha.Size = new System.Drawing.Size(134, 23);
            this.lbTipoCozinha.TabIndex = 1;
            this.lbTipoCozinha.Text = "Tipo de Cozinha";
            // 
            // lbTipoPrato
            // 
            this.lbTipoPrato.AutoSize = true;
            this.lbTipoPrato.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoPrato.Location = new System.Drawing.Point(485, 164);
            this.lbTipoPrato.Name = "lbTipoPrato";
            this.lbTipoPrato.Size = new System.Drawing.Size(113, 23);
            this.lbTipoPrato.TabIndex = 1;
            this.lbTipoPrato.Text = "Tipo de Prato";
            // 
            // lbDoses
            // 
            this.lbDoses.AutoSize = true;
            this.lbDoses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoses.Location = new System.Drawing.Point(483, 301);
            this.lbDoses.Name = "lbDoses";
            this.lbDoses.Size = new System.Drawing.Size(55, 23);
            this.lbDoses.TabIndex = 1;
            this.lbDoses.Text = "Doses";
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.Location = new System.Drawing.Point(773, 301);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(161, 23);
            this.lbTempo.TabIndex = 1;
            this.lbTempo.Text = "Tempo de Execução";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeReceita.Location = new System.Drawing.Point(488, 120);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(451, 30);
            this.txtNomeReceita.TabIndex = 1;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(780, 190);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(196, 31);
            this.cbNivel.TabIndex = 2;
            // 
            // cbTipoPrato
            // 
            this.cbTipoPrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPrato.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPrato.FormattingEnabled = true;
            this.cbTipoPrato.Location = new System.Drawing.Point(488, 190);
            this.cbTipoPrato.Name = "cbTipoPrato";
            this.cbTipoPrato.Size = new System.Drawing.Size(196, 31);
            this.cbTipoPrato.TabIndex = 5;
            // 
            // cbTipoCozinha
            // 
            this.cbTipoCozinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCozinha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCozinha.FormattingEnabled = true;
            this.cbTipoCozinha.Location = new System.Drawing.Point(489, 262);
            this.cbTipoCozinha.Name = "cbTipoCozinha";
            this.cbTipoCozinha.Size = new System.Drawing.Size(162, 31);
            this.cbTipoCozinha.TabIndex = 4;
            // 
            // cbTempo
            // 
            this.cbTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempo.FormattingEnabled = true;
            this.cbTempo.Location = new System.Drawing.Point(777, 327);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(194, 31);
            this.cbTempo.TabIndex = 7;
            this.cbTempo.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // nudDoses
            // 
            this.nudDoses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDoses.Location = new System.Drawing.Point(486, 327);
            this.nudDoses.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudDoses.Name = "nudDoses";
            this.nudDoses.Size = new System.Drawing.Size(120, 30);
            this.nudDoses.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(489, 407);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(486, 161);
            this.txtDescricao.TabIndex = 5;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(484, 381);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(83, 23);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descrição";
            // 
            // dgvIngrediente
            // 
            this.dgvIngrediente.AllowUserToAddRows = false;
            this.dgvIngrediente.AllowUserToDeleteRows = false;
            this.dgvIngrediente.AllowUserToOrderColumns = true;
            this.dgvIngrediente.AllowUserToResizeColumns = false;
            this.dgvIngrediente.AllowUserToResizeRows = false;
            this.dgvIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngrediente.Location = new System.Drawing.Point(12, 561);
            this.dgvIngrediente.MultiSelect = false;
            this.dgvIngrediente.Name = "dgvIngrediente";
            this.dgvIngrediente.ReadOnly = true;
            this.dgvIngrediente.RowHeadersVisible = false;
            this.dgvIngrediente.RowHeadersWidth = 51;
            this.dgvIngrediente.RowTemplate.Height = 24;
            this.dgvIngrediente.Size = new System.Drawing.Size(408, 229);
            this.dgvIngrediente.TabIndex = 0;
            this.dgvIngrediente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngrediente_CellClick);
            // 
            // lbIngrediente
            // 
            this.lbIngrediente.AutoSize = true;
            this.lbIngrediente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngrediente.Location = new System.Drawing.Point(499, 682);
            this.lbIngrediente.Name = "lbIngrediente";
            this.lbIngrediente.Size = new System.Drawing.Size(150, 23);
            this.lbIngrediente.TabIndex = 1;
            this.lbIngrediente.Text = "Nome Ingrediente";
            // 
            // txtNomeIngrediente
            // 
            this.txtNomeIngrediente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeIngrediente.Location = new System.Drawing.Point(502, 708);
            this.txtNomeIngrediente.Name = "txtNomeIngrediente";
            this.txtNomeIngrediente.Size = new System.Drawing.Size(223, 30);
            this.txtNomeIngrediente.TabIndex = 2;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(756, 682);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(100, 23);
            this.lbQuantidade.TabIndex = 1;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(759, 708);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 30);
            this.nudQuantidade.TabIndex = 4;
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidade.Location = new System.Drawing.Point(610, 758);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(160, 23);
            this.lbUnidade.TabIndex = 1;
            this.lbUnidade.Text = "Unidade de Medida";
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(614, 784);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(194, 31);
            this.cbUnidade.TabIndex = 3;
            this.cbUnidade.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // btnInserirIngrediente
            // 
            this.btnInserirIngrediente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirIngrediente.Location = new System.Drawing.Point(489, 853);
            this.btnInserirIngrediente.Name = "btnInserirIngrediente";
            this.btnInserirIngrediente.Size = new System.Drawing.Size(146, 65);
            this.btnInserirIngrediente.TabIndex = 6;
            this.btnInserirIngrediente.Text = "Inserir Ingrediente";
            this.btnInserirIngrediente.UseVisualStyleBackColor = true;
            this.btnInserirIngrediente.Click += new System.EventHandler(this.btnInserirIngrediente_Click);
            // 
            // btnModificarIngrediente
            // 
            this.btnModificarIngrediente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIngrediente.Location = new System.Drawing.Point(670, 853);
            this.btnModificarIngrediente.Name = "btnModificarIngrediente";
            this.btnModificarIngrediente.Size = new System.Drawing.Size(146, 65);
            this.btnModificarIngrediente.TabIndex = 6;
            this.btnModificarIngrediente.Text = "Modificar Ingrediente";
            this.btnModificarIngrediente.UseVisualStyleBackColor = true;
            this.btnModificarIngrediente.Click += new System.EventHandler(this.btnModificarIngrediente_Click);
            // 
            // btnRemoverIngrediente
            // 
            this.btnRemoverIngrediente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverIngrediente.Location = new System.Drawing.Point(851, 853);
            this.btnRemoverIngrediente.Name = "btnRemoverIngrediente";
            this.btnRemoverIngrediente.Size = new System.Drawing.Size(146, 65);
            this.btnRemoverIngrediente.TabIndex = 6;
            this.btnRemoverIngrediente.Text = "Remover Ingrediente";
            this.btnRemoverIngrediente.UseVisualStyleBackColor = true;
            this.btnRemoverIngrediente.Click += new System.EventHandler(this.btnRemoverIngrediente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(489, 596);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 65);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Receita";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificarReceita
            // 
            this.btnModificarReceita.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReceita.Location = new System.Drawing.Point(670, 596);
            this.btnModificarReceita.Name = "btnModificarReceita";
            this.btnModificarReceita.Size = new System.Drawing.Size(146, 65);
            this.btnModificarReceita.TabIndex = 6;
            this.btnModificarReceita.Text = "Modificar Receita";
            this.btnModificarReceita.UseVisualStyleBackColor = true;
            this.btnModificarReceita.Click += new System.EventHandler(this.btnModificarReceita_Click);
            // 
            // btnRemoverReceita
            // 
            this.btnRemoverReceita.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverReceita.Location = new System.Drawing.Point(851, 596);
            this.btnRemoverReceita.Name = "btnRemoverReceita";
            this.btnRemoverReceita.Size = new System.Drawing.Size(146, 65);
            this.btnRemoverReceita.TabIndex = 6;
            this.btnRemoverReceita.Text = " ";
            this.btnRemoverReceita.UseVisualStyleBackColor = true;
            this.btnRemoverReceita.Click += new System.EventHandler(this.btnRemoverReceita_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1292, 26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(146, 65);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(1103, 26);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(146, 65);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar Dados";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(489, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(484, 26);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(135, 23);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Procurar Receita";
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            // 
            // lbAprovar
            // 
            this.lbAprovar.AutoSize = true;
            this.lbAprovar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAprovar.Location = new System.Drawing.Point(777, 236);
            this.lbAprovar.Name = "lbAprovar";
            this.lbAprovar.Size = new System.Drawing.Size(84, 23);
            this.lbAprovar.TabIndex = 1;
            this.lbAprovar.Text = "Aprovado";
            // 
            // cbAprovar
            // 
            this.cbAprovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAprovar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAprovar.FormattingEnabled = true;
            this.cbAprovar.Items.AddRange(new object[] {
            "True",
            "False "});
            this.cbAprovar.Location = new System.Drawing.Point(781, 262);
            this.cbAprovar.Name = "cbAprovar";
            this.cbAprovar.Size = new System.Drawing.Size(111, 31);
            this.cbAprovar.TabIndex = 7;
            this.cbAprovar.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // lbImagem
            // 
            this.lbImagem.AutoSize = true;
            this.lbImagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagem.Location = new System.Drawing.Point(1019, 253);
            this.lbImagem.Name = "lbImagem";
            this.lbImagem.Size = new System.Drawing.Size(157, 23);
            this.lbImagem.TabIndex = 1;
            this.lbImagem.Text = "Imagem da Receita";
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirImagem.Location = new System.Drawing.Point(1103, 596);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(146, 65);
            this.btnAbrirImagem.TabIndex = 6;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::PROJECTO__BACK_END_.Properties.Resources.Imagem;
            this.pbImagem.ImageLocation = "";
            this.pbImagem.InitialImage = null;
            this.pbImagem.Location = new System.Drawing.Point(1023, 279);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(415, 299);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem.TabIndex = 8;
            this.pbImagem.TabStop = false;
            // 
            // Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 972);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.btnRemoverReceita);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRemoverIngrediente);
            this.Controls.Add(this.btnModificarReceita);
            this.Controls.Add(this.btnModificarIngrediente);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnInserirIngrediente);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.nudDoses);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.cbAprovar);
            this.Controls.Add(this.cbTempo);
            this.Controls.Add(this.cbTipoCozinha);
            this.Controls.Add(this.cbTipoPrato);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.txtNomeIngrediente);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.lbUnidade);
            this.Controls.Add(this.lbAprovar);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.lbTipoPrato);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbDoses);
            this.Controls.Add(this.lbTipoCozinha);
            this.Controls.Add(this.lbImagem);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lbIngrediente);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgvIngrediente);
            this.Controls.Add(this.dgvReceitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Receitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Receitas";
            this.Load += new System.EventHandler(this.Receitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lbTipoCozinha;
        private System.Windows.Forms.Label lbTipoPrato;
        private System.Windows.Forms.Label lbDoses;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.ComboBox cbTipoPrato;
        private System.Windows.Forms.ComboBox cbTipoCozinha;
        private System.Windows.Forms.ComboBox cbTempo;
        private System.Windows.Forms.NumericUpDown nudDoses;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.DataGridView dgvIngrediente;
        private System.Windows.Forms.Label lbIngrediente;
        private System.Windows.Forms.TextBox txtNomeIngrediente;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Button btnInserirIngrediente;
        private System.Windows.Forms.Button btnModificarIngrediente;
        private System.Windows.Forms.Button btnRemoverIngrediente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificarReceita;
        private System.Windows.Forms.Button btnRemoverReceita;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.Label lbAprovar;
        private System.Windows.Forms.ComboBox cbAprovar;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label lbImagem;
        private System.Windows.Forms.Button btnAbrirImagem;
    }
}