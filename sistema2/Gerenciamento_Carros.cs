using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema2
{
    public partial class Gerenciamento_Carros : Form
    {
        public Gerenciamento_Carros()
        {
            InitializeComponent();
        }

        private void buttonPesquisaCarros_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão 
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes 
                    string listagem = "SELECT * FROM tb_carros";


                    //Cria o comando MySql 
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados 
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosCarros = new DataTable();
                        dadosCarros.Load(reader);


                        //Atribui a tabela de dados ao DataGridView
                        dataGridViewGerenciamentoCarros.DataSource = dadosCarros;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os carros: " + ex.Message);
            }
        }

        private void buttonRemoverCarros_Click(object sender, EventArgs e)
        {
            if (dataGridViewGerenciamentoCarros.SelectedRows.Count > 0)
            {
                //ele pega ID do cliente da linha selecionada
                int carroID = Convert.ToInt32(dataGridViewGerenciamentoCarros.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este carro?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão 
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes 
                            string listagem = "DELETE FROM tb_carros WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Carro excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o carro");

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um carro para excluir");
                }

            }
        }
    }
}
