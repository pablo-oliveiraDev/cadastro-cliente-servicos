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
            comm.CommandText = "select * from servicos order by" + '"' + "id_cliente" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewServicos.DataSource = dt;
                //comboBox1.DataSource = dt;

               
                
            }

            

        }
        public void refreshGrid()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from servicos order by" + '"' + "id_servicos" + '"', conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "servicos");
            dataGridViewServicos.DataSource = ds;
            dataGridViewServicos.DataMember = "servicos";
            conn.Close();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {

            
           
        }

        

        private void dataGridViewServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int select_row;


            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow grv = dataGridViewServicos.Rows[select_row];
                textidcliente.Text= grv.Cells[0].Value.ToString();
                textIdServico.Text = grv.Cells[1].Value.ToString();
                textNameService.Text= grv.Cells[2].Value.ToString();
                textEquip.Text= grv.Cells[3].Value.ToString();
                textPecas.Text  = grv.Cells[4].Value.ToString();
                textServices.Text = grv.Cells[5].Value.ToString();
                textValor.Text = grv.Cells[6].Value.ToString();
                textDesconto.Text = grv.Cells[7].Value.ToString();
                textDataService.Text = grv.Cells[8].Value.ToString();
                textValorTotal.Text = grv.Cells[9].Value.ToString();
                textDefeitos.Text = grv.Cells[10].Value.ToString();

            }

            else
            {

            }

        }

       

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            CadServicos frm = new CadServicos();
            frm.ShowDialog();
            refreshGrid();
        }

        private void btnAtualizar_click(object sender, EventArgs e)
        {
            Controls crtl = new Controls();
            crtl.SalvarUpSelectSevices(2, textidcliente.Text, textIdServico.Text,textNameService.Text, textEquip.Text, textPecas.Text,textServices.Text, textValor.Text, textDesconto.Text, textDataService.Text, textValor.Text, textDefeitos.Text);
            refreshGrid();
            

            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Controls crtl = new Controls();
            crtl.SalvarUpSelectSevices(3, textidcliente.Text, textIdServico.Text, textNameService.Text, textEquip.Text, textPecas.Text, textServices.Text, textValor.Text, textDesconto.Text, textDataService.Text, textValor.Text, textDefeitos.Text);
            refreshGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormServicos frm = new FormServicos();
            this.Dispose();
        }
    }
}
