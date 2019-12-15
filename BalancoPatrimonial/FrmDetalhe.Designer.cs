namespace BalancoPatrimonial
{
    partial class FrmDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhe));
            this.DgvNomesDetalhe = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GbxCadastro = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNomesDetalhe)).BeginInit();
            this.GbxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvNomesDetalhe
            // 
            this.DgvNomesDetalhe.AllowUserToAddRows = false;
            this.DgvNomesDetalhe.AllowUserToDeleteRows = false;
            this.DgvNomesDetalhe.AllowUserToResizeColumns = false;
            this.DgvNomesDetalhe.AllowUserToResizeRows = false;
            this.DgvNomesDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNomesDetalhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.Nomes});
            this.DgvNomesDetalhe.Location = new System.Drawing.Point(12, 115);
            this.DgvNomesDetalhe.MultiSelect = false;
            this.DgvNomesDetalhe.Name = "DgvNomesDetalhe";
            this.DgvNomesDetalhe.RowHeadersVisible = false;
            this.DgvNomesDetalhe.Size = new System.Drawing.Size(321, 338);
            this.DgvNomesDetalhe.TabIndex = 5;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "codigo";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            // 
            // Nomes
            // 
            this.Nomes.DataPropertyName = "nome";
            this.Nomes.HeaderText = "Nomes";
            this.Nomes.Name = "Nomes";
            this.Nomes.ReadOnly = true;
            this.Nomes.Width = 300;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(6, 12);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(309, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // GbxCadastro
            // 
            this.GbxCadastro.Controls.Add(this.BtnCancelar);
            this.GbxCadastro.Controls.Add(this.BtnConfirmar);
            this.GbxCadastro.Controls.Add(this.TxtNome);
            this.GbxCadastro.Location = new System.Drawing.Point(12, 41);
            this.GbxCadastro.Name = "GbxCadastro";
            this.GbxCadastro.Size = new System.Drawing.Size(321, 68);
            this.GbxCadastro.TabIndex = 4;
            this.GbxCadastro.TabStop = false;
            this.GbxCadastro.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(6, 38);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.AutoSize = true;
            this.BtnConfirmar.Location = new System.Drawing.Point(218, 38);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(97, 23);
            this.BtnConfirmar.TabIndex = 1;
            this.BtnConfirmar.Text = "Confirmar Edicao";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.Location = new System.Drawing.Point(174, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Visible = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(12, 12);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(93, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Red;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.Location = new System.Drawing.Point(255, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 465);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.GbxCadastro);
            this.Controls.Add(this.DgvNomesDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome dos Ativos Circulantes";
            this.Load += new System.EventHandler(this.FrmDetalhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNomesDetalhe)).EndInit();
            this.GbxCadastro.ResumeLayout(false);
            this.GbxCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvNomesDetalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomes;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.GroupBox GbxCadastro;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}