namespace PROJECTO__BACK_END_
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUtilizadores = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnNovaUnidade = new System.Windows.Forms.Button();
            this.btnInserirCozinha = new System.Windows.Forms.Button();
            this.btnInserirReceitas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUtilizadores);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnNovaUnidade);
            this.panel2.Controls.Add(this.btnInserirCozinha);
            this.panel2.Controls.Add(this.btnInserirReceitas);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(140, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 483);
            this.panel2.TabIndex = 0;
            // 
            // btnUtilizadores
            // 
            this.btnUtilizadores.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizadores.Location = new System.Drawing.Point(272, 327);
            this.btnUtilizadores.Name = "btnUtilizadores";
            this.btnUtilizadores.Size = new System.Drawing.Size(164, 134);
            this.btnUtilizadores.TabIndex = 0;
            this.btnUtilizadores.Text = "Ver Utilizadores";
            this.btnUtilizadores.UseVisualStyleBackColor = true;
            this.btnUtilizadores.Click += new System.EventHandler(this.btnUtilizadores_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(48, 327);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(164, 134);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Criar Novo Utilizador";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnNovaUnidade
            // 
            this.btnNovaUnidade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaUnidade.Location = new System.Drawing.Point(272, 177);
            this.btnNovaUnidade.Name = "btnNovaUnidade";
            this.btnNovaUnidade.Size = new System.Drawing.Size(164, 134);
            this.btnNovaUnidade.TabIndex = 0;
            this.btnNovaUnidade.Text = "Inserir Nova Unidade de Medida";
            this.btnNovaUnidade.UseVisualStyleBackColor = true;
            this.btnNovaUnidade.Click += new System.EventHandler(this.btnNovaUnidade_Click);
            // 
            // btnInserirCozinha
            // 
            this.btnInserirCozinha.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCozinha.Location = new System.Drawing.Point(272, 24);
            this.btnInserirCozinha.Name = "btnInserirCozinha";
            this.btnInserirCozinha.Size = new System.Drawing.Size(164, 134);
            this.btnInserirCozinha.TabIndex = 0;
            this.btnInserirCozinha.Text = "Inserir Novo Tipo de Cozinha";
            this.btnInserirCozinha.UseVisualStyleBackColor = true;
            this.btnInserirCozinha.Click += new System.EventHandler(this.btnInserirCozinha_Click);
            // 
            // btnInserirReceitas
            // 
            this.btnInserirReceitas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirReceitas.Location = new System.Drawing.Point(48, 24);
            this.btnInserirReceitas.Name = "btnInserirReceitas";
            this.btnInserirReceitas.Size = new System.Drawing.Size(164, 134);
            this.btnInserirReceitas.TabIndex = 0;
            this.btnInserirReceitas.Text = "Inserir Receitas";
            this.btnInserirReceitas.UseVisualStyleBackColor = true;
            this.btnInserirReceitas.Click += new System.EventHandler(this.btnInserirReceitas_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 134);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Novo Tipo de Prato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNovoTipoPrato_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 558);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUtilizadores;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnNovaUnidade;
        private System.Windows.Forms.Button btnInserirCozinha;
        private System.Windows.Forms.Button btnInserirReceitas;
        private System.Windows.Forms.Button button1;
    }
}