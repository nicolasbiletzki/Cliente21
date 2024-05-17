using Cliente21.Entidade;
using Cliente21.Forms;
using Cliente21.Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cliente21
{
    public partial class FormTitulos : Form
    {
        public FormTitulos()
        {
            InitializeComponent();
            ExibirTitulos();
        }

        #region "Métodos"
        
        #region "ImportarXml
        public void ImportarXml()
        {
            try 
            {
               NETitulos.Instance.ImportarXML();
            }
            catch(Exception ex)
            {
                
            }
        }

        #endregion

        #region "ExibirTitulos"
        public void ExibirTitulos()
        {
            DataSet ds = new DataSet();
            try 
            {
                ds = NETitulos.Instance.ExibirTitulos();
                dgvTitulos.DataSource = ds.Tables[0];
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #endregion

        #region "Eventos"

        #region "btnImportar_Click"
        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            ImportarXml();
            ExibirTitulos();
        }

        #endregion

        private void formEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExibirTitulos();
        }
        #endregion


        private void dgvTitulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTitulos.Rows[e.RowIndex];
                ENTitulos entidade = new ENTitulos();

                entidade.Protocolo = Convert.ToInt32(row.Cells["Protocolo"].Value.ToString());
                entidade.NomeDevedor = row.Cells["NomeDevedor"].Value.ToString();
                entidade.DocumentoDevedor = row.Cells["DocumentoDevedor"].Value.ToString();
                entidade.NomeApresentante = row.Cells["NomeApresentante"].Value.ToString();
                entidade.DocumentoApresentante = row.Cells["DocumentoApresentante"].Value.ToString();
                entidade.NomeCredor = row.Cells["NomeCredor"].Value.ToString();
                entidade.DocumentoCredor = row.Cells["DocumentoCredor"].Value.ToString();
                entidade.NumeroTitulo = Convert.ToInt32(row.Cells["NumeroTitulo"].Value.ToString());
                entidade.ValorTitulo = Convert.ToDecimal(row.Cells["ValorTitulo"].Value.ToString());
                entidade.DataEmissao = Convert.ToDateTime(row.Cells["DataEmissao"].Value.ToString()).Date;
                entidade.EspecieTitulo = row.Cells["EspecieTitulo"].Value.ToString();
                entidade.DataApresentacao = Convert.ToDateTime(row.Cells["DataApresentacao"].Value.ToString()).Date;
                entidade.ValorCustas = Convert.ToDecimal(row.Cells["ValorCustas"].Value.ToString());


                FormEditar formEditar = new FormEditar(entidade);
                formEditar.FormClosed += formEditar_FormClosed;
                formEditar.ShowDialog();

            }
        }
    }
}
