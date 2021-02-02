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
            Controls ctrl = new Controls();
            
            double converValor = double.Parse(textValor.Text);
            double converDesconto = double.Parse(textDesconto.Text);
            double converValorTotal = double.Parse(textValorTotal.Text);
            ctrl.SalvarServ(comboBox1.SelectedItem.ToString(),textNameService.Text,textEquip.Text,textPecas.Text,textServices.Text,converValor,converDesconto,textDataService.Text,converValorTotal,textDefeitos.Text);
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
