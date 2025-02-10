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
    }
}
