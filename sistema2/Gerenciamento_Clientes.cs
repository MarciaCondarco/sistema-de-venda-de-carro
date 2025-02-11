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
    public partial class Gerenciamento_Clientes : Form
    {
        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
             //Defina a sua string de conexão com o banco

            string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão 
                    consulta.Open();
                    
                    //Consulta SQL para selecionar os clientes 
                    string listagem = "SELECT Id_Cliente, NomeCompleto, Telefone FROM tb_clientes";


                    //Cria o comando MySql 
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados 
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);


                        //Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dadosClientes;
                    }
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //ele pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

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
                            string listagem = "DELETE FROM tb_clientes WHERE Id_Cliente = @Id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Cliente", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");

                                }
                            }
                        }
                    }
                    catch   (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um cliente para excluir");
                }

            }
        }
    }
}
