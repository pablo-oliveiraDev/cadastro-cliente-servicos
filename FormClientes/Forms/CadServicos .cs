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
using System.Globalization;

namespace FormClientes.Forms
{
    public partial class CadServicos : Form
    {
        public CadServicos()
        {
            InitializeComponent();
            
            

        }

        private void Servicos_Load(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from cliente order by" + '"' + "IdCliente" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();





            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DisplayMember = "IdCliente";
            comboBox1.DataSource = dt;
            conn.Close();
            
        }

        

        private void dataGridViewServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
                       
            ctrl.SalvarServ(comboBox1.Text,textNameService.Text,textEquip.Text,textPecas.Text,textServices.Text,textValor.Text,textDesconto.Text,textDataService.Text,textValor.Text,textDefeitos.Text);
            ctrl.limparText();
            FormServicos frm = new FormServicos();
            frm.refreshGrid();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
