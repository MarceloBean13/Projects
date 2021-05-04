namespace PROJECTO__BACK_END_
{
    partial class TipoPrato
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
            this.txtPrato = new System.Windows.Forms.TextBox();
            this.lbTipoPrato = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvTipoPrato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPrato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrato
            // 
            this.txtPrato.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrato.Location = new System.Drawing.Point(281, 65);
            this.txtPrato.Name = "txtPrato";
            this.txtPrato.Size = new System.Drawing.Size(247, 30);
            this.txtPrato.TabIndex = 10;
            // 
            // lbTipoPrato
            // 
            this.lbTipoPrato.AutoSize = true;
            this.lbTipoPrato.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoPrato.Location = new System.Drawing.Point(277, 39);
            this.lbTipoPrato.Name = "lbTipoPrato";
            this.lbTipoPrato.Size = new System.Drawing.Size(113, 23);
            this.lbTipoPrato.TabIndex = 9;
            this.lbTipoPrato.Text = "Tipo de Prato";
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(337, 244);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 66);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(410, 148);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 66);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(310, 371);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(156, 67);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(281, 148);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(118, 66);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvTipoPrato
            // 
            this.dgvTipoPrato.AllowUserToAddRows = false;
            this.dgvTipoPrato.AllowUserToDeleteRows = false;
            this.dgvTipoPrato.AllowUserToResizeColumns = false;
            this.dgvTipoPrato.AllowUserToResizeRows = false;
            this.dgvTipoPrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoPrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoPrato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipoPrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPrato.Location = new System.Drawing.Point(12, 23);
            this.dgvTipoPrato.MultiSelect = false;
            this.dgvTipoPrato.Name = "dgvTipoPrato";
            this.dgvTipoPrato.ReadOnly = true;
            this.dgvTipoPrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoPrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoPrato.RowHeadersVisible = false;
            this.dgvTipoPrato.RowHeadersWidth = 51;
            this.dgvTipoPrato.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTipoPrato.RowTemplate.Height = 24;
            this.dgvTipoPrato.RowTemplate.ReadOnly = true;
            this.dgvTipoPrato.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoPrato.Size = new System.Drawing.Size(244, 392);
            this.dgvTipoPrato.TabIndex = 4;
            this.dgvTipoPrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPrato_CellClick);
            // 
            // TipoPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.txtPrato);
            this.Controls.Add(this.lbTipoPrato);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvTipoPrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TipoPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Prato";
            this.Load += new System.EventHandler(this.TipoPrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrato;
        private System.Windows.Forms.Label lbTipoPrato;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvTipoPrato;
    }
}