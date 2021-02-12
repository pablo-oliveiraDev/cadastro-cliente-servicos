using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Controles;
using FormClientes.Forms;


namespace FormClientes.Forms
{
    public partial class NovoCliente : Form
    {
        public NovoCliente FormNovoCliente { get; set; }
        public NovoCliente()
        {
            InitializeComponent();
        }
        
        
        
            
        
        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.SalvarTable(TextNome.Text, textEndereco.Text, textDataEntrada.Text);
            TextNome.Clear();
            textEndereco.Clear();
            textDataEntrada.Clear();
            FormCliente frm = new FormCliente();
            frm.refreshGrid();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.refreshGrid();
            this.Dispose();
        }
    }
}
