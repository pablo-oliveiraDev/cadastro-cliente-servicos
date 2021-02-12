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
    public partial class FormInicial : Form
    {
        public FormInicial FrmInicial { get; set; }

        FormCliente cli = new FormCliente();
        NovoCliente cadcli = new NovoCliente();
        FormServicos serv = new FormServicos();
        CadServicos cadServ = new CadServicos();
        FormRevisao rev = new FormRevisao();
        CadRevisao cadRev = new CadRevisao();
        ConsultaServico consul = new ConsultaServico();
        public FormInicial()
        {
            InitializeComponent();
            


        }
        
        
        
            
        
       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cli.Show();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcli.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serv.Show();
        }

        private void cadastroServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadServ.Show();
        }

        private void revisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rev.Show();
        }

        private void casdastroRevisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadRev.Show();
        }

        private void cnsultaServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consul.Show();
        }
    }
}
