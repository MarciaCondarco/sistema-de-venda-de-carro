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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadCliente form = new CadCliente();
            form.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadProduto form = new CadProduto();
            form.ShowDialog();
        }

        private void buttonGerenciamentoCliente_Click(object sender, EventArgs e)
        {
            Gerenciamento_Clientes form = new Gerenciamento_Clientes();
            form.ShowDialog();
        }

        private void buttonConsultarProduto_Click(object sender, EventArgs e)
        {
            Gerenciamento_Carros form = new Gerenciamento_Carros();
            form.ShowDialog();
        }
    }
}
