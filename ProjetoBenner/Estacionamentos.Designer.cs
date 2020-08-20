namespace ProjetoBenner
{
    partial class Estacionamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDataSet3 = new ProjetoBenner.EstacionamentoDataSet3();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDataSet2 = new ProjetoBenner.EstacionamentoDataSet2();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDataSet1 = new ProjetoBenner.EstacionamentoDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new ProjetoBenner.EstacionamentoDataSet1TableAdapters.clienteTableAdapter();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.clienteTableAdapter1 = new ProjetoBenner.EstacionamentoDataSet2TableAdapters.clienteTableAdapter();
            this.clienteTableAdapter2 = new ProjetoBenner.EstacionamentoDataSet3TableAdapters.clienteTableAdapter();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horariosaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorapagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.horarioentradaDataGridViewTextBoxColumn,
            this.horariosaidaDataGridViewTextBoxColumn,
            this.duracaoDataGridViewTextBoxColumn,
            this.valorapagarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.estacionamentoDataSet3;
            // 
            // estacionamentoDataSet3
            // 
            this.estacionamentoDataSet3.DataSetName = "EstacionamentoDataSet3";
            this.estacionamentoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.estacionamentoDataSet2;
            // 
            // estacionamentoDataSet2
            // 
            this.estacionamentoDataSet2.DataSetName = "EstacionamentoDataSet2";
            this.estacionamentoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.estacionamentoDataSet1;
            // 
            // estacionamentoDataSet1
            // 
            this.estacionamentoDataSet1.DataSetName = "EstacionamentoDataSet1";
            this.estacionamentoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estacionamento";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(173, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carro bem Guardado";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEntrada.Location = new System.Drawing.Point(538, 79);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(118, 31);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Marcar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaida.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSaida.Location = new System.Drawing.Point(662, 79);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(118, 31);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Marcar Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(679, 415);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // clienteTableAdapter2
            // 
            this.clienteTableAdapter2.ClearBeforeFill = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(538, 53);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(242, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pesquisar por Placa:";
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 30;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioentradaDataGridViewTextBoxColumn
            // 
            this.horarioentradaDataGridViewTextBoxColumn.DataPropertyName = "horario_entrada";
            this.horarioentradaDataGridViewTextBoxColumn.HeaderText = "Horário de Chegada";
            this.horarioentradaDataGridViewTextBoxColumn.Name = "horarioentradaDataGridViewTextBoxColumn";
            this.horarioentradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioentradaDataGridViewTextBoxColumn.Width = 140;
            // 
            // horariosaidaDataGridViewTextBoxColumn
            // 
            this.horariosaidaDataGridViewTextBoxColumn.DataPropertyName = "horario_saida";
            this.horariosaidaDataGridViewTextBoxColumn.HeaderText = "Horario de Saída";
            this.horariosaidaDataGridViewTextBoxColumn.Name = "horariosaidaDataGridViewTextBoxColumn";
            this.horariosaidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horariosaidaDataGridViewTextBoxColumn.Width = 140;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duração";
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            this.duracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // valorapagarDataGridViewTextBoxColumn
            // 
            this.valorapagarDataGridViewTextBoxColumn.DataPropertyName = "valor_a_pagar";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.valorapagarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorapagarDataGridViewTextBoxColumn.HeaderText = "Valor a Pagar";
            this.valorapagarDataGridViewTextBoxColumn.Name = "valorapagarDataGridViewTextBoxColumn";
            this.valorapagarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProjetoBenner.Properties.Resources.estacionamentoimage;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(598, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Estacionamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Estacionamentos";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Estacionamentos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Estacionamentos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Estacionamentos_FormClosed);
            this.Load += new System.EventHandler(this.Estacionamentos_Load);
            this.Leave += new System.EventHandler(this.Estacionamentos_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        public System.Windows.Forms.DataGridView dataGridView1;
        private EstacionamentoDataSet1 estacionamentoDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private EstacionamentoDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnFinalizar;
        private EstacionamentoDataSet2 estacionamentoDataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private EstacionamentoDataSet2TableAdapters.clienteTableAdapter clienteTableAdapter1;
        private EstacionamentoDataSet3 estacionamentoDataSet3;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private EstacionamentoDataSet3TableAdapters.clienteTableAdapter clienteTableAdapter2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariosaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorapagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcluir;
    }
}

