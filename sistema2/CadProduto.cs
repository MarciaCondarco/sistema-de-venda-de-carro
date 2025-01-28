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

namespace sistema2
{
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCpf.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF VALIDO";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {
                labelAlert.Text = "CPF INVALIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCpf.Text = "";
                maskedTextBoxCpf.Focus();

            }
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxProprietario.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCpf.Text = "";
            textBoxPlaca.Text = "";
            textBoxModelo.Text = "";
            maskedTextBoxAno.Text = "";
            maskedTextBoxChassi.Text = "";
            textBoxCor.Text = "";
            textBoxMarca.Text = "";
            maskedTextBoxValor.Text = "";
            textBox1.Text = "";
            richTextBoxAcessorios.Text = "";
            textBoxProprietario.Focus();
        }
    }
}
