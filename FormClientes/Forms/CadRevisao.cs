using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Controles;
using FormClientes;

namespace FormClientes.Forms
{
    public partial class CadRevisao : Form
    {
        public CadRevisao()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from cliente order by" + '"' + "IdCliente" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            cboIdCliente.DisplayMember = "IdCliente";
            cboIdCliente.DataSource = dt;
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from servicos order by" + '"' + "id_servicos" + '"';
             dr = comm.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            cboIdServicos.DisplayMember = "id_servicos";
            cboIdServicos.DataSource = dt;
            conn.Close();
            



        }

        private void CadRevisao_Load(object sender, EventArgs e)
        {

        }
        

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            FormRevisao frmRev = new FormRevisao();
            frmRev.refreshGrid();
            
            

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            
            Controls ctrl = new Controls();
            ctrl.SalvarUpSelectRevisao(1,cboIdCliente.Text,cboIdServicos.Text,default,textDataRevisao.Text);
            FormRevisao frmRev = new FormRevisao();
            frmRev.refreshGrid();
        }
    }
}
