
namespace Adega
{
    partial class FormAdega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescrição = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgAdega = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.labelCadastrarVinho = new System.Windows.Forms.Label();
            this.labelListaDeVinhos = new System.Windows.Forms.Label();
            this.sidebarAdega = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdega)).BeginInit();
            this.sidebarAdega.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(69, 239);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(33, 271);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(103, 25);
            this.labelCategoria.TabIndex = 1;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelDescrição
            // 
            this.labelDescrição.AutoSize = true;
            this.labelDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrição.Location = new System.Drawing.Point(31, 306);
            this.labelDescrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescrição.Name = "labelDescrição";
            this.labelDescrição.Size = new System.Drawing.Size(105, 25);
            this.labelDescrição.TabIndex = 2;
            this.labelDescrição.Text = "Descrição:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(87, 450);
            this.labelAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(54, 25);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "Ano:";
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.Firebrick;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(172, 239);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(133, 24);
            this.tbNome.TabIndex = 4;
            // 
            // tbCategoria
            // 
            this.tbCategoria.BackColor = System.Drawing.Color.Firebrick;
            this.tbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.Location = new System.Drawing.Point(172, 271);
            this.tbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(133, 24);
            this.tbCategoria.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.Firebrick;
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(36, 335);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(269, 112);
            this.tbDescricao.TabIndex = 6;
            // 
            // tbAno
            // 
            this.tbAno.BackColor = System.Drawing.Color.Firebrick;
            this.tbAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Location = new System.Drawing.Point(209, 454);
            this.tbAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(95, 24);
            this.tbAno.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Firebrick;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(13, 503);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(292, 46);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgAdega
            // 
            this.dgAdega.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dgAdega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAdega.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgAdega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgAdega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCategoria,
            this.colDescricao,
            this.colAno});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAdega.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgAdega.EnableHeadersVisualStyles = false;
            this.dgAdega.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgAdega.Location = new System.Drawing.Point(373, 116);
            this.dgAdega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgAdega.Name = "dgAdega";
            this.dgAdega.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAdega.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdega.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgAdega.RowHeadersVisible = false;
            this.dgAdega.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkRed;
            this.dgAdega.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgAdega.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
            this.dgAdega.Size = new System.Drawing.Size(904, 433);
            this.dgAdega.TabIndex = 9;
            this.dgAdega.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdega_CellContentClick);
            // 
            // colID
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.colID.DefaultCellStyle = dataGridViewCellStyle11;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 40;
            // 
            // colNome
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle12;
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.Width = 125;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.colCategoria.DefaultCellStyle = dataGridViewCellStyle13;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colDescricao
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle14;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 290;
            // 
            // colAno
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.colAno.DefaultCellStyle = dataGridViewCellStyle15;
            this.colAno.HeaderText = "Ano";
            this.colAno.MinimumWidth = 6;
            this.colAno.Name = "colAno";
            this.colAno.Width = 70;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.Firebrick;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(12, 556);
            this.btInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(293, 46);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.Firebrick;
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(172, 207);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(43, 22);
            this.tbID.TabIndex = 11;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(108, 207);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(31, 25);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "ID";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(515, 576);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(273, 57);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(855, 576);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(273, 57);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Remover";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // labelCadastrarVinho
            // 
            this.labelCadastrarVinho.AutoSize = true;
            this.labelCadastrarVinho.Font = new System.Drawing.Font("Verdana", 18F);
            this.labelCadastrarVinho.Location = new System.Drawing.Point(16, 116);
            this.labelCadastrarVinho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCadastrarVinho.Name = "labelCadastrarVinho";
            this.labelCadastrarVinho.Size = new System.Drawing.Size(275, 36);
            this.labelCadastrarVinho.TabIndex = 16;
            this.labelCadastrarVinho.Text = "Cadastrar Vinhos";
            // 
            // labelListaDeVinhos
            // 
            this.labelListaDeVinhos.AutoSize = true;
            this.labelListaDeVinhos.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaDeVinhos.Location = new System.Drawing.Point(832, 53);
            this.labelListaDeVinhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaDeVinhos.Name = "labelListaDeVinhos";
            this.labelListaDeVinhos.Size = new System.Drawing.Size(410, 60);
            this.labelListaDeVinhos.TabIndex = 17;
            this.labelListaDeVinhos.Text = "Lista de Vinhos";
            // 
            // sidebarAdega
            // 
            this.sidebarAdega.BackColor = System.Drawing.Color.Maroon;
            this.sidebarAdega.Controls.Add(this.tbDescricao);
            this.sidebarAdega.Controls.Add(this.labelNome);
            this.sidebarAdega.Controls.Add(this.labelCadastrarVinho);
            this.sidebarAdega.Controls.Add(this.labelCategoria);
            this.sidebarAdega.Controls.Add(this.labelDescrição);
            this.sidebarAdega.Controls.Add(this.labelAno);
            this.sidebarAdega.Controls.Add(this.btInserir);
            this.sidebarAdega.Controls.Add(this.labelId);
            this.sidebarAdega.Controls.Add(this.tbNome);
            this.sidebarAdega.Controls.Add(this.btLimpar);
            this.sidebarAdega.Controls.Add(this.tbID);
            this.sidebarAdega.Controls.Add(this.tbCategoria);
            this.sidebarAdega.Controls.Add(this.tbAno);
            this.sidebarAdega.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarAdega.Location = new System.Drawing.Point(0, 0);
            this.sidebarAdega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebarAdega.Name = "sidebarAdega";
            this.sidebarAdega.Size = new System.Drawing.Size(333, 647);
            this.sidebarAdega.TabIndex = 18;
            // 
            // FormAdega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1312, 647);
            this.Controls.Add(this.sidebarAdega);
            this.Controls.Add(this.labelListaDeVinhos);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgAdega);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adega";
            this.Load += new System.EventHandler(this.FormAdega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdega)).EndInit();
            this.sidebarAdega.ResumeLayout(false);
            this.sidebarAdega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescrição;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgAdega;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label labelCadastrarVinho;
        private System.Windows.Forms.Label labelListaDeVinhos;
        private System.Windows.Forms.Panel sidebarAdega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
    }
}

