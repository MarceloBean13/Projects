
namespace Revestir
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRita = new System.Windows.Forms.Label();
            this.btnForn = new System.Windows.Forms.Button();
            this.btnCriarForn = new System.Windows.Forms.Button();
            this.btnArtigos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRita
            // 
            this.lbRita.AutoSize = true;
            this.lbRita.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRita.Location = new System.Drawing.Point(318, 47);
            this.lbRita.Name = "lbRita";
            this.lbRita.Size = new System.Drawing.Size(119, 37);
            this.lbRita.TabIndex = 0;
            this.lbRita.Text = "Olá Rita!";
            this.lbRita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForn
            // 
            this.btnForn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForn.Location = new System.Drawing.Point(107, 200);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(148, 113);
            this.btnForn.TabIndex = 1;
            this.btnForn.Text = "Ver Fornecedores";
            this.btnForn.UseVisualStyleBackColor = true;
            this.btnForn.Click += new System.EventHandler(this.btnForn_Click);
            // 
            // btnCriarForn
            // 
            this.btnCriarForn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriarForn.Location = new System.Drawing.Point(512, 200);
            this.btnCriarForn.Name = "btnCriarForn";
            this.btnCriarForn.Size = new System.Drawing.Size(148, 113);
            this.btnCriarForn.TabIndex = 2;
            this.btnCriarForn.Text = "Criar Fornecedor";
            this.btnCriarForn.UseVisualStyleBackColor = true;
            this.btnCriarForn.Click += new System.EventHandler(this.btnCriarForn_Click);
            // 
            // btnArtigos
            // 
            this.btnArtigos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArtigos.Location = new System.Drawing.Point(318, 200);
            this.btnArtigos.Name = "btnArtigos";
            this.btnArtigos.Size = new System.Drawing.Size(137, 113);
            this.btnArtigos.TabIndex = 2;
            this.btnArtigos.Text = "Ver Artigos";
            this.btnArtigos.UseVisualStyleBackColor = true;
            this.btnArtigos.Click += new System.EventHandler(this.btnArtigos_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArtigos);
            this.Controls.Add(this.btnCriarForn);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.lbRita);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revestir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRita;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Button btnCriarForn;
        private System.Windows.Forms.Button btnArtigos;
    }
}

