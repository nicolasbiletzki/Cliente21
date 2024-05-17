namespace Cliente21.Forms
{
    partial class FormEditar
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
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFecharEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.txtNomeDevedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumentoDevedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeApresentante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoApresentante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCredor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocumentoCredor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEspecieTitulo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.dtpDataApresentacao = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorCustas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(16, 307);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAlteracao.TabIndex = 0;
            this.btnSalvarAlteracao.Text = "Salvar";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(97, 307);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFecharEditar
            // 
            this.btnFecharEditar.Location = new System.Drawing.Point(324, 307);
            this.btnFecharEditar.Name = "btnFecharEditar";
            this.btnFecharEditar.Size = new System.Drawing.Size(75, 23);
            this.btnFecharEditar.TabIndex = 2;
            this.btnFecharEditar.Text = "Fechar";
            this.btnFecharEditar.UseVisualStyleBackColor = true;
            this.btnFecharEditar.Click += new System.EventHandler(this.btnFecharEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Protocolo";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Location = new System.Drawing.Point(16, 30);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(182, 20);
            this.txtProtocolo.TabIndex = 4;
            // 
            // txtNomeDevedor
            // 
            this.txtNomeDevedor.Location = new System.Drawing.Point(16, 70);
            this.txtNomeDevedor.Name = "txtNomeDevedor";
            this.txtNomeDevedor.Size = new System.Drawing.Size(182, 20);
            this.txtNomeDevedor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Devedor";
            // 
            // txtDocumentoDevedor
            // 
            this.txtDocumentoDevedor.Location = new System.Drawing.Point(16, 110);
            this.txtDocumentoDevedor.Name = "txtDocumentoDevedor";
            this.txtDocumentoDevedor.Size = new System.Drawing.Size(182, 20);
            this.txtDocumentoDevedor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Documento Devedor";
            // 
            // txtNomeApresentante
            // 
            this.txtNomeApresentante.Location = new System.Drawing.Point(16, 150);
            this.txtNomeApresentante.Name = "txtNomeApresentante";
            this.txtNomeApresentante.Size = new System.Drawing.Size(182, 20);
            this.txtNomeApresentante.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome Apresentante";
            // 
            // txtDocumentoApresentante
            // 
            this.txtDocumentoApresentante.Location = new System.Drawing.Point(16, 190);
            this.txtDocumentoApresentante.Name = "txtDocumentoApresentante";
            this.txtDocumentoApresentante.Size = new System.Drawing.Size(182, 20);
            this.txtDocumentoApresentante.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Documento Apresentante";
            // 
            // txtNomeCredor
            // 
            this.txtNomeCredor.Location = new System.Drawing.Point(16, 230);
            this.txtNomeCredor.Name = "txtNomeCredor";
            this.txtNomeCredor.Size = new System.Drawing.Size(182, 20);
            this.txtNomeCredor.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome Credor";
            // 
            // txtDocumentoCredor
            // 
            this.txtDocumentoCredor.Location = new System.Drawing.Point(16, 272);
            this.txtDocumentoCredor.Name = "txtDocumentoCredor";
            this.txtDocumentoCredor.Size = new System.Drawing.Size(182, 20);
            this.txtDocumentoCredor.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Documento Credor";
            // 
            // txtNumeroTitulo
            // 
            this.txtNumeroTitulo.Location = new System.Drawing.Point(217, 30);
            this.txtNumeroTitulo.Name = "txtNumeroTitulo";
            this.txtNumeroTitulo.Size = new System.Drawing.Size(182, 20);
            this.txtNumeroTitulo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numero Titulo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor Titulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data Emissão";
            // 
            // txtEspecieTitulo
            // 
            this.txtEspecieTitulo.Location = new System.Drawing.Point(217, 150);
            this.txtEspecieTitulo.Name = "txtEspecieTitulo";
            this.txtEspecieTitulo.Size = new System.Drawing.Size(182, 20);
            this.txtEspecieTitulo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Espécie Titulo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 25;
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Location = new System.Drawing.Point(217, 110);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(182, 20);
            this.dtpDataEmissao.TabIndex = 27;
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.Location = new System.Drawing.Point(217, 70);
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.Size = new System.Drawing.Size(182, 20);
            this.txtValorTitulo.TabIndex = 28;
            this.txtValorTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTitulo_KeyPress);
            // 
            // dtpDataApresentacao
            // 
            this.dtpDataApresentacao.Location = new System.Drawing.Point(217, 190);
            this.dtpDataApresentacao.Name = "dtpDataApresentacao";
            this.dtpDataApresentacao.Size = new System.Drawing.Size(182, 20);
            this.dtpDataApresentacao.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Data Apresentação";
            // 
            // txtValorCustas
            // 
            this.txtValorCustas.Location = new System.Drawing.Point(217, 230);
            this.txtValorCustas.Name = "txtValorCustas";
            this.txtValorCustas.Size = new System.Drawing.Size(182, 20);
            this.txtValorCustas.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Valor das Custas";
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 342);
            this.Controls.Add(this.txtValorCustas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDataApresentacao);
            this.Controls.Add(this.txtValorTitulo);
            this.Controls.Add(this.dtpDataEmissao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEspecieTitulo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumeroTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDocumentoCredor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeCredor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocumentoApresentante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeApresentante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumentoDevedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDevedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProtocolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFecharEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvarAlteracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar / Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFecharEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.TextBox txtNomeDevedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumentoDevedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeApresentante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoApresentante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCredor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocumentoCredor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEspecieTitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataApresentacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorCustas;
        private System.Windows.Forms.Label label14;
    }
}