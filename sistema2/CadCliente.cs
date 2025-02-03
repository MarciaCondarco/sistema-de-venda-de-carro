using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using mysql.data.mysqlclient -> caso não tenha pode digitar que conecta o banco com c#

namespace sistema2
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {

        }


        private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }

        private void buttonLimparCampo_Click(object sender, EventArgs e)
        {
            textBoxNomeCompleto.Text = "";
            maskedTextBoxCPF.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxNomeCompleto.Focus();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF VALIDO";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {
                labelAlert.Text = "CPF INVALIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();

            }

            //Defina a sua string de conexão com o banco

            string conexaoString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            //Variavel que vai definir inserção de registro do banco 

            string query = "INSERT INTO tb_Clientes (NomeCompleto, Cpf, Email, Cep, Numero, Telefone) VALUES " +
                "(@NomeCompleto, @Cpf, @Email, @Cep, @Numero, @Telefone)";

            //criando uma conexão com o banco 

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                
                try
                {
                    //Abre a conexão 
                    conexao.Open();
                    //adicinar os parametros com os valores dos textBox
                    using (MySqlCommand comando = new MySqlCommand(query,conexao))
                    {
                        comando.Parameters.AddWithValue("@NomeCompleto", textBoxNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);

                        //Executa o comando de inserção

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxNomeCompleto.Text = "";
                        maskedTextBoxCPF.Text = "";
                        textBoxEmail.Text = "";
                        maskedTextBoxCEP.Text = "";
                        maskedTextBoxNumero.Text = "";
                        maskedTextBoxTelefone.Text = "";
                        textBoxNomeCompleto.Focus();
                    }
                        //testedsgh

                }
                catch (Exception ex) 
                {
                    //em caso de erro, exiba mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }


        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
