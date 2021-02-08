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
using FormClientes.Forms;

namespace FormClientes.Forms
{
    public partial class FormRevisao : Form
    {
        public FormRevisao()
        {

            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from revisao order by" + '"' + "idrevisao" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {


                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewRevisao.DataSource = dt;


            }
            
        }

        public void refreshGrid()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from revisao order by" + '"' + "idrevisao" + '"', conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "revisao");
            dataGridViewRevisao.DataSource = ds;
            dataGridViewRevisao.DataMember = "revisao";
            conn.Close();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRevisao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int select_row;


            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow grv = dataGridViewRevisao.Rows[select_row];
                textIdCliente.Text= grv.Cells[0].Value.ToString();
                textidService.Text = grv.Cells[1].Value.ToString();
                textIdRevisao.Text = grv.Cells[2].Value.ToString();
                textDataRevisao.Text = grv.Cells[3].Value.ToString();
            }

            else
            {

            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            CadRevisao frm = new CadRevisao();
            frm.Show();
        }

        private void FormRevisao_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.SalvarUpSelectRevisao(2, textIdCliente.Text, textidService.Text, textIdRevisao.Text, textDataRevisao.Text);
            ResetText();
            refreshGrid();
            
        }

        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.SalvarUpSelectRevisao(3, textIdCliente.Text, textidService.Text, textIdRevisao.Text, textDataRevisao.Text);
            ResetText();
            refreshGrid();
        }
    }
}
