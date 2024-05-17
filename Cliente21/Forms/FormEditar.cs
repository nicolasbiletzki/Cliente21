using Cliente21.Data;
using Cliente21.Entidade;
using Cliente21.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente21.Forms
{
    public partial class FormEditar : Form
    {
        #region "Ctor"
        public FormEditar(ENTitulos entidade)
        {
            InitializeComponent();
            txtProtocolo.Text = entidade.Protocolo.ToString();
            txtNomeDevedor.Text = entidade.NomeDevedor.ToString();
            txtDocumentoDevedor.Text = entidade.DocumentoDevedor.ToString();
            txtNomeApresentante.Text = entidade.NomeApresentante.ToString();
            txtDocumentoApresentante.Text = entidade.DocumentoApresentante.ToString();
            txtNomeCredor.Text = entidade.NomeCredor.ToString();
            txtDocumentoCredor.Text = entidade.DocumentoCredor.ToString();
            txtNumeroTitulo.Text = entidade.NumeroTitulo.ToString();
            txtValorTitulo.Text = entidade.ValorTitulo.ToString();
            dtpDataEmissao.Value = (DateTime)entidade.DataEmissao;
            txtEspecieTitulo.Text = entidade.EspecieTitulo.ToString();
            dtpDataApresentacao.Value = (DateTime)entidade.DataApresentacao;
            txtValorCustas.Text = entidade.ValorCustas.ToString();

            txtProtocolo.Enabled = false;
        }

        #endregion


        #region AlterarTitulo
        public void AlterarTitulo()
        {
            ENTitulos entidade = new ENTitulos();

            entidade.Protocolo = Convert.ToInt32(txtProtocolo.Text);
            entidade.NomeDevedor = txtNomeDevedor.Text;
            entidade.DocumentoDevedor = txtDocumentoDevedor.Text;
            entidade.NomeApresentante = txtNomeApresentante.Text;
            entidade.DocumentoApresentante = txtDocumentoApresentante.Text;
            entidade.NomeCredor = txtNomeCredor.Text;
            entidade.DocumentoCredor = txtDocumentoCredor.Text;
            entidade.NumeroTitulo = Convert.ToInt32(txtNumeroTitulo.Text);
            entidade.ValorTitulo = Convert.ToDecimal(txtValorTitulo.Text);
            entidade.DataEmissao = dtpDataEmissao.Value;
            entidade.EspecieTitulo = txtEspecieTitulo.Text;
            entidade.DataApresentacao = dtpDataApresentacao.Value;
            entidade.ValorCustas = Convert.ToDecimal(txtValorCustas.Text);

            NETitulos.Instance.AlterarTitulo(entidade);
        }

        #endregion

        #region "ExcluirTitulo"
        public void ExcluirTitulo(int protocolo)
        {
            NETitulos.Instance.ExcluirTitulo(protocolo);
        }
        #endregion

        #region btnSalvar_click
        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"Deseja alterar o Título? Protocolo {txtProtocolo.Text}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                AlterarTitulo();
                MessageBox.Show("Alteração concluída!");
                this.Close();
            }
            else
            {
                MessageBox.Show("A alteração foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        #endregion

        #region "txtValorTitulo_KeyPress"
        private void txtValorTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (txtValorTitulo.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        #endregion

        #region "btnExcluir_Click"
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"Deseja Excluir o Título? Protocolo {txtProtocolo.Text}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ExcluirTitulo(Convert.ToInt32(txtProtocolo.Text));
                MessageBox.Show("Exclusão concluída!");
                this.Close();
            }
            else
            {
                MessageBox.Show("A Exclusão foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "btnFechar_Click"
        private void btnFecharEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
