using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema2
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt=false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false) 
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                button3.Text = "Ocultar senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                button3.Text = "Mostrar senha";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if(usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMensagem.Text = "Login bem-sucedido";
                labelMensagem.ForeColor = Color.Green;
                Menu form = new Menu();
                form.ShowDialog();
            }
            else
            {
                labelMensagem.Text = "Usuario ou senha Invalida";
                labelMensagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }





        }
    }
}
