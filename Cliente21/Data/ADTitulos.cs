using System.Data.SqlClient;
using System.Data;
using Cliente21.Entidade;
using Cliente21.Negocio;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Cliente21.Data
{
    public class ADTitulos
    {
        #region "Instance"
        private static ADTitulos instancia;
        public static ADTitulos Instance
        {
            get
            {
                if (instancia == null)
                    instancia = new ADTitulos();

                return instancia;
            }

        }
        #endregion

        #region "Connection String"
        string connectionString = "Data Source=DESKTOP-H88RRLK;Initial Catalog=Cartorio;Integrated Security=True;";
        #endregion

        #region "ImportarXML"
        public void ImportarXml(string xml)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("PR_INS_Xml", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@xmlImportado", xml);
                        command.ExecuteNonQuery();
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("PR_SEL_Titulos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("PR_UPD_Titulo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@protocolo", entidade.Protocolo);
                        command.Parameters.AddWithValue("@nomeDevedor", entidade.NomeDevedor);
                        command.Parameters.AddWithValue("@documentoDevedor", entidade.DocumentoDevedor);
                        command.Parameters.AddWithValue("@nomeApresentante", entidade.NomeApresentante);
                        command.Parameters.AddWithValue("@documentoApresentante", entidade.DocumentoApresentante);
                        command.Parameters.AddWithValue("@nomeCredor", entidade.NomeCredor);
                        command.Parameters.AddWithValue("@documentoCredor", entidade.DocumentoCredor);
                        command.Parameters.AddWithValue("@numeroTitulo", entidade.NumeroTitulo);
                        command.Parameters.AddWithValue("@valorTitulo", entidade.ValorTitulo);
                        command.Parameters.AddWithValue("@dataEmissao", entidade.DataEmissao);
                        command.Parameters.AddWithValue("@especieTitulo", entidade.EspecieTitulo);
                        command.Parameters.AddWithValue("@dataApresentacao", entidade.DataApresentacao);
                        command.Parameters.AddWithValue("@valorCustas", entidade.ValorCustas);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "ExcluirTitulo"
        public void ExcluirTitulo(int protocolo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("PR_DEL_Titulo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@protocolo", protocolo);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
