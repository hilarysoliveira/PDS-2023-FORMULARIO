using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPDS.Formularios;
using Mysql.Data.MysqlClient;

namespace ProjetoPDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            CadastrarContato form = new CadastrarContato();
            form.ShowDialog();
        }
    }
}
