using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPDS.RegrasDeNegocio;

namespace ProjetoPDS.Formularios
{
    public partial class CadastrarContato : Form
    {
        List<conta> contaList = new List<conta>();
        public CadastrarContato()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            conta conta = new conta();
            conta.id++;
            conta.nome = tbNome.Text;
            conta.sexo = tbSexo.Text;
            conta.email = tbEmail.Text;
            conta.telefone = tbTelefone.Text;
            conta.dataNascimento = dtpNascimento.Value;

            contaList.Add(conta);

            dgvDados.DataSource = contaList;

            limparEpacos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparEpacos();
        }

        public void limparEpacos()
        {
            tbNome.Clear();
            tbSexo.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
        }

        private void CadastrarContato_Load(object sender, EventArgs e)
        {

        }
    }
}
