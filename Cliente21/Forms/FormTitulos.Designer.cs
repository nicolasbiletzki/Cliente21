namespace Cliente21
{
    partial class FormTitulos
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
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.gbTitulos = new System.Windows.Forms.GroupBox();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Location = new System.Drawing.Point(12, 408);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(89, 30);
            this.btnImportarXML.TabIndex = 1;
            this.btnImportarXML.Text = "Importar XML";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // gbTitulos
            // 
            this.gbTitulos.Controls.Add(this.dgvTitulos);
            this.gbTitulos.Location = new System.Drawing.Point(12, 12);
            this.gbTitulos.Name = "gbTitulos";
            this.gbTitulos.Size = new System.Drawing.Size(776, 390);
            this.gbTitulos.TabIndex = 2;
            this.gbTitulos.TabStop = false;
            this.gbTitulos.Text = "Titulos";
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.AllowUserToDeleteRows = false;
            this.dgvTitulos.AllowUserToResizeRows = false;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(6, 19);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.ReadOnly = true;
            this.dgvTitulos.RowHeadersVisible = false;
            this.dgvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitulos.Size = new System.Drawing.Size(764, 365);
            this.dgvTitulos.TabIndex = 0;
            this.dgvTitulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTitulos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double Click = Abrir tela de Edição / Exclusão";
            // 
            // FormTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTitulos);
            this.Controls.Add(this.btnImportarXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Titulos";
            this.gbTitulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImportarXML;
        private System.Windows.Forms.GroupBox gbTitulos;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.Label label1;
    }
}

