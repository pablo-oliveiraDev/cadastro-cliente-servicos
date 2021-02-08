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

namespace FormClientes.Forms
{
    public partial class ConsultaServico : Form
    {
        public ConsultaServico()
        {
            InitializeComponent();


        }

        public void ConsultaCliente(string nome)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * FROM cliente WHERE nome='" + nome + "'";
            NpgsqlDataReader nc = comm.ExecuteReader();

            DataTable clientes = new DataTable();
            clientes.Load(nc);
            //string clien;
            dataGridViewConsulta.DataSource = clientes;
            
            
            
                
                DataGridViewRow grv = dataGridViewConsulta.Rows[0];
                string idrow = grv.Cells[0].Value.ToString();
                int numberGrid = int.Parse(idrow);
           
            MessageBox.Show(idrow);
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select id_cliente,id_servicos,valtotal from servicos where" + '"' + "id_cliente" + '"' + "=" + numberGrid;
            MessageBox.Show(comm.CommandText);
            NpgsqlDataReader dr = comm.ExecuteReader();
            
            if (dr.HasRows)
            {


                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewConsulta2.DataSource = dt;


            }
            
           conn.Close();




        }
        private void CadRevisao_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormRevisao frmRev = new FormRevisao();
            frmRev.refreshGrid();

            this.Dispose();

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void textNomeCliente_TextChanged(object sender, EventArgs e)
        {

            int texto = textNomeCliente.Text.Length;
            if (textNomeCliente.Text != null && texto >= 5)
            {
                ConsultaCliente(textNomeCliente.Text);
            }
        }
    }
}
