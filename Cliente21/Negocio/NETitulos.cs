using Cliente21.Data;
using Cliente21.Entidade;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cliente21.Negocio
{
    public class NETitulos
    {
        #region CTOR
        public NETitulos() { }
        #endregion

        #region "Instance"
        private static NETitulos instancia;
        public static NETitulos Instance
        {
            get
            {
                if (instancia == null)
                    instancia = new NETitulos();

                return instancia;
            }

        }
        #endregion

        #region Valido
        bool valido = false;
        #endregion

        #region "ImportarXML"
        public void ImportarXML()
        {
            try
            {
                OpenFileDialog xml = new OpenFileDialog();
                xml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                xml.Title = "Selecione o arquivo.";
                string caminhoXML = "";
                string conteudoXML = "";
                if (xml.ShowDialog() == DialogResult.OK)
                {
                    caminhoXML = xml.FileName;
                    conteudoXML = System.IO.File.ReadAllText(caminhoXML);
                    valido = true;
                }
                else
                {
                    MessageBox.Show("Operação cancelada!");
                    valido = false;
                }

                if (valido)
                {
                    DialogResult resultado = MessageBox.Show("Deseja importar o XML?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ADTitulos.Instance.ImportarXml(conteudoXML);
                        MessageBox.Show("Importação finalizada!");
                    }
                    else
                    {
                        MessageBox.Show("A importação do XML foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        #endregion

        #region "ExibirTitulos"
        public DataSet ExibirTitulos()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ADTitulos.Instance.ExibirTitulos();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        #endregion

        #region "AlterarTitulo"

        public void AlterarTitulo(ENTitulos entidade)
        {
            try
            {
                ADTitulos.Instance.AlterarTitulo(entidade);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "ExcluirTitulo"
        public void ExcluirTitulo(int protocolo)
        {
            ADTitulos.Instance.ExcluirTitulo(protocolo);

        }
        #endregion
    }
}