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


namespace FormCliente
{
    public partial class Form1 : Form
    {
        public Form1 FormCliente { get; set; }
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from cliente";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewCliente.DataSource = dt;

            }


            comm.Dispose();
            conn.Close();


        }
        public void refreshGrid()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            dataGridViewCliente.DataSource = ds;
            dataGridViewCliente.DataMember = "cliente";
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int idCliente = 11;
            Controls ctrl = new Controls();
            ctrl.SalvarTable(TextNome.Text, textEndereco.Text, textDataEntrada.Text);
            TextNome.Clear();
            textEndereco.Clear();
            textDataEntrada.Clear();
            refreshGrid();


        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int select_row;


            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow grv = dataGridViewCliente.Rows[select_row];
                textId.Text = grv.Cells[0].Value.ToString();
                TextNome.Text = grv.Cells[1].Value.ToString();
                textEndereco.Text = grv.Cells[2].Value.ToString();
                textDataEntrada.Text = grv.Cells[3].Value.ToString();
            }

            else
            {

            }
        }

        private void BtnCadNovo(object sender, EventArgs e)
        {


            NovoCliente cliform = new NovoCliente();


            cliform.ShowDialog();
            

        }

        private void BtncadCancel(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void BtnAtualizar(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.UpdateBd(textId.Text,TextNome.Text, textEndereco.Text, textDataEntrada.Text);
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            


            
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            
            Controls crtl = new Controls();
            //int convId = int.Parse(textId.Text);
            crtl.DeletarBd(textId.Text);
            refreshGrid();
        }
    }
}
