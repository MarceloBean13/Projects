
namespace Revestir
{
    partial class VerFornecedor
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
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.lbForn = new System.Windows.Forms.Label();
            this.txtPNome = new System.Windows.Forms.TextBox();
            this.txtUNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbUltimoNome = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbNGuia = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AllowUserToDeleteRows = false;
            this.dgvForn.AllowUserToResizeColumns = false;
            this.dgvForn.AllowUserToResizeRows = false;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Location = new System.Drawing.Point(46, 96);
            this.dgvForn.MultiSelect = false;
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.ReadOnly = true;
            this.dgvForn.RowHeadersVisible = false;
            this.dgvForn.RowHeadersWidth = 51;
            this.dgvForn.RowTemplate.Height = 29;
            this.dgvForn.Size = new System.Drawing.Size(717, 356);
            this.dgvForn.TabIndex = 0;
            this.dgvForn.TabStop = false;
            this.dgvForn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellClick);
            // 
            // lbForn
            // 
            this.lbForn.AutoSize = true;
            this.lbForn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbForn.Location = new System.Drawing.Point(273, 33);
            this.lbForn.Name = "lbForn";
            this.lbForn.Size = new System.Drawing.Size(176, 37);
            this.lbForn.TabIndex = 0;
            this.lbForn.Text = "Fornecedores";
            // 
            // txtPNome
            // 
            this.txtPNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPNome.Location = new System.Drawing.Point(799, 96);
            this.txtPNome.Name = "txtPNome";
            this.txtPNome.Size = new System.Drawing.Size(310, 34);
            this.txtPNome.TabIndex = 1;
            // 
            // txtUNome
            // 
            this.txtUNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUNome.Location = new System.Drawing.Point(799, 187);
            this.txtUNome.Name = "txtUNome";
            this.txtUNome.Size = new System.Drawing.Size(310, 34);
            this.txtUNome.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(799, 58);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(145, 28);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Primeiro Nome";
            // 
            // lbUltimoNome
            // 
            this.lbUltimoNome.AutoSize = true;
            this.lbUltimoNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUltimoNome.Location = new System.Drawing.Point(799, 152);
            this.lbUltimoNome.Name = "lbUltimoNome";
            this.lbUltimoNome.Size = new System.Drawing.Size(131, 28);
            this.lbUltimoNome.TabIndex = 5;
            this.lbUltimoNome.Text = "Último Nome";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTel.Location = new System.Drawing.Point(799, 334);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(84, 28);
            this.lbTel.TabIndex = 7;
            this.lbTel.Text = "Telefone";
            // 
            // txtTele
            // 
            this.txtTele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTele.Location = new System.Drawing.Point(799, 369);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(310, 34);
            this.txtTele.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(46, 494);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 53);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(799, 468);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(799, 433);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 28);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "E-Mail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(799, 556);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 77);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Modificar Dados ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(987, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 77);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar Fornecedor";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbNGuia
            // 
            this.lbNGuia.AutoSize = true;
            this.lbNGuia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNGuia.Location = new System.Drawing.Point(799, 248);
            this.lbNGuia.Name = "lbNGuia";
            this.lbNGuia.Size = new System.Drawing.Size(108, 28);
            this.lbNGuia.TabIndex = 5;
            this.lbNGuia.Text = "Nº de Guia";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbReferencia.Location = new System.Drawing.Point(799, 290);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(0, 28);
            this.lbReferencia.TabIndex = 5;
            // 
            // VerFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 673);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.lbNGuia);
            this.Controls.Add(this.lbUltimoNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtUNome);
            this.Controls.Add(this.txtPNome);
            this.Controls.Add(this.lbForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Fornecedor";
            this.Load += new System.EventHandler(this.VerFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForn;
        private System.Windows.Forms.TextBox txtPNome;
        private System.Windows.Forms.TextBox txtUNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbUltimoNome;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbNGuia;
        private System.Windows.Forms.Label lbReferencia;
    }
}