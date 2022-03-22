
namespace Revestir
{
    partial class VerArtigos
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
            this.lbForn = new System.Windows.Forms.Label();
            this.dgvArtigos = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.lbDescri = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.lbPreço = new System.Windows.Forms.Label();
            this.nudPreço = new System.Windows.Forms.NumericUpDown();
            this.lbEur = new System.Windows.Forms.Label();
            this.lbDataVenda = new System.Windows.Forms.Label();
            this.lbPagamento = new System.Windows.Forms.Label();
            this.lbArtigos = new System.Windows.Forms.Label();
            this.cbVendido = new System.Windows.Forms.CheckBox();
            this.cbPago = new System.Windows.Forms.CheckBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lbNPeca = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreço)).BeginInit();
            this.SuspendLayout();
            // 
            // lbForn
            // 
            this.lbForn.AutoSize = true;
            this.lbForn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbForn.Location = new System.Drawing.Point(123, 36);
            this.lbForn.Name = "lbForn";
            this.lbForn.Size = new System.Drawing.Size(176, 37);
            this.lbForn.TabIndex = 0;
            this.lbForn.Text = "Fornecedores";
            // 
            // dgvArtigos
            // 
            this.dgvArtigos.AllowUserToAddRows = false;
            this.dgvArtigos.AllowUserToDeleteRows = false;
            this.dgvArtigos.AllowUserToResizeColumns = false;
            this.dgvArtigos.AllowUserToResizeRows = false;
            this.dgvArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtigos.Location = new System.Drawing.Point(90, 506);
            this.dgvArtigos.MultiSelect = false;
            this.dgvArtigos.Name = "dgvArtigos";
            this.dgvArtigos.ReadOnly = true;
            this.dgvArtigos.RowHeadersVisible = false;
            this.dgvArtigos.RowHeadersWidth = 51;
            this.dgvArtigos.RowTemplate.Height = 29;
            this.dgvArtigos.Size = new System.Drawing.Size(837, 232);
            this.dgvArtigos.TabIndex = 0;
            this.dgvArtigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtigos_CellClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(540, 95);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(80, 28);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Nº Peça";
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AllowUserToDeleteRows = false;
            this.dgvForn.AllowUserToResizeColumns = false;
            this.dgvForn.AllowUserToResizeRows = false;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Location = new System.Drawing.Point(25, 95);
            this.dgvForn.MultiSelect = false;
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.ReadOnly = true;
            this.dgvForn.RowHeadersVisible = false;
            this.dgvForn.RowHeadersWidth = 51;
            this.dgvForn.RowTemplate.Height = 29;
            this.dgvForn.Size = new System.Drawing.Size(384, 267);
            this.dgvForn.TabIndex = 0;
            this.dgvForn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellClick);
            // 
            // lbDescri
            // 
            this.lbDescri.AutoSize = true;
            this.lbDescri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescri.Location = new System.Drawing.Point(635, 184);
            this.lbDescri.Name = "lbDescri";
            this.lbDescri.Size = new System.Drawing.Size(140, 28);
            this.lbDescri.TabIndex = 0;
            this.lbDescri.Text = "Descrição Peça";
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(430, 215);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(566, 27);
            this.txtDescri.TabIndex = 2;
            // 
            // lbPreço
            // 
            this.lbPreço.AutoSize = true;
            this.lbPreço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPreço.Location = new System.Drawing.Point(714, 95);
            this.lbPreço.Name = "lbPreço";
            this.lbPreço.Size = new System.Drawing.Size(61, 28);
            this.lbPreço.TabIndex = 0;
            this.lbPreço.Text = "Preço";
            // 
            // nudPreço
            // 
            this.nudPreço.DecimalPlaces = 2;
            this.nudPreço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPreço.Location = new System.Drawing.Point(681, 126);
            this.nudPreço.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPreço.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPreço.Name = "nudPreço";
            this.nudPreço.Size = new System.Drawing.Size(127, 34);
            this.nudPreço.TabIndex = 3;
            this.nudPreço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPreço.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbEur
            // 
            this.lbEur.AutoSize = true;
            this.lbEur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEur.Location = new System.Drawing.Point(814, 128);
            this.lbEur.Name = "lbEur";
            this.lbEur.Size = new System.Drawing.Size(23, 28);
            this.lbEur.TabIndex = 0;
            this.lbEur.Text = "€";
            // 
            // lbDataVenda
            // 
            this.lbDataVenda.AutoSize = true;
            this.lbDataVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataVenda.Location = new System.Drawing.Point(442, 277);
            this.lbDataVenda.Name = "lbDataVenda";
            this.lbDataVenda.Size = new System.Drawing.Size(139, 28);
            this.lbDataVenda.TabIndex = 0;
            this.lbDataVenda.Text = "Data de Venda";
            // 
            // lbPagamento
            // 
            this.lbPagamento.AutoSize = true;
            this.lbPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPagamento.Location = new System.Drawing.Point(771, 277);
            this.lbPagamento.Name = "lbPagamento";
            this.lbPagamento.Size = new System.Drawing.Size(184, 28);
            this.lbPagamento.TabIndex = 0;
            this.lbPagamento.Text = "Data de Pagamento";
            // 
            // lbArtigos
            // 
            this.lbArtigos.AutoSize = true;
            this.lbArtigos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArtigos.Location = new System.Drawing.Point(442, 455);
            this.lbArtigos.Name = "lbArtigos";
            this.lbArtigos.Size = new System.Drawing.Size(102, 37);
            this.lbArtigos.TabIndex = 0;
            this.lbArtigos.Text = "Artigos";
            // 
            // cbVendido
            // 
            this.cbVendido.AutoSize = true;
            this.cbVendido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVendido.Location = new System.Drawing.Point(463, 338);
            this.cbVendido.Name = "cbVendido";
            this.cbVendido.Size = new System.Drawing.Size(107, 32);
            this.cbVendido.TabIndex = 3;
            this.cbVendido.Text = "Vendido";
            this.cbVendido.UseVisualStyleBackColor = true;
            this.cbVendido.CheckedChanged += new System.EventHandler(this.cbVendido_CheckedChanged);
            // 
            // cbPago
            // 
            this.cbPago.AutoSize = true;
            this.cbPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPago.Location = new System.Drawing.Point(814, 338);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(78, 32);
            this.cbPago.TabIndex = 5;
            this.cbPago.Text = "Pago";
            this.cbPago.UseVisualStyleBackColor = true;
            this.cbPago.CheckedChanged += new System.EventHandler(this.cbPago_CheckedChanged);
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriar.Location = new System.Drawing.Point(123, 793);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(136, 68);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Artigo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(430, 793);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 68);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar Artigo";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(784, 793);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 68);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar ao Menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lbNPeca
            // 
            this.lbNPeca.AutoSize = true;
            this.lbNPeca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNPeca.Location = new System.Drawing.Point(540, 132);
            this.lbNPeca.Name = "lbNPeca";
            this.lbNPeca.Size = new System.Drawing.Size(0, 28);
            this.lbNPeca.TabIndex = 0;
            // 
            // txtVenda
            // 
            this.txtVenda.Enabled = false;
            this.txtVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVenda.Location = new System.Drawing.Point(445, 391);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(125, 34);
            this.txtVenda.TabIndex = 4;
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPago.Location = new System.Drawing.Point(795, 391);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(125, 34);
            this.txtPago.TabIndex = 6;
            // 
            // VerArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 896);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cbPago);
            this.Controls.Add(this.cbVendido);
            this.Controls.Add(this.nudPreço);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.lbEur);
            this.Controls.Add(this.lbPreço);
            this.Controls.Add(this.lbPagamento);
            this.Controls.Add(this.lbDataVenda);
            this.Controls.Add(this.lbDescri);
            this.Controls.Add(this.lbNPeca);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.dgvArtigos);
            this.Controls.Add(this.lbArtigos);
            this.Controls.Add(this.lbForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerArtigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artigos";
            this.Load += new System.EventHandler(this.VerArtigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreço)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForn;
        private System.Windows.Forms.DataGridView dgvArtigos;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.Label lbDescri;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.Label lbPreço;
        private System.Windows.Forms.NumericUpDown nudPreço;
        private System.Windows.Forms.Label lbEur;
        private System.Windows.Forms.Label lbDataVenda;
        private System.Windows.Forms.Label lbPagamento;
        private System.Windows.Forms.Label lbArtigos;
        private System.Windows.Forms.CheckBox cbVendido;
        private System.Windows.Forms.CheckBox cbPago;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbNPeca;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtPago;
    }
}