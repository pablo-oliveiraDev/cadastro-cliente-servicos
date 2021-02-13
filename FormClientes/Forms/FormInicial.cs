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
            FormCliente cli = new FormCliente();
            cli.Show();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCliente cadcli = new NovoCliente();
            cadcli.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicos serv = new FormServicos();
            serv.Show();
        }

        private void cadastroServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadServicos cadServ = new CadServicos();
            cadServ.Show();
        }

        private void revisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRevisao rev = new FormRevisao();
            rev.Show();
        }

        private void casdastroRevisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadRevisao cadRev = new CadRevisao();
            cadRev.Show();
        }

        private void cnsultaServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaServico consul = new ConsultaServico();
            consul.Show();
            
        }

       
    }
}
