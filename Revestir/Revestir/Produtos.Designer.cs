namespace Revestir
{
    partial class Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.nudReferência = new System.Windows.Forms.NumericUpDown();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.cbDevolvido = new System.Windows.Forms.ComboBox();
            this.lbDevolvido = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nudPreçoFornecedor = new System.Windows.Forms.NumericUpDown();
            this.nudPreçoFinal = new System.Windows.Forms.NumericUpDown();
            this.lbPreçoFornecedor = new System.Windows.Forms.Label();
            this.lbPreçoFinal = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lbeuros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lbProcurar = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pcImagem = new System.Windows.Forms.PictureBox();
            this.lbImagem = new System.Windows.Forms.Label();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnInstrucoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReferência)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreçoFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreçoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(20, 31);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(346, 522);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(377, 108);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(326, 30);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(377, 166);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(107, 30);
            this.txtTamanho.TabIndex = 2;
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeProduto.Location = new System.Drawing.Point(374, 81);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(149, 23);
            this.lbNomeProduto.TabIndex = 3;
            this.lbNomeProduto.Text = "Nome do Produto";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(531, 166);
            this.txtCor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(125, 30);
            this.txtCor.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(629, 343);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 31);
            this.cbCategoria.TabIndex = 2;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(626, 319);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(84, 23);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamanho.Location = new System.Drawing.Point(373, 142);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(80, 23);
            this.lbTamanho.TabIndex = 3;
            this.lbTamanho.Text = "Tamanho";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCor.Location = new System.Drawing.Point(530, 142);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(37, 23);
            this.lbCor.TabIndex = 3;
            this.lbCor.Text = "Cor";
            // 
            // nudReferência
            // 
            this.nudReferência.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReferência.Location = new System.Drawing.Point(377, 287);
            this.nudReferência.Margin = new System.Windows.Forms.Padding(2);
            this.nudReferência.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudReferência.Name = "nudReferência";
            this.nudReferência.Size = new System.Drawing.Size(56, 30);
            this.nudReferência.TabIndex = 4;
            this.nudReferência.ValueChanged += new System.EventHandler(this.nudReferência_ValueChanged);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFornecedor.Location = new System.Drawing.Point(374, 200);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(96, 23);
            this.lbFornecedor.TabIndex = 3;
            this.lbFornecedor.Text = "Fornecedor";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferencia.Location = new System.Drawing.Point(373, 262);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(89, 23);
            this.lbReferencia.TabIndex = 3;
            this.lbReferencia.Text = "Referência";
            // 
            // cbDevolvido
            // 
            this.cbDevolvido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevolvido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDevolvido.FormattingEnabled = true;
            this.cbDevolvido.Location = new System.Drawing.Point(629, 405);
            this.cbDevolvido.Name = "cbDevolvido";
            this.cbDevolvido.Size = new System.Drawing.Size(121, 31);
            this.cbDevolvido.TabIndex = 5;
            // 
            // lbDevolvido
            // 
            this.lbDevolvido.AutoSize = true;
            this.lbDevolvido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevolvido.Location = new System.Drawing.Point(625, 378);
            this.lbDevolvido.Name = "lbDevolvido";
            this.lbDevolvido.Size = new System.Drawing.Size(85, 23);
            this.lbDevolvido.TabIndex = 3;
            this.lbDevolvido.Text = "Devolvido";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(395, 478);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(104, 44);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(531, 478);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 44);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(667, 478);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 44);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // nudPreçoFornecedor
            // 
            this.nudPreçoFornecedor.DecimalPlaces = 2;
            this.nudPreçoFornecedor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPreçoFornecedor.Location = new System.Drawing.Point(481, 286);
            this.nudPreçoFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreçoFornecedor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPreçoFornecedor.Name = "nudPreçoFornecedor";
            this.nudPreçoFornecedor.Size = new System.Drawing.Size(82, 30);
            this.nudPreçoFornecedor.TabIndex = 5;
            this.nudPreçoFornecedor.ValueChanged += new System.EventHandler(this.nudReferência_ValueChanged);
            // 
            // nudPreçoFinal
            // 
            this.nudPreçoFinal.DecimalPlaces = 2;
            this.nudPreçoFinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPreçoFinal.Location = new System.Drawing.Point(621, 288);
            this.nudPreçoFinal.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreçoFinal.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPreçoFinal.Name = "nudPreçoFinal";
            this.nudPreçoFinal.Size = new System.Drawing.Size(89, 30);
            this.nudPreçoFinal.TabIndex = 6;
            this.nudPreçoFinal.ValueChanged += new System.EventHandler(this.nudReferência_ValueChanged);
            // 
            // lbPreçoFornecedor
            // 
            this.lbPreçoFornecedor.AutoSize = true;
            this.lbPreçoFornecedor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreçoFornecedor.Location = new System.Drawing.Point(466, 262);
            this.lbPreçoFornecedor.Name = "lbPreçoFornecedor";
            this.lbPreçoFornecedor.Size = new System.Drawing.Size(144, 23);
            this.lbPreçoFornecedor.TabIndex = 3;
            this.lbPreçoFornecedor.Text = "Preço Fornecedor";
            // 
            // lbPreçoFinal
            // 
            this.lbPreçoFinal.AutoSize = true;
            this.lbPreçoFinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreçoFinal.Location = new System.Drawing.Point(617, 262);
            this.lbPreçoFinal.Name = "lbPreçoFinal";
            this.lbPreçoFinal.Size = new System.Drawing.Size(93, 23);
            this.lbPreçoFinal.TabIndex = 3;
            this.lbPreçoFinal.Text = "Preço Final";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(377, 343);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(233, 108);
            this.txtDescricao.TabIndex = 7;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(373, 319);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(83, 23);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(372, 227);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(326, 31);
            this.cbFornecedor.TabIndex = 6;
            // 
            // lbeuros
            // 
            this.lbeuros.AutoSize = true;
            this.lbeuros.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeuros.Location = new System.Drawing.Point(712, 291);
            this.lbeuros.Name = "lbeuros";
            this.lbeuros.Size = new System.Drawing.Size(19, 23);
            this.lbeuros.TabIndex = 3;
            this.lbeuros.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "€";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(377, 32);
            this.txtProcurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(326, 30);
            this.txtProcurar.TabIndex = 1;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // lbProcurar
            // 
            this.lbProcurar.AutoSize = true;
            this.lbProcurar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcurar.Location = new System.Drawing.Point(373, 9);
            this.lbProcurar.Name = "lbProcurar";
            this.lbProcurar.Size = new System.Drawing.Size(142, 23);
            this.lbProcurar.TabIndex = 3;
            this.lbProcurar.Text = "Procurar Produto";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(899, 11);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(143, 49);
            this.btnMenu.TabIndex = 26;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(1055, 11);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(143, 49);
            this.btnApagar.TabIndex = 26;
            this.btnApagar.Text = "Apagar Dados";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // pcImagem
            // 
            this.pcImagem.InitialImage = global::Revestir.Properties.Resources.Inserir;
            this.pcImagem.Location = new System.Drawing.Point(786, 124);
            this.pcImagem.Margin = new System.Windows.Forms.Padding(2);
            this.pcImagem.Name = "pcImagem";
            this.pcImagem.Size = new System.Drawing.Size(399, 429);
            this.pcImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagem.TabIndex = 27;
            this.pcImagem.TabStop = false;
            // 
            // lbImagem
            // 
            this.lbImagem.AutoSize = true;
            this.lbImagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagem.Location = new System.Drawing.Point(951, 99);
            this.lbImagem.Name = "lbImagem";
            this.lbImagem.Size = new System.Drawing.Size(73, 23);
            this.lbImagem.TabIndex = 3;
            this.lbImagem.Text = "Imagem";
            this.lbImagem.Visible = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirImagem.Location = new System.Drawing.Point(933, 557);
            this.btnAbrirImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(128, 30);
            this.btnAbrirImagem.TabIndex = 26;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnInstrucoes
            // 
            this.btnInstrucoes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrucoes.Location = new System.Drawing.Point(743, 11);
            this.btnInstrucoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnInstrucoes.Name = "btnInstrucoes";
            this.btnInstrucoes.Size = new System.Drawing.Size(143, 49);
            this.btnInstrucoes.TabIndex = 26;
            this.btnInstrucoes.Text = "Instruções";
            this.btnInstrucoes.UseVisualStyleBackColor = true;
            this.btnInstrucoes.Click += new System.EventHandler(this.btnInstrucoes_Click);
            // 
            // Produtos
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 592);
            this.Controls.Add(this.pcImagem);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.btnInstrucoes);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.nudPreçoFinal);
            this.Controls.Add(this.nudPreçoFornecedor);
            this.Controls.Add(this.nudReferência);
            this.Controls.Add(this.lbDevolvido);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbImagem);
            this.Controls.Add(this.lbeuros);
            this.Controls.Add(this.lbPreçoFinal);
            this.Controls.Add(this.lbPreçoFornecedor);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.lbFornecedor);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.cbDevolvido);
            this.Controls.Add(this.lbProcurar);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReferência)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreçoFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreçoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.NumericUpDown nudReferência;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.ComboBox cbDevolvido;
        private System.Windows.Forms.Label lbDevolvido;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown nudPreçoFornecedor;
        private System.Windows.Forms.NumericUpDown nudPreçoFinal;
        private System.Windows.Forms.Label lbPreçoFornecedor;
        private System.Windows.Forms.Label lbPreçoFinal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbeuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lbProcurar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pcImagem;
        private System.Windows.Forms.Label lbImagem;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Button btnInstrucoes;
    }
}