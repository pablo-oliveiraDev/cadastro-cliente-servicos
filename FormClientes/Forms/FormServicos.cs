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
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from servicos order by" + '"' + "Id_Cliente" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewServicos.DataSource = dt;
                comboBox1.DataSource = dt;

               
                
            }

            

        }

        private void Servicos_Load(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select" + '"' + "IdCliente" + '"' + " From cliente";
            NpgsqlDataReader dr = comm.ExecuteReader();





            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DisplayMember = "IdCliente";
            comboBox1.DataSource = dt;
           
        }

        

        private void dataGridViewServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            CadServicos frm = new CadServicos();
            frm.ShowDialog();
        }
    }
}
