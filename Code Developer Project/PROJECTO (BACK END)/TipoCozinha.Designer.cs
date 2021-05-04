namespace PROJECTO__BACK_END_
{
    partial class TipoCozinha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCozinha = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lbCozinha = new System.Windows.Forms.Label();
            this.txtCozinha = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCozinha)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCozinha
            // 
            this.gridCozinha.AllowUserToAddRows = false;
            this.gridCozinha.AllowUserToDeleteRows = false;
            this.gridCozinha.AllowUserToResizeColumns = false;
            this.gridCozinha.AllowUserToResizeRows = false;
            this.gridCozinha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCozinha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCozinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCozinha.Location = new System.Drawing.Point(73, 31);
            this.gridCozinha.MultiSelect = false;
            this.gridCozinha.Name = "gridCozinha";
            this.gridCozinha.ReadOnly = true;
            this.gridCozinha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCozinha.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCozinha.RowHeadersVisible = false;
            this.gridCozinha.RowHeadersWidth = 51;
            this.gridCozinha.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCozinha.RowTemplate.Height = 24;
            this.gridCozinha.RowTemplate.ReadOnly = true;
            this.gridCozinha.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCozinha.Size = new System.Drawing.Size(188, 392);
            this.gridCozinha.TabIndex = 0;
            this.gridCozinha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCozinha_CellClick);
            this.gridCozinha.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridCozinha_RowsAdded);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(316, 156);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 66);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(445, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 66);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(372, 252);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(108, 66);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lbCozinha
            // 
            this.lbCozinha.AutoSize = true;
            this.lbCozinha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCozinha.Location = new System.Drawing.Point(312, 47);
            this.lbCozinha.Name = "lbCozinha";
            this.lbCozinha.Size = new System.Drawing.Size(134, 23);
            this.lbCozinha.TabIndex = 2;
            this.lbCozinha.Text = "Tipo de Cozinha";
            this.lbCozinha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCozinha
            // 
            this.txtCozinha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCozinha.Location = new System.Drawing.Point(316, 73);
            this.txtCozinha.Name = "txtCozinha";
            this.txtCozinha.Size = new System.Drawing.Size(237, 30);
            this.txtCozinha.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(345, 379);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(146, 80);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // TipoCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 471);
            this.Controls.Add(this.txtCozinha);
            this.Controls.Add(this.lbCozinha);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridCozinha);
            this.MaximizeBox = false;
            this.Name = "TipoCozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Cozinha";
            this.Load += new System.EventHandler(this.TipoCozinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCozinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lbCozinha;
        private System.Windows.Forms.TextBox txtCozinha;
        private System.Windows.Forms.DataGridView gridCozinha;
        private System.Windows.Forms.Button btnMenu;
    }
}